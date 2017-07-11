using Maintenance_Scheduler_BAL;
using Maintenance_Scheduler_DAL.DataAccess;

namespace Maintenance_Scheduler_UI.ViewModels
{
    public class AddMaintenanceSchedulerViewModel
    {
        public bool TriggerNameExists(string triggerName)
        {
            return MaintenanceSchedulerDb.TriggerNameExists(triggerName);
        }

        public bool JobNameExists(string jobName)
        {
            return MaintenanceSchedulerDb.JobNameExists(jobName);
        }

        public void ScheduleJobWithCronTrigger(string jobName, string jobMessage, string triggerName, string cronExpression)
        {
            MaintanceScheduler.ScheduleJobWithCronTrigger(jobName, jobMessage, triggerName, cronExpression);
        }
    }
}
