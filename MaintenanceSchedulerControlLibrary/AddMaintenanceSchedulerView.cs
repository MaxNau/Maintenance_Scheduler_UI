using StringsConstantsAndEnumerations;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Maintenance_Scheduler_UI
{
    public partial class AddMaintenanceSchedulerView : UserControl
    {
        private IAddMaintenanceSchedulerViewModel viewModel;

        public AddMaintenanceSchedulerView()
        {
            InitializeComponent();
            errorProvider.ContainerControl = this;
        }

        public void InitializeViewModel(IAddMaintenanceSchedulerViewModel viewModel)
        {
            this.viewModel = viewModel;
            jobTypesCb.DataSource = viewModel.JobAndTrigger.JobTypes;
            AddBindings();
        }

        public IAddMaintenanceSchedulerViewModel GetViewModel { get { return viewModel; } }

        private void AddBindings()
        {
            jobNameTb.DataBindings.Add("Text", viewModel.JobAndTrigger, "JobName", false, DataSourceUpdateMode.OnPropertyChanged);
            jobMessageTb.DataBindings.Add("Text", viewModel.JobAndTrigger, "Message", false, DataSourceUpdateMode.OnPropertyChanged);
            mailSubjectTb.DataBindings.Add("Text", viewModel.JobAndTrigger, "MailSubject", false, DataSourceUpdateMode.OnPropertyChanged);
            mailBodyRtb.DataBindings.Add("Text", viewModel.JobAndTrigger, "MailBody", false, DataSourceUpdateMode.OnPropertyChanged);
            jobTypesCb.DataBindings.Add("SelectedValue", viewModel.JobAndTrigger, "SelectedJobType", true, DataSourceUpdateMode.OnPropertyChanged);
            triggerNameTb.DataBindings.Add("Text", viewModel.JobAndTrigger, "Name", false, DataSourceUpdateMode.OnPropertyChanged);
            cronExpressionTb.DataBindings.Add("Text", viewModel.JobAndTrigger, "CronExpression", false, DataSourceUpdateMode.OnPropertyChanged);
            mailBody.DataBindings.Add("Visible", viewModel, "ShowJobMailPart", false, DataSourceUpdateMode.OnPropertyChanged);
            mailBodyRtb.DataBindings.Add("Visible", viewModel, "ShowJobMailPart", false, DataSourceUpdateMode.OnPropertyChanged);
            mailSubjectLb.DataBindings.Add("Visible", viewModel, "ShowJobMailPart", false, DataSourceUpdateMode.OnPropertyChanged);
            mailSubjectTb.DataBindings.Add("Visible", viewModel, "ShowJobMailPart", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        // this method will save job details, trigger and will schedule the job 
        private void addTriggerBtn_Click(object sender, EventArgs e)
        {
            var cron = cronExpressionTabControl1.CronExpression;
            if (validate() == true)
            {
                viewModel.ScheduleJobWithCronTrigger();
                MessageBox.Show("Job successfully added");
            }
        }

        #region Validating events
        private void jobNameTb_Validating(object sender, CancelEventArgs e)
        {
            validateJobName();
        }

        private void cronExpressionTb_Validating(object sender, CancelEventArgs e)
        {
            validateCronExpression();
        }

        private void triggerNameTb_Validating(object sender, CancelEventArgs e)
        {
            validateTriggerName();
        }

        private void jobMessageTb_Validating(object sender, CancelEventArgs e)
        {
            validateMessage();
        }
        #endregion

        #region Validation logic
        private bool validate()
        {
            bool vJobName = validateJobName();
            bool vMessage = validateMessage();
            bool vTriggerName = validateTriggerName();
            bool vCronExpression = validateCronExpression();
            return vJobName & vMessage & vTriggerName & vCronExpression;
        }

        private bool validateJobName()
        {
            if (jobNameTb.Text == "")
            {
                errorProvider.SetError(jobNameTb, Strings.FieldIsRequiredMessage);
                return false;
            }
            else if (viewModel.JobNameExists(jobNameTb.Text))
            {
                errorProvider.SetError(jobNameTb, Strings.JobNameAlreadyExists);
                return false;
            }
            else
                errorProvider.SetError(jobNameTb, "");
            return true;
        }

        private bool validateMessage()
        {
            if (jobMessageTb.Text == "")
            {
                errorProvider.SetError(jobMessageTb, Strings.FieldIsRequiredMessage);
                return false;
            }
            else
                errorProvider.SetError(jobMessageTb, "");
            return true;
        }

        private bool validateTriggerName()
        {
            if (triggerNameTb.Text == "")
            {
                errorProvider.SetError(triggerNameTb, Strings.FieldIsRequiredMessage);
                return false;
            }
            else if (viewModel.TriggerNameExists(triggerNameTb.Text))
            {
                errorProvider.SetError(triggerNameTb, Strings.TriggerNameAlreadyExists);
                return false;
            }
            else
                errorProvider.SetError(triggerNameTb, "");
            return true;
        }

        private bool validateCronExpression()
        {
            if (!viewModel.IsValidCronExpression(cronExpressionTb.Text))
            {
                errorProvider.SetError(cronExpressionTb, Strings.MustBeValidCronExpression);
                return false;
            }
            else
                errorProvider.SetError(cronExpressionTb, "");
            return true;
        }
        #endregion

        private void IsMailingJobDetailsShown(bool isShown)
        {
            mailBody.Visible = mailBodyRtb.Visible = mailSubjectLb.Visible =
            mailSubjectTb.Visible = isShown;
        }

        private void jobTypesCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            viewModel.CheckIfShowJobMailPart();
        }
    }

    public interface IAddMaintenanceSchedulerViewModel
    {
        /// <summary>
        /// User controls job and trigger instance
        /// </summary>
        ITriggerViewModel JobAndTrigger { get; set; }

        /// <summary>
        /// Checks if trigger name already exists in database
        /// </summary>
        /// <param name="triggerName"></param>
        /// <returns></returns>
        bool TriggerNameExists(string triggerName);


        /// <summary>
        /// Cheks if job name  already exists in database
        /// </summary>
        /// <param name="jobName"></param>
        /// <returns></returns>
        bool JobNameExists(string jobName);

        /// <summary>
        /// Schedules the job to be executed using assigned cron trigger
        /// </summary>
        /// <param name="jobName"></param>
        /// <param name="jobMessage"></param>
        /// <param name="triggerName"></param>
        /// <param name="cronExpression"></param>
        void ScheduleJobWithCronTrigger();

        /// <summary>
        /// Checks if the passed cron expression is valid
        /// </summary>
        /// <param name="cronExpression"></param>
        /// <returns></returns>
        bool IsValidCronExpression(string cronExpression);

        /// <summary>
        /// Sets weither the job mail part should be visible
        /// </summary>
        bool ShowJobMailPart { get; set; }

        /// <summary>
        /// Checks if the job mail part should be visible
        /// </summary>
        void CheckIfShowJobMailPart();
    }
}
