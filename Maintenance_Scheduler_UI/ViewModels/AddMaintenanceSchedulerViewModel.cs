using Maintenance_Scheduler_BAL;
using Maintenance_Scheduler_DAL.DataAccess;

namespace Maintenance_Scheduler_UI.ViewModels
{
    public class AddMaintenanceSchedulerViewModel
    {
        /// <summary>
        /// Checks if trigger name already exists in database
        /// </summary>
        /// <param name="triggerName"></param>
        /// <returns></returns>
        public bool TriggerNameExists(string triggerName)
        {
            return MaintenanceSchedulerDb.TriggerNameExists(triggerName);
        }

        /// <summary>
        /// Cheks if job name  already exists in database
        /// </summary>
        /// <param name="jobName"></param>
        /// <returns></returns>
        public bool JobNameExists(string jobName)
        {
            return MaintenanceSchedulerDb.JobNameExists(jobName);
        }

        /// <summary>
        /// Schedules the job to be executed using assigned cron trigger
        /// </summary>
        /// <param name="jobName"></param>
        /// <param name="jobMessage"></param>
        /// <param name="triggerName"></param>
        /// <param name="cronExpression"></param>
        public void ScheduleJobWithCronTrigger(string jobName, string jobMessage, string triggerName, string cronExpression)
        {
            MaintanceScheduler.ScheduleJobWithCronTrigger(jobName, jobMessage, triggerName, cronExpression);
        }
    }
}
