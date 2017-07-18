using StringsConstantsAndEnumerations;
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
        }

        private void updateJobeAndTriggerBtn_Click(object sender, EventArgs e)
        {
            OnButtonClicked();
        }

        private void jobTypesCb_SelectedValueChanged(object sender, EventArgs e)
        {
            OnSelectedValueChanged();
        }

        public delegate void JobAndTriggerViewBtnClicked();
        public delegate void JobTypesCb_SelectedValueChanged();

        [Category("Action")]
        [Description("Fires when the JobAndTriggerView button is clicked.")]
        public event JobAndTriggerViewBtnClicked ButtonClicked;

        [Category("Event")]
        [Description("Fires when the Job Type value changes in combobox.")]
        public event JobTypesCb_SelectedValueChanged SelectedValueChanged;

        protected virtual void OnButtonClicked()
        {
            ButtonClicked?.Invoke();
        }

        protected virtual void OnSelectedValueChanged()
        {
            SelectedValueChanged?.Invoke();
        }
    }
}
