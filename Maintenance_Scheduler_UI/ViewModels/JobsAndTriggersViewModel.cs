using Maintenance_Scheduler_BAL;
using Maintenance_Scheduler_BAL.SchedulerJobs;
using System.Linq;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace Maintenance_Scheduler_UI.ViewModels
{
    public class JobsAndTriggersViewModel : IJobsAndTriggersViewModel, INotifyPropertyChanged
    {
        private ObservableCollection<ITriggerViewModel> triggers;

        public event EventHandler UpdateTrigersDgv;

        public IAddMaintenanceSchedulerViewModel viewModel { get; set; }

        public ObservableCollection<ITriggerViewModel> Triggers
        {
            get { return triggers; }
            set
            {
                triggers = value;
                NotifyPropertyChanged("Triggers");
            }
        }

        public ITriggerViewModel JobAndTrigger { get; set; }
        public bool ShowJobMailPart { get; set; }

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

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(String info)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(info));
        }

        public bool TriggerNameExists(string triggerName)
        {
            throw new NotImplementedException();
        }

        public bool JobNameExists(string jobName)
        {
            throw new NotImplementedException();
        }

        public void ScheduleJobWithCronTrigger()
        {
            throw new NotImplementedException();
        }

        public bool IsValidCronExpression(string cronExpression)
        {
            throw new NotImplementedException();
        }

        public void CheckIfShowJobMailPart()
        {
            throw new NotImplementedException();
        }
    }
}
