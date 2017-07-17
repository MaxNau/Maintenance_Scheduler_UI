using Maintenance_Scheduler_BAL.Models;
using Maintenance_Scheduler_BAL.SchedulerJobs;
using Quartz;
using Quartz.Impl;
using Quartz.Impl.Matchers;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Configuration;

namespace Maintenance_Scheduler_BAL
{
    /// <summary>
    /// Getts the configuration and scheduler and then starts the scheduler
    /// </summary>
    public static class MaintenanceScheduler
    {
        private static IScheduler scheduler;

        /// <summary>
        /// Starts the scheduler
        /// </summary>
        public static void Start()
        {
            var config = (NameValueCollection)ConfigurationManager.GetSection("quartz");

            ISchedulerFactory schedulerFactory = new StdSchedulerFactory(config);
            scheduler = schedulerFactory.GetScheduler();

            scheduler.Start();
        }

        /// <summary>
        /// Stops the scheduler
        /// </summary>
        public static void Stop()
        {
            scheduler.Shutdown();
        }

        #region Scheduler Specification

        /// <summary>
        /// Creates job
        /// </summary>
        /// <param name="jobName"> Name of the job </param>
        /// <param name="jobMessage"> Message that will be sent to notify 
        /// all interested users </param>
        /// <returns> Returns created job </returns>
        private static IJobDetail CreateLocalNotifierJob(string jobName, string jobMessage)
        {
            IJobDetail job = JobBuilder.Create<MaintenanceJob>().WithIdentity(jobName).Build();
            job.JobDataMap["Message"] = jobMessage;
            return job;
        }

        /// <summary>
        /// Creates mailing job
        /// </summary>
        /// <param name="jobName"></param>
        /// <param name="jobMessage"></param>
        /// <param name="jobMailSubject"></param>
        /// <param name="jobMailBody"></param>
        /// <returns></returns>
        private static IJobDetail CreateMailingNotifierJob(string jobName, string jobMessage, string jobMailSubject, string jobMailBody)
        {
            IJobDetail job = JobBuilder.Create<MailingJob>().WithIdentity(jobName).Build();
            job.JobDataMap["Message"] = jobMessage;
            job.JobDataMap["MailSubject"] = jobMailSubject;
            job.JobDataMap["MailBody"] = jobMailBody;
            return job;
        }

        /// <summary>
        /// Creates trigger 
        /// </summary>
        /// <param name="triggerName"> Name of the trigger </param>
        /// <returns> Returns created trigger </returns>
        private static ITrigger CreateTrigger(string triggerName)
        {
            return TriggerBuilder.Create()
                .WithIdentity(triggerName)
                .StartNow()
                .WithSimpleSchedule(x => x
                .WithIntervalInSeconds(10)
                .RepeatForever())
                .Build();
        }

        /// <summary>
        /// Schedules the created job and it's created trigger to be executed
        /// </summary>
        /// <param name="jobName"> Name of the job </param>
        /// <param name="jobMessage"> Message that will be sent to notify
        /// all interested users</param>
        /// <param name="triggerName"> Name of the trigger </param>
        /// <param name="jobMailSubject"> email subject </param>
        /// <param name="jobMailBody"> html body </param>
        public static void ScheduleJob(string jobName, string jobMessage, MaintenanceJobType jobType, string triggerName, string jobMailSubject = "", string jobMailBody = "")
        {
            if (jobType == MaintenanceJobType.Local)
                scheduler.ScheduleJob(CreateLocalNotifierJob(jobName, jobMessage), CreateTrigger(triggerName));
            else if (jobType == MaintenanceJobType.Mailing)
                scheduler.ScheduleJob(CreateMailingNotifierJob(jobName, jobMessage, jobMailSubject, jobMailBody), CreateTrigger(triggerName));
        }

        public static void ScheduleDailyJob(string jobName, string jobMessage, string triggerName, DateTime startDate, int daysInterval)
        {
            scheduler.ScheduleJob(CreateLocalNotifierJob(jobName, jobMessage), CreateDailyBasedtrigger(triggerName, startDate, daysInterval));
        }

