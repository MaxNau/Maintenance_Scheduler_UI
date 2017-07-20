using Maintenance_Scheduler_BAL;
using Quartz;
using System;
using StringsConstantsAndEnumerations;
using System.Linq;
using System.ComponentModel;

namespace Maintenance_Scheduler_UI.ViewModels
{
    public class AddMaintenanceSchedulerViewModel : IAddMaintenanceSchedulerViewModel, INotifyPropertyChanged
    {
        private bool showJobMailPart;
        private ITriggerViewModel jobAndTrigger;

        public AddMaintenanceSchedulerViewModel()
        {
            JobAndTrigger = new TriggerViewModel();
        }

        public ITriggerViewModel JobAndTrigger
        {
            get { return jobAndTrigger; }
            set { jobAndTrigger = value;
                NotifyPropertyChanged("JobAndTrigger");
            }
        }

        public bool ShowJobMailPart
        {
            get { return showJobMailPart; }
            set
            {
                showJobMailPart = value;
                NotifyPropertyChanged("ShowJobMailPart");
            }
        }

        public bool TriggerNameExists(string triggerName)
        {
            return MaintenanceScheduler.GetAllTriggers().Any(t => t.TriggerName == triggerName);
        }

        public bool JobNameExists(string jobName)
        {
            return MaintenanceScheduler.GetAllTriggers().Any(t => t.JobName == jobName);
        }

        public void ScheduleJobWithCronTrigger()
        {
            CheckAndResetMailSubjectAndBody();
            MaintenanceScheduler.ScheduleJobWithCronTrigger(JobAndTrigger.JobName, JobAndTrigger.Message, JobAndTrigger.SelectedJobType, JobAndTrigger.Name, JobAndTrigger.CronExpression, DateTimeOffset.Now, JobAndTrigger.MailSubject, JobAndTrigger.MailBody);
        }

        public void ScheduleJobWithCronTrigger(string cronExpression, DateTimeOffset startDate)
        {
            CheckAndResetMailSubjectAndBody();
            MaintenanceScheduler.ScheduleJobWithCronTrigger(JobAndTrigger.JobName, JobAndTrigger.Message, JobAndTrigger.SelectedJobType, JobAndTrigger.Name, cronExpression, startDate, JobAndTrigger.MailSubject, JobAndTrigger.MailBody);
        }

        private void CheckAndResetMailSubjectAndBody()
        {
            if (JobAndTrigger.SelectedJobType == Enumerations.MaintenanceJobType.Local)
            {
                JobAndTrigger.MailSubject = null;
                JobAndTrigger.MailBody = null;
            }
        }

        public bool IsValidCronExpression(string cronExpression)
        {
            return CronExpression.IsValidExpression(cronExpression);
        }

        public void CheckIfShowJobMailPart()
        {
            if (JobAndTrigger.SelectedJobType == Enumerations.MaintenanceJobType.Local)
            {
                ShowJobMailPart = false;
            }
            else
            {
                ShowJobMailPart = true;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String info)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(info));
        }
    }
}
