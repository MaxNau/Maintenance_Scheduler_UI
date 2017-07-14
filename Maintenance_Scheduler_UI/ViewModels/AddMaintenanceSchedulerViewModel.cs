using Maintenance_Scheduler_BAL;
using Quartz;
using System;
using StringsConstantsAndEnumerations;
using System.Linq;

namespace Maintenance_Scheduler_UI.ViewModels
{
    public class AddMaintenanceSchedulerViewModel : IAddMaintenanceSchedulerViewModel
    {
        public AddMaintenanceSchedulerViewModel()
        {
            JobAndTrigger = new TriggerViewModel();
        }

        public Enumerations.MaintenanceJobType SelectedJobType { get; set; }
        public ITriggerViewModel JobAndTrigger { get; set; }

        /// <summary>
        /// Checks if trigger name already exists in database
        /// </summary>
        /// <param name="triggerName"></param>
        /// <returns></returns>
        public bool TriggerNameExists(string triggerName)
        {
            return MaintenanceScheduler.GetAllTriggers().Any(t => t.Name == triggerName);
            //return MaintenanceSchedulerDb.TriggerNameExists(triggerName);
        }

        /// <summary>
        /// Cheks if job name  already exists in database
        /// </summary>
        /// <param name="jobName"></param>
        /// <returns></returns>
        public bool JobNameExists(string jobName)
        {
            return MaintenanceScheduler.GetAllTriggers().Any(t => t.JobName == jobName);
            //return MaintenanceSchedulerDb.JobNameExists(jobName);
        }

        /// <summary>
        /// Schedules the job to be executed using assigned cron trigger
        /// </summary>
        /// <param name="jobName"></param>
        /// <param name="jobMessage"></param>
        /// <param name="triggerName"></param>
        /// <param name="cronExpression"></param>
        public void ScheduleJobWithCronTrigger(string jobName, string jobMessage, StringsConstantsAndEnumerations.Enumerations.MaintenanceJobType jobType, string triggerName, string cronExpression, string jobMailSubject = "", string jobMailBody = "")
        {
            MaintenanceScheduler.ScheduleJobWithCronTrigger(jobName, jobMessage, jobType, triggerName, cronExpression, jobMailSubject, jobMailBody);
        }

        public Enumerations.MaintenanceJobType ConvertStringToJobTypeE(string jobType)
        {
            Enumerations.MaintenanceJobType jobT;
            Enum.TryParse(jobType, out jobT);
            return jobT;
        }

        public bool IsValidCronExpression(string cronExpression)
        {
            return CronExpression.IsValidExpression(cronExpression);
        }
    }
}
