using log4net;
using Maintenance_Scheduler_BAL.Models;
using Maintenance_Scheduler_BAL.SchedulerJobs;
using Quartz;
using Quartz.Impl;
using Quartz.Impl.Matchers;
using StringsConstantsAndEnumerations;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Configuration;
using System.Linq;

namespace Maintenance_Scheduler_BAL
{
    /// <summary>
    /// Getts the configuration and scheduler and then starts the scheduler
    /// </summary>
    public static class MaintenanceScheduler
    {
        private static ILog log;

        private static IScheduler scheduler;

        /// <summary>
        /// Starts the scheduler
        /// </summary>
        public static void Start()
        {
            StartLogging();

            log.Info("Scheduler is starting");

            log.Info("About to request configuration file");

            var config = (NameValueCollection)ConfigurationManager.GetSection("quartz");

            log.Info("Configuration file received");

            ISchedulerFactory schedulerFactory = new StdSchedulerFactory(config);

            log.Info("Scheduler configured");

            log.Info("About to get a scheduler");

            scheduler = schedulerFactory.GetScheduler();

            log.Info("Scheduler successfully initialized");

            scheduler.Start();

            log.Info("Scheduler started");
        }

        private static void StartLogging()
        {
            log4net.Config.XmlConfigurator.Configure();
            log = LogManager.GetLogger(typeof(MaintenanceScheduler));
        }

        /// <summary>
        /// Stops the scheduler
        /// </summary>
        public static void Stop()
        {
            log.Info("Scheduler is about to stop");

            scheduler.Shutdown();

            log.Info("Scheduler stoped");
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
        public static void ScheduleJob(string jobName, string jobMessage, Enumerations.MaintenanceJobType jobType, string triggerName, string jobMailSubject = "", string jobMailBody = "")
        {
            if (jobType == Enumerations.MaintenanceJobType.Local)
                scheduler.ScheduleJob(CreateLocalNotifierJob(jobName, jobMessage), CreateTrigger(triggerName));
            else if (jobType == Enumerations.MaintenanceJobType.Mailing)
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
        public static void ScheduleJobWithCronTrigger(string jobName, string jobMessage, StringsConstantsAndEnumerations.Enumerations.MaintenanceJobType jobType, string triggerName, string cronExpression, DateTimeOffset startDate, string jobMailSubject = "", string jobMailBody = "")
        {
            if (jobType == Enumerations.MaintenanceJobType.Local)
                scheduler.ScheduleJob(CreateLocalNotifierJob(jobName, jobMessage), CreateCronTrigger(triggerName, cronExpression, startDate));
            else if (jobType == Enumerations.MaintenanceJobType.Mailing)
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
        private static ITrigger CreateCronTrigger(string triggerName, string cronExpression, DateTimeOffset startDate)
        {
            log.Info("Creating new trigger");
            try
            {
                return TriggerBuilder.Create()
                    .WithIdentity(triggerName)
                    .WithCronSchedule(cronExpression)
                    .StartAt(startDate)
                    .Build();
            }
            catch (Exception ex)
            {
                log.Info("Failed to create cron trigger");
                log.Error(ex.Message, ex);
                return null;
            }
        }

        public static BindingList<ITrigger> getAllTriggers()
        {
            BindingList<ITrigger> triggers = new BindingList<ITrigger>();
            var allTriggerKeys = scheduler.GetTriggerKeys(GroupMatcher<TriggerKey>.AnyGroup());
            if (allTriggerKeys != null)
            {
                foreach (var triggerKey in allTriggerKeys)
                {
                    ITrigger trigger = scheduler.GetTrigger(triggerKey);
                    triggers.Add(scheduler.GetTrigger(triggerKey));
                }
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
            if (triggerKeys != null)
            {
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
                            MailSubject = scheduler.GetJobDetail(trigger.JobKey).JobDataMap.GetString("MailSubject"),
                            MailBody = scheduler.GetJobDetail(trigger.JobKey).JobDataMap.GetString("MailBody"),
                            CronExpression = ((ICronTrigger)trigger).CronExpressionString
                        });
                    }
                }
            }

            return triggers;
        }

        private static ITrigger GetCronTriggerByName(string triggerName)
        {
            log.Info("Geting all trigger keys");

            var triggerKeys = scheduler.GetTriggerKeys(GroupMatcher<TriggerKey>.AnyGroup());
            if (triggerKeys != null)
            {
                log.Info("Getting old trigger key");

                var oldTriggerKey = triggerKeys.FirstOrDefault(tk => tk.Name == triggerName);
                if (oldTriggerKey != null)
                {
                    log.Info("Old trigger key retrived successfuly... Getting the trigger");
                    return scheduler.GetTrigger(oldTriggerKey);
                }
                else
                {
                    log.Info("Unable to retrive old trigger key");
                    return null;
                }
            }
            else
            {
                log.Info("No trigger keys was found");
                return null;
            }
        }

        public static bool UpdateTrigger(string oldTriggerName, string newTriggerName, string cronExpression, DateTimeOffset startDate)
        {
            ITrigger oldTrigger = GetCronTriggerByName(oldTriggerName);
            if (oldTrigger != null)
            {
                log.Info("Trigger to update successfully found");

                ITrigger newTrigger = CreateCronTrigger(newTriggerName, cronExpression, startDate);

                if (newTrigger != null)
                {
                    log.Info("New trigger successfully created");
                    log.Info("Rescheduling trigger");
                    scheduler.RescheduleJob(oldTrigger.Key, newTrigger);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public static void UpdateLocalJob(string jobName, string message)
        {
            ICronTrigger realtedTrigger = GetCronTriggerForJob(GetAllJobs().FirstOrDefault(jd => jd.Key.Name == jobName).Key);

            IJobDetail newJob = JobBuilder.Create<MaintenanceJob>()
                .WithIdentity(jobName)
                .Build();

            Quartz.Collection.ISet<ITrigger> trigger = new Quartz.Collection.HashSet<ITrigger>();
            try
            {
                trigger.Add(TriggerBuilder.Create()
                .ForJob(newJob)
                .WithIdentity(realtedTrigger.Key.Name)
                .WithCronSchedule(realtedTrigger.CronExpressionString)
                .StartAt(realtedTrigger.StartTimeUtc)
                .Build());
            }
            catch (Exception ex)
            {
                log.Error(ex.Message, ex);
            }

            newJob.JobDataMap["Message"] = message;
            scheduler.ScheduleJob(newJob, trigger, true);
        }

        private static ICollection<IJobDetail> GetAllJobs()
        {
            ICollection<IJobDetail> jobDetails = new List<IJobDetail>();
            IList<string> jobGroups = scheduler.GetJobGroupNames();
            foreach (string group in jobGroups)
            {
                var groupMatcher = GroupMatcher<JobKey>.GroupContains(group);
                var jobKeys = scheduler.GetJobKeys(groupMatcher);

                foreach (JobKey jobKey in jobKeys)
                {
                    jobDetails.Add(scheduler.GetJobDetail(jobKey));
                }
            }

            return jobDetails;
        }

        private static ICronTrigger GetCronTriggerForJob(JobKey jobKey)
        {
            return (ICronTrigger)scheduler.GetTriggersOfJob(jobKey).FirstOrDefault();
        }

        #endregion
    }
}
