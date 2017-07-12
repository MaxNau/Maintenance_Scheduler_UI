using Maintenance_Scheduler_BAL;
using Maintenance_Scheduler_DAL.DataAccess;
using Maintenance_Scheduler_DAL.DataAccess.DTOs;
using System.ComponentModel;
using System.Linq;

namespace Maintenance_Scheduler_UI.ViewModels
{
    public class JobsAndTriggersViewModel
    {
        public BindingList<TriggerDTO> Triggers { get; set; }

        public JobsAndTriggersViewModel()
        {
            Triggers = new BindingList<TriggerDTO>(MaintenanceSchedulerDb.GetAllTriggers());
        }

        /// <summary>
        /// Removes job from the database 
        /// </summary>
        /// <param name="jobName"></param>
        public void RemoveJob(string jobName)
        {
            MaintanceScheduler.RemoveJob(jobName);
            RemoveJobFromTheDataSource(jobName);
        }

        /// <summary>
        /// Removes job from the databound collection 
        /// </summary>
        /// <param name="jobName"></param>
        private void RemoveJobFromTheDataSource(string jobName)
        {
            var trigger = Triggers.FirstOrDefault(t => t.JobName == jobName);
            Triggers.Remove(trigger);
        }
    }
}
