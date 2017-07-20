using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace MaintenanceSchedulerControlLibrary
{
    public partial class JobAndTriggerView : UserControl
    {
        public string JobName
        {
            get { return jobNameTb.Text; }
            set { jobNameTb.Text = value; }
        }

        public string JobMessage
        {
            get { return jobMessageTb.Text; }
            set { jobMessageTb.Text = value; }
        }

        public object JobTypes
        {
            get { return jobTypesCb.DataSource; }
            set { jobTypesCb.DataSource = value; }
        }

        public object SelectedJobType
        {
            get { return jobTypesCb.SelectedItem; }
            set { jobTypesCb.SelectedItem = value; }
        }

        public string MailSubject
        {
            get { return mailSubjectTb.Text; }
            set { mailSubjectTb.Text = value; }
        }

        public string MailBody
        {
            get { return mailBodyRtb.Text; }
            set { mailBodyRtb.Text = value; }
        }

        public string TriggerName
        {
            get { return triggerNameTb.Text; }
            set { triggerNameTb.Text = value; }
        }

        public string CronExpression
        {
            get { return combinedCronURI1.CronExpression; }
        }

        public DateTimeOffset TriggerStartDate
        {
            get { return combinedCronURI1.StartDate; }
        }

        public string CronExpressionManual
        {
            get { return cronExpressionTb.Text; }
            set { cronExpressionTb.Text = value; }
        }

        public ErrorProvider ErrorProvider
        {
            get { return errorProvider; }
            set { errorProvider = value; }
        }

        public JobAndTriggerView()
        {
            InitializeComponent();
            EnableDisableJobRelatedControls(false);
            EnableDisableTriggerRelatedControls(true);
            RenameUpdateButton();
        }

        private void jobTypesCb_SelectedValueChanged(object sender, EventArgs e)
        {
            OnSelectedValueChanged();
        }

        public delegate void JobAndTriggerViewRemoveBtnClicked();
        public delegate void JobTypesCb_SelectedValueChanged();
        public delegate void JobAndTriggerViewUpdateJobButtonClicked();
        public delegate void JobAndTriggerViewUpdateTriggerButtonClicked();

        [Category("Event")]
        [Description("Fires when the Remove button is clicked.")]
        public event JobAndTriggerViewRemoveBtnClicked RemoveButtonClicked;

        [Category("Event")]
        [Description("Fires when the Job Type value changes in combobox.")]
        public event JobTypesCb_SelectedValueChanged SelectedValueChanged;

        [Category("Event")]
        [Description("Fires when job is updating and update button clicked.")]
        public event JobAndTriggerViewUpdateJobButtonClicked UpdateJobButtonClicked;

        [Category("Event")]
        [Description("Fires when job is updating and update button clicked.")]
        public event JobAndTriggerViewUpdateTriggerButtonClicked UpdateTriggerButtonClicked;

        protected virtual void OnUpdateJobButtonClicked()
        {
            UpdateJobButtonClicked?.Invoke();
        }

        protected virtual void OnUpdateTriggerButtonClicked()
        {
            UpdateTriggerButtonClicked?.Invoke();
        }

        protected virtual void OnSelectedValueChanged()
        {
            SelectedValueChanged?.Invoke();
        }
        
        private void EnableDisableJobRelatedControls(bool isEnabled)
        {
            jobMessageTb.ReadOnly = isEnabled;
            mailSubjectTb.ReadOnly = isEnabled;
            mailBodyRtb.Enabled = !isEnabled;
            jobTypesCb.Enabled = !isEnabled;
        }

        private void EnableDisableTriggerRelatedControls(bool isEnabled)
        {
            triggerNameTb.ReadOnly = isEnabled;
            combinedCronURI1.Visible = !isEnabled;
            combinedCronURI1.Enabled = !isEnabled;
        }

        private void rbtn_CheckedChanged(object sender, EventArgs e)
        {
            EnableDisableJobRelatedControls(updateTriggerRbtn.Checked);
            EnableDisableTriggerRelatedControls(updateJobRbtn.Checked);
            RenameUpdateButton();
        }

        protected virtual void OnRemoveButtonClicked()
        {
            RemoveButtonClicked?.Invoke();
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            OnRemoveButtonClicked();
        }

        private void RenameUpdateButton()
        {
            if (updateJobRbtn.Checked == true)
                updateButton.Text = "Update job";
            else if (updateTriggerRbtn.Checked == true)
                updateButton.Text = "Update trigger";
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (updateJobRbtn.Checked == true)
                OnUpdateJobButtonClicked();
            else if (updateTriggerRbtn.Checked == true)
                OnUpdateTriggerButtonClicked();
        }
    }
}
