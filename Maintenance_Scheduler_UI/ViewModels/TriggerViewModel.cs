using Maintenance_Scheduler_BAL.Exceptions;
using Maintenance_Scheduler_BAL.Models;
using StringsConstantsAndEnumerations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Maintenance_Scheduler_UI.ViewModels
{
    public class TriggerViewModel : ITriggerViewModel, INotifyPropertyChanged
    {
        private string jobName;
        private string name;
        private string message;
        private string triggerType;
        private string mailSubject;
        private string mailBody;
        private string cronExpression;
        private List<Enumerations.MaintenanceJobType> jobTypes;
        private Enumerations.MaintenanceJobType selectedJobType;
        private DateTimeOffset? previousFireTimeDate;
        private DateTimeOffset? nextFireTimeDate;
        private DateTimeOffset startTimeDate;
        private DateTimeOffset? endTimeDate;

        public TriggerViewModel() {
            JobTypes = GetJobTypes();
        }

        public TriggerViewModel(TriggerModel model)
        {
            Name = model.TriggerName;
            JobName = model.JobName;
            Message = model.Message;
            TriggerType = model.TriggerType;
            PreviousFireTimeDate = model.PreviousFireTimeDate;
            NextFireTimeDate = model.NextFireTimeDate;
            StartTimeDate = model.StartTimeDate;
            EndTimeDate = model.EndTimeDate;
            CronExpression = model.CronExpression;
            MailSubject = model.MailSubject;
            MailBody = model.MailBody;
            SelectedJobType = ConvertJobClassNameStringToEnum(model.JobType);
        }

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                NotifyPropertyChanged("Name");
            }
        }

        public string JobName
        {
            get { return jobName; }
            set
            {
                jobName = value;
                NotifyPropertyChanged("JobName");
            }
        }

        public string Message
        {
            get { return message; }
            set
            {
                message = value;
                NotifyPropertyChanged("Message");
            }
        }

        public Enumerations.MaintenanceJobType SelectedJobType
        {
            get { return selectedJobType; }
            set
            {
                selectedJobType = value;
                NotifyPropertyChanged("SelectedJobType");
            }
        }

        public List<Enumerations.MaintenanceJobType> JobTypes
        {
            get { return jobTypes; }
            set
            {
                jobTypes = value;
                NotifyPropertyChanged("JobTypes");
            }
        }

        public string TriggerType
        {
            get { return triggerType; }
            set
            {
                triggerType = value;
                NotifyPropertyChanged("TriggerType");
            }
        }

        public string MailSubject
        {
            get { return mailSubject; }
            set
            {
                mailSubject = value;
                NotifyPropertyChanged("MailSubject");
            }
        }

        public string MailBody
        {
            get { return mailBody; }
            set
            {
                mailBody = value;
                NotifyPropertyChanged("MailBody");
            }
        }

        public string CronExpression
        {
            get { return cronExpression; }
            set
            {
                cronExpression = value;
                NotifyPropertyChanged("CronExpression");
            }
        }

        public DateTimeOffset? PreviousFireTimeDate
        {
            get { return previousFireTimeDate; }
            set
            {
                previousFireTimeDate = value;
                NotifyPropertyChanged("PreviousFireTimeDate");
            }
        }

        public DateTimeOffset? NextFireTimeDate
        {
            get { return nextFireTimeDate; }
            set
            {
                nextFireTimeDate = value;
                NotifyPropertyChanged("NextFireTimeDate");
            }
        }

        public DateTimeOffset StartTimeDate
        {
            get { return startTimeDate; }
            set
            {
                startTimeDate = value;
                NotifyPropertyChanged("StartTimeDate");
            }
        }

        public DateTimeOffset? EndTimeDate
        {
            get { return endTimeDate; }
            set
            {
                endTimeDate = value;
                NotifyPropertyChanged("EndTimeDate");
            }
        }

        /// <summary>
        /// Gets the job types from the MaintenaceJobType enum and stores them into list
        /// </summary>
        /// <returns></returns>
        private List<Enumerations.MaintenanceJobType> GetJobTypes()
        {
            return ((Enum.GetValues(typeof(Enumerations.MaintenanceJobType))) as Enumerations.MaintenanceJobType[]).ToList();
        }

        private Enumerations.MaintenanceJobType ConvertJobClassNameStringToEnum(string jobClassName)
        {
            if (jobClassName == "MaintenanceJob")
                return Enumerations.MaintenanceJobType.Local;
            else if (jobClassName == "MailingJob")
                return Enumerations.MaintenanceJobType.Mailing;
            else
                throw new MaintenanceTypeNotFoundException(String.Format("The type {0} is not relate to any of MaintenanceJobTypes", jobClassName));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(String info)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(info));
        }
    }
}
