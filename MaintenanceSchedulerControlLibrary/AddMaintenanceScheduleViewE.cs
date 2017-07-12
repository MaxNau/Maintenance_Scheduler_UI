using StringsConstantsAndEnumerations;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using static StringsConstantsAndEnumerations.Enumerations;

namespace Maintenance_Scheduler_UI
{
    public partial class AddMaintenanceScheduleViewE : UserControl
    {
        private IAddMaintenanceSchedulerViewModel viewModel;

        public AddMaintenanceScheduleViewE()
        {
            InitializeComponent();
            errorProvider.ContainerControl = this;
        }

        public void InitializeViewModel(IAddMaintenanceSchedulerViewModel viewModel)
        {
            this.viewModel = viewModel;
            jobTypesCb.DataSource = viewModel.JobTypes;
        }

        // this method will save job details, trigger and will schedule the job 
        private void addTriggerBtn_Click(object sender, EventArgs e)
        {
            if (validate() == true)
            {
                if (viewModel.SelectedJobType == StringsConstantsAndEnumerations.Enumerations.MaintenanceJobType.Local)
                {
                    viewModel.ScheduleJobWithCronTrigger(
                        jobNameTb.Text,
                        jobMessageTb.Text,
                        viewModel.ConvertStringToJobTypeE(jobTypesCb.SelectedValue.ToString()),
                        triggerNameTb.Text,
                        cronExpressionTb.Text);
                }
                else if (viewModel.SelectedJobType == StringsConstantsAndEnumerations.Enumerations.MaintenanceJobType.Mailing)
                {
                    viewModel.ScheduleJobWithCronTrigger(
                        jobNameTb.Text,
                        jobMessageTb.Text,
                        viewModel.ConvertStringToJobTypeE(jobTypesCb.SelectedValue.ToString()),
                        triggerNameTb.Text,
                        cronExpressionTb.Text,
                        mailSubjectTb.Text,
                        mailBodyRtb.Text);
                }
                else
                {
                    MessageBox.Show("Can't add job");
                    return;
                }
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

        private void jobTypesCb_SelectedValueChanged(object sender, EventArgs e)
        {
            viewModel.SelectedJobType = viewModel.ConvertStringToJobTypeE((sender as ComboBox).SelectedValue.ToString());
            if (viewModel.SelectedJobType == MaintenanceJobType.Local)
            {
                IsMailingJobDetailsShown(false);
            }
            else
            {
                IsMailingJobDetailsShown(true);
            }
        }

        private void IsMailingJobDetailsShown(bool isShown)
        {
            mailBody.Visible = mailBodyRtb.Visible = mailSubjectLb.Visible =
            mailSubjectTb.Visible = isShown;
        }
    }

    public interface IAddMaintenanceSchedulerViewModel
    {
        /// <summary>
        /// Currently selected job type in the ComboBox
        /// </summary>
        MaintenanceJobType SelectedJobType { get; set; }

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
        void ScheduleJobWithCronTrigger(string jobName, string jobMessage, MaintenanceJobType jobType, string triggerName, string cronExpression, string jobMailSubject = "", string jobMailBody = "");

        /// <summary>
        /// Array of Job Types
        /// </summary>
        Array JobTypes { get; set; }

        /// <summary>
        /// Populates the Array of the job types from the Job Type enum
        /// </summary>
        void GetJobTypes();

        /// <summary>
        /// Converts string into the coresponing enum Job Type 
        /// </summary>
        /// <param name="jobType"></param>
        /// <returns></returns>
        StringsConstantsAndEnumerations.Enumerations.MaintenanceJobType ConvertStringToJobTypeE(string jobType);

        /// <summary>
        /// Checks if the passed cron expression is valid
        /// </summary>
        /// <param name="cronExpression"></param>
        /// <returns></returns>
        bool IsValidCronExpression(string cronExpression);

        bool CheckJobType();
    }
}
