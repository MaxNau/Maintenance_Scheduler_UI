using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maintenance_Scheduler_UI.TestForms
{
    public partial class MailingSettingsTestForm : Form
    {
        public MailingSettingsTestForm()
        {
            InitializeComponent();

            mailingConfig1.SaveSettingsButtonClicked += MailingConfig1_SaveSettingsButtonClicked;

            mailingConfig1.Email = Properties.Settings.Default.Email;
            mailingConfig1.SmtpDomain = Properties.Settings.Default.SmtpDomain;
            mailingConfig1.SmtpPort = Properties.Settings.Default.SmtpPort.ToString();
            mailingConfig1.SslEnabled = Properties.Settings.Default.SslEnabled;
        }

        private void MailingConfig1_SaveSettingsButtonClicked()
        {
            Properties.Settings.Default["Email"] = mailingConfig1.Email;
            Properties.Settings.Default["SmtpDomain"] = mailingConfig1.SmtpDomain;
            Properties.Settings.Default["SmtpPort"] = short.Parse(mailingConfig1.SmtpPort);
            Properties.Settings.Default["SslEnabled"] = mailingConfig1.SslEnabled;
        }
    }
}
