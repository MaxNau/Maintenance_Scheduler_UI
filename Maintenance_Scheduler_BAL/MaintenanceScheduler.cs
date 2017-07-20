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
        /// Creates local job
        /// </summary>
        /// <param name="jobName"> Name of the job </param>
        /// <param name="jobMessage"> Message that will be sent to notify 
        /// all interested users </param>
        /// <returns> Returns created job </returns>
        private static IJobDetail CreateLocalNotifierJob(string jobName, string jobMessage)
        {
            log.Info("Creating local job");

            IJobDetail job = JobBuilder.Create<MaintenanceJob>().WithIdentity(jobName).Build();

            log.Info("Local job created successfuly");

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
            log.Info("Creating mailing job");

            IJobDetail job = JobBuilder.Create<MailingJob>().WithIdentity(jobName).Build();

            log.Info("Mailing job created successfuly");

            job.JobDataMap["Message"] = jobMessage;
            job.JobDataMap["MailSubject"] = jobMailSubject;
            job.JobDataMap["MailBody"] = jobMailBody;
            return job;
        }

        /// <summary>
        /// Schedules job using assigned cron trigger
        /// </summary>
        /// <param name="jobName"></param>
        /// <param name="jobMessage"></param>
        /// <param name="triggerName"></param>
        /// <param name="cronExpression"></param>
        public static bool ScheduleJobWithCronTrigger(string jobName, string jobMessage, Enumerations.MaintenanceJobType jobType, string triggerName, string cronExpression, DateTimeOffset startDate, string jobMailSubject = "", string jobMailBody = "")
        {
            if (jobType == Enumerations.MaintenanceJobType.Local)
            {
                log.Info("Prepering to schedule local job...");
                try
                {
                    scheduler.ScheduleJob(CreateLocalNotifierJob(jobName, jobMessage), CreateCronTrigger(triggerName, cronExpression, startDate));
                }
                catch (SchedulerException SchEx)
                {
                    log.Error(SchEx.Message, SchEx);
                }
                log.Info("Local job successfuly scheduled");
                return true;
            }
            else if (jobType == Enumerations.MaintenanceJobType.Mailing)
            {
                log.Info("Prepering to schedule mailing job...");
                try
                {
                    scheduler.ScheduleJob(CreateMailingNotifierJob(jobName, jobMessage, jobMailSubject, jobMailBody), CreateCronTrigger(triggerName, cronExpression, startDate));
                }
                catch (SchedulerException SchEx)
                {
                    log.Error(SchEx.Message, SchEx);
                }
                log.Info("Mailing job successfuly scheduled");
                return true;
            }

            return false;
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

        /// <summary>
        /// Gets all triggers
        /// </summary>
        /// <returns></returns>
        public static ICollection<ITrigger> getAllTriggers()
        {
            log.Info("About to get all triggers...");
            ICollection<ITrigger> triggers = new BindingList<ITrigger>();
            log.Info("Finding trigger keys...");
            var allTriggerKeys = scheduler.GetTriggerKeys(GroupMatcher<TriggerKey>.AnyGroup());
            if (allTriggerKeys != null)
            {
                log.Info("At list one trigger key was found... Getting triggers");
                foreach (var triggerKey in allTriggerKeys)
                {
                    ITrigger trigger = scheduler.GetTrigger(triggerKey);
                    triggers.Add(scheduler.GetTrigger(triggerKey));
                }
                log.Info("Successfuly got all triggers");
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
        /// Gets all triggers converted to trigger model
        /// </summary>
        /// <returns></returns>
        public static ICollection<TriggerModel> GetAllTriggers()
        {
            log.Info("About to get all triggers...");
            ICollection<TriggerModel> triggers = new List<TriggerModel>();
            log.Info("Finding trigger keys...");
            var triggerKeys = scheduler.GetTriggerKeys(GroupMatcher<TriggerKey>.AnyGroup());
            if (triggerKeys != null)
            {
                log.Info("At list one trigger key was found... Getting triggers");
                foreach (TriggerKey key in triggerKeys)
                {
                    ITrigger trigger = scheduler.GetTrigger(key);

                    if (trigger is ICronTrigger)
                    {
                        triggers.Add(new TriggerModel()
                        {
                            JobName = trigger.JobKey.Name,
                            TriggerName = trigger.Key.Name,
                            TriggerType = trigger.GetType().Name,
                            StartTimeDate = trigger.StartTimeUtc,
                            EndTimeDate = trigger.EndTimeUtc,
                            PreviousFireTimeDate = trigger.GetPreviousFireTimeUtc(),
                            NextFireTimeDate = trigger.GetNextFireTimeUtc(),
                            Message = scheduler.GetJobDetail(trigger.JobKey).JobDataMap.GetString("Message"),
                            MailSubject = scheduler.GetJobDetail(trigger.JobKey).JobDataMap.GetString("MailSubject"),
                            MailBody = scheduler.GetJobDetail(trigger.JobKey).JobDataMap.GetString("MailBody"),
                            JobType = scheduler.GetJobDetail(trigger.JobKey).JobType.Name,
                            CronExpression = ((ICronTrigger)trigger).CronExpressionString
                        });
                    }
                }
                log.Info("Successfuly got all triggers");
            }

            return triggers;
        }

        /// <summary>
        /// Gets trigger by its name
        /// </summary>
        /// <param name="triggerName"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Updates the trigger
        /// </summary>
        /// <param name="oldTriggerName"></param>
        /// <param name="newTriggerName"></param>
        /// <param name="cronExpression"></param>
        /// <param name="startDate"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Updates job
        /// </summary>
        /// <param name="jobName"></param>
        /// <param name="message"></param>
        public static void UpdateJob(string jobName, string message, Enumerations.MaintenanceJobType jobType, string jobMailSubject = "", string jobMailBody = "")
        {
            log.Info("About to update local job");
            log.Info("Getting related trigger");
            ICronTrigger realtedTrigger = GetCronTriggerForJob(GetAllJobs().FirstOrDefault(jd => jd.Key.Name == jobName).Key);
            log.Info("Trigger retrived successfuly");
            log.Info("Creating new job instance");

            IJobDetail newJob = CreateJobBasedOnItsType(jobName, message, jobType, jobMailSubject, jobMailBody);

            log.Info("Job instance created");
            Quartz.Collection.ISet<ITrigger> trigger = new Quartz.Collection.HashSet<ITrigger>();
            try
            {
                log.Info("Creating trigger for a newJob");
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

            log.Info("Replacing job and trigger");
            try
            {
                scheduler.ScheduleJob(newJob, trigger, true);
            }
            catch(SchedulerException SchEx)
            {
                log.Error(SchEx.Message, SchEx);
            }
            log.Info("Job and trigger successfuly replaced");
        }

        private static IJobDetail CreateJobBasedOnItsType(string jobName, string jobMessage, Enumerations.MaintenanceJobType jobType, string jobMailSubject = "", string jobMailBody = "")
        {
            log.Info("Checking job type");
            if (jobType == Enumerations.MaintenanceJobType.Local)
            {
                return CreateLocalNotifierJob(jobName, jobMessage);
            }
            else if (jobType == Enumerations.MaintenanceJobType.Mailing)
            {
                return CreateMailingNotifierJob(jobName, jobMessage, jobMailSubject, jobMailBody);
            }
            else
            {
                return null;
            }
            
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
