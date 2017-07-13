using Maintenance_Scheduler_BAL;
using Maintenance_Scheduler_BAL.SchedulerJobs;
using System.Linq;
using System;
using System.Collections.ObjectModel;

namespace Maintenance_Scheduler_UI.ViewModels
{
    public class JobsAndTriggersViewModel : IJobsAndTriggersViewModel
    {
        public event EventHandler UpdateTrigersDgv;

        public ObservableCollection<ITriggerViewModel> Triggers { get; set; }

        public JobsAndTriggersViewModel()
        {
            GetAllTriggers();
        }

        /// <summary>
        /// Removes job from the database 
        /// </summary>
        /// <param name="jobName"></param>
        public void RemoveJob(string jobName)
        {
            MaintenanceScheduler.RemoveJob(jobName);
            RemoveJobFromTheDataSource(jobName);
        }

        /// <summary>
        /// Removes job from the databound collection 
        /// </summary>
        /// <param name="jobName"></param>
        public void RemoveJobFromTheDataSource(string jobName)
        {
            var trigger = Triggers.FirstOrDefault(t => t.JobName == jobName);
            Triggers.Remove(trigger);
        }

        /// <summary>
        /// Get all triggers and convert the to the trigger view model
        /// </summary>
        private void GetAllTriggers()
        {
            Triggers = new ObservableCollection<ITriggerViewModel>((
                from model in MaintenanceScheduler.GetAllTriggers()
                select new TriggerViewModel(model))
                .ToList<ITriggerViewModel>());
        }

        public void SubscribeToJobExecution()
        {
            MaintenanceJob.JobDone += OnJobDone;
        }

        private void OnJobDone(object sender, EventArgs e)
        {
            GetAllTriggers();
            UpdateTrigersDgv?.Invoke(this, null);
        }

        public void UnsuscribeFromJobExecution()
        {
            MaintenanceJob.JobDone -= OnJobDone;
        }
    }
}
