using System;
using System.ComponentModel;
using System.Windows.Forms;
using Quartz;
using Maintenance_Scheduler_UI.ViewModels;

namespace Maintenance_Scheduler_UI
{
    public partial class AddMaintenanceScheduleView : UserControl
    {
        private const string requiredMessage = "This field is required";
        private AddMaintenanceSchedulerViewModel viewModel;

        public AddMaintenanceScheduleView()
        {
            InitializeComponent();
            errorProvider.ContainerControl = this;
            viewModel = new AddMaintenanceSchedulerViewModel();
            jobTypesCb.DataSource = viewModel.JobTypes;

        }

        // this method will save job details, trigger and will schedule the job 
        private void addTriggerBtn_Click(object sender, EventArgs e)
        {
            if (validate() == true)
            {
                if (viewModel.SelectedJobType == Maintenance_Scheduler_BAL.SchedulerJobs.MaintenanceJobType.Local)
                    viewModel.ScheduleJobWithCronTrigger(
                        jobNameTb.Text,
                        jobMessageTb.Text,
                        viewModel.ConvertStringToJobTypeE(jobTypesCb.SelectedValue.ToString()),
                        triggerNameTb.Text,
                        cronExpressionTb.Text);
                else if (viewModel.SelectedJobType == Maintenance_Scheduler_BAL.SchedulerJobs.MaintenanceJobType.Mailing)
                    viewModel.ScheduleJobWithCronTrigger(
                        jobNameTb.Text,
                        jobMessageTb.Text,
                        viewModel.ConvertStringToJobTypeE(jobTypesCb.SelectedValue.ToString()),
                        triggerNameTb.Text,
                        cronExpressionTb.Text,
                        mailSubjectTb.Text,
                        mailBodyRtb.Text);
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
                errorProvider.SetError(jobNameTb, requiredMessage);
                return false;
            }
            else if (viewModel.JobNameExists(jobNameTb.Text))
            {
                errorProvider.SetError(triggerNameTb, "Job name already exists in the  database");
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
                errorProvider.SetError(jobMessageTb, requiredMessage);
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
                errorProvider.SetError(triggerNameTb, requiredMessage);
                return false;
            }
            else if (viewModel.TriggerNameExists(triggerNameTb.Text))
            {
                errorProvider.SetError(triggerNameTb, "Trigger name already exists in the  database");
                return false;
            }
            else
                errorProvider.SetError(triggerNameTb, "");
            return true;
        }

        private bool validateCronExpression()
        {
            if (!CronExpression.IsValidExpression(cronExpressionTb.Text))
            {
                errorProvider.SetError(cronExpressionTb, "Must be a valid cron expression");
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
            if (viewModel.SelectedJobType == Maintenance_Scheduler_BAL.SchedulerJobs.MaintenanceJobType.Local)
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
}
