using System.ComponentModel;
using System.Windows.Forms;

namespace MaintenanceSchedulerControlLibrary
{
    public partial class MailingConfig : UserControl
    {
        public MailingConfig()
        {
            InitializeComponent();
        }

        public string Email
        {
            get { return emailTb.Text; }
            set { emailTb.Text = value; }
        }

        public string SmtpDomain
        {
            get { return smtpDomainTb.Text; }
            set { smtpDomainTb.Text = value; }
        }

        public string SmtpPort
        {
            get { return smtpPortTb.Text; }
            set { smtpPortTb.Text = value; }
        }

        public bool SslEnabled
        {
            get { return enableSslCheckB.Checked; }
            set { enableSslCheckB.Checked = value; }
        }

        public delegate void SaveSettingsButtonClickedDelegate(); 

        [Category("Event")]
        [Description("Fires when the save settings button is clicked.")]
        public event SaveSettingsButtonClickedDelegate SaveSettingsButtonClicked;

        protected virtual void OnSaveSettingsButtonClicked()
        {
            SaveSettingsButtonClicked?.Invoke();
        }

        private void saveSettingsBtn_Click(object sender, System.EventArgs e)
        {
            OnSaveSettingsButtonClicked();
        }
    }
}
