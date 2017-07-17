using System;
using System.Windows.Forms;
using StringsConstantsAndEnumerations;

namespace MaintenanceSchedulerControlLibrary
{
    public partial class CronURIPart : UserControl
    {
        public string GroupBoxText
        {
            get { return groupBox1.Text; }
            set { groupBox1.Text = value; }
        }

        public CronURIPart()
        {
            InitializeComponent();
        }

        private void cronTabControl_DrawItem(object sender, DrawItemEventArgs e)
        {

        }

        private void allRbtn_CheckedChanged(object sender, EventArgs e)
        {
            timeIntervalListbox.Enabled = selectIntervalRbtn.Checked;
            UnCkeck();
        }

        private void UnCkeck()
        {
            extendedCronURI1.dayCb.Enabled = everyRbtn.Checked;
            extendedCronURI1.hoursCb.Enabled = everyRbtn.Checked;
            extendedCronURI1.minutesCb.Enabled = everyRbtn.Checked;
            extendedCronURI1.monthCb.Enabled = everyRbtn.Checked;
            extendedCronURI1.secondsCb.Enabled = everyRbtn.Checked;
            extendedCronURI1.yearCb.Enabled = everyRbtn.Checked;
            extendedCronURI1.timeIntervalCb.Enabled = everyRbtn.Checked;
        }

        private void selectIntervalRbtn_CheckedChanged(object sender, EventArgs e)
        {
            timeIntervalListbox.Enabled = selectIntervalRbtn.Checked;
            UnCkeck();
        }
    }
}
