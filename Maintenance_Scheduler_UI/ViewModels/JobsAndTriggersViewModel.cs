using Maintenance_Scheduler_BAL;
using Maintenance_Scheduler_BAL.SchedulerJobs;
using System.Linq;
using System;
using System.ComponentModel;
using log4net;

namespace Maintenance_Scheduler_UI.ViewModels
{
    public class JobsAndTriggersViewModel : IJobsAndTriggersViewModel, INotifyPropertyChanged
    {
        public event EventHandler UpdateTrigersDgv;

        private ILog log;
        private BindingList<ITriggerViewModel> triggers;

        public JobsAndTriggersViewModel()
        {
            JobAndTriggerToUpdate = new TriggerViewModel();
            StartLogging();
            GetAllTriggers();
        }

        private void StartLogging()
        {
            log4net.Config.XmlConfigurator.Configure();
            log = LogManager.GetLogger(typeof(JobsAndTriggersViewModel));
        }

        public IAddMaintenanceSchedulerViewModel viewModel { get; set; }

        public BindingList<ITriggerViewModel> Triggers
        {
            get { return triggers; }
            set
            {
                triggers = value;
                NotifyPropertyChanged("Triggers");
            }
        }

        public bool ShowJobMailPart { get; set; }
        public ITriggerViewModel JobAndTriggerToUpdate { get; set; }
        public ITriggerViewModel oldJobAndTrigger { get; set; }

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
            try
            {
                var trigger = Triggers.FirstOrDefault(t => t.JobName == jobName);
                Triggers.Remove(trigger);
            }
            catch(Exception ex)
            {
                log.Error(ex.Message, ex);
            }
        }

        /// <summary>
        /// Get all triggers and convert the to the trigger view model
        /// </summary>
        private void GetAllTriggers()
        {
            try
            {
                Triggers = new BindingList<ITriggerViewModel>((
                    from model in MaintenanceScheduler.GetAllTriggers()
                    select new TriggerViewModel(model))
                    .ToList<ITriggerViewModel>());
            }
            catch(Exception ex)
            {
                log.Error(ex.Message, ex);
            }
        }

        public bool UpdateTrigger(string oldTriggerName, string newTriggerName, string cronExpression, DateTimeOffset startDate)
        {
            return MaintenanceScheduler.UpdateTrigger(oldTriggerName, newTriggerName, cronExpression, startDate);
        }

        public void UpdateJob(string jobName, string message)
        {
            MaintenanceScheduler.UpdateLocalJob(jobName, message);
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
    }
}