        /// <summary>
        /// Schedules job using assigned cron trigger
        /// </summary>
        /// <param name="jobName"></param>
        /// <param name="jobMessage"></param>
        /// <param name="triggerName"></param>
        /// <param name="cronExpression"></param>
        public static void ScheduleJobWithCronTrigger(string jobName, string jobMessage, StringsConstantsAndEnumerations.Enumerations.MaintenanceJobType jobType, string triggerName, string cronExpression, string startDate, string jobMailSubject = "", string jobMailBody = "")
        {
            if (jobType == StringsConstantsAndEnumerations.Enumerations.MaintenanceJobType.Local)
                scheduler.ScheduleJob(CreateLocalNotifierJob(jobName, jobMessage), CreateCronTrigger(triggerName, cronExpression, startDate));
            else if (jobType == StringsConstantsAndEnumerations.Enumerations.MaintenanceJobType.Mailing)
                scheduler.ScheduleJob(CreateMailingNotifierJob(jobName, jobMessage, jobMailSubject, jobMailBody), CreateCronTrigger(triggerName, cronExpression, startDate));
        }

        private static ITrigger CreateDailyBasedtrigger(string triggerName, DateTime startDate, int daysInteval)
        {
            return TriggerBuilder.Create()
                .WithIdentity(triggerName)
                .WithCalendarIntervalSchedule(x => x.WithIntervalInDays(daysInteval))
                .StartAt(startDate)
                .Build();
        }

        /// <summary>
        /// Creates cron trigger 
        /// </summary>
        /// <param name="triggerName"></param>
        /// <param name="cronExpression"></param>
        /// <returns></returns>
        private static ITrigger CreateCronTrigger(string triggerName, string cronExpression, string startDate)
        {
            return TriggerBuilder.Create()
                .WithIdentity(triggerName)
                .WithCronSchedule(cronExpression)
                .StartAt(DateTimeOffset.ParseExact(startDate,
    "dd/MM/yyyy HH.mm.ss", System.Globalization.CultureInfo.InvariantCulture))
                .Build();
        }

        public static BindingList<ITrigger> getAllTriggers()
        {
            BindingList<ITrigger> triggers = new BindingList<ITrigger>();
            var allTriggerKeys = scheduler.GetTriggerKeys(GroupMatcher<TriggerKey>.AnyGroup());
            foreach (var triggerKey in allTriggerKeys)
            {
                ITrigger trigger = scheduler.GetTrigger(triggerKey);
                triggers.Add(scheduler.GetTrigger(triggerKey));
            }
            return triggers;
        }

        /// <summary>
        /// Removes job by its name from the scheduler
        /// </summary>
        /// <param name="jobName"></param>
        public static void RemoveJob(string jobName)
        {
            JobKey jobKey = new JobKey(jobName);
            scheduler.DeleteJob(jobKey);
        }

        /// <summary>
        /// Gets all triggers 
        /// </summary>
        /// <returns></returns>
        public static ICollection<TriggerModel> GetAllTriggers()
        {
            List<TriggerModel> triggers = new List<TriggerModel>();
            var triggerKeys = scheduler.GetTriggerKeys(GroupMatcher<TriggerKey>.AnyGroup());
            foreach (TriggerKey key in triggerKeys)
            {
                ITrigger trigger = scheduler.GetTrigger(key);

                if (trigger is ICronTrigger)
                {
                    triggers.Add(new TriggerModel()
                    {
                        JobName = trigger.JobKey.Name,
                        Name = trigger.Key.Name,
                        Type = trigger.GetType().Name,
                        StartTimeDate = trigger.StartTimeUtc,
                        EndTimeDate = trigger.EndTimeUtc,
                        PreviousFireTimeDate = trigger.GetPreviousFireTimeUtc(),
                        NextFireTimeDate = trigger.GetNextFireTimeUtc(),
                        Message = scheduler.GetJobDetail(trigger.JobKey).JobDataMap.GetString("Message"),
                        CronExpression = ((ICronTrigger)trigger).CronExpressionString
                    });
                }
            }

            return triggers;
        }

        #endregion
    }
}
