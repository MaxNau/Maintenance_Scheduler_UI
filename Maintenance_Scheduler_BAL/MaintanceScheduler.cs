﻿using Maintenance_Scheduler_BAL.SchedulerJobs;
using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Specialized;
using System.Configuration;

namespace Maintenance_Scheduler_BAL
{
    /// <summary>
    /// Getts the configuration and scheduler and then starts the scheduler
    /// </summary>
    public static class MaintanceScheduler
    {
        private static IScheduler scheduler;
        public static void Start()
        {
            var config = (NameValueCollection)ConfigurationManager.GetSection("quartz");

            ISchedulerFactory schedulerFactory = new StdSchedulerFactory(config);
            scheduler = schedulerFactory.GetScheduler();

            scheduler.Start();
        }

        /// <summary>
        /// Creates job
        /// </summary>
        /// <param name="jobName"> Name of the job </param>
        /// <param name="jobMessage"> Message that will be sent to notify 
        /// all interested users </param>
        /// <returns> Returns created job </returns>
        private static IJobDetail CreateJob(string jobName, string jobMessage)
        {
            IJobDetail job = JobBuilder.Create<MaintenanceJob>().WithIdentity(jobName).Build();
            job.JobDataMap["Message"] = jobMessage;
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
        /// Schedules the created job and it's trigger to be executed
        /// </summary>
        /// <param name="jobName"> Name of the job </param>
        /// <param name="jobMessage"> Message that will be sent to notify
        /// all interested users</param>
        /// <param name="triggerName"> Name of the trigger </param>
        public static void ScheduleJob(string jobName, string jobMessage, string triggerName)
        {
            scheduler.ScheduleJob(CreateJob(jobName, jobMessage), CreateTrigger(triggerName));
        }

        public static void ScheduleDailyJob(string jobName, string jobMessage, string triggerName, DateTime startDate, int daysInterval)
        {
            scheduler.ScheduleJob(CreateJob(jobName, jobMessage), CreateDailyBasedtrigger(triggerName, startDate, daysInterval));
        }

        public static ITrigger CreateDailyBasedtrigger(string triggerName, DateTime startDate, int daysInteval)
        {
            return TriggerBuilder.Create()
                .WithIdentity(triggerName)
                .WithCalendarIntervalSchedule(x => x.WithIntervalInDays(daysInteval))
                .StartAt(startDate)
                .Build();
        }
    }
}
