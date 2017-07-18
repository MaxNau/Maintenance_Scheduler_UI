using StringsConstantsAndEnumerations;
using System;
using System.Linq;
using System.Windows.Forms;

namespace MaintenanceSchedulerControlLibrary
{
    public partial class CombinedCronURI : UserControl
    {
        private CronExp cronExp;

        public DateTimeOffset StartDate
        {
            get { return cronExp.StartDate; }
        }

        public string CronExpression
        {
            get { return cronExp.CronExpression; }
        }

        public CombinedCronURI()
        {
            InitializeComponent();
            SubscribeToEvents();
            cronExp = new CronExp();
            EnableDisableExtendedCronURI();
            extendedCronURI_1.timeIntervalCb.DataSource = ((Enum.GetValues(typeof(Enumerations.TimeInterval))) as Enumerations.TimeInterval[]).ToList().GetRange(0, 3);
            extendedCronURIEveryDMYAtSpecTime1.timeIntervalCb.DataSource = ((Enum.GetValues(typeof(Enumerations.TimeInterval))) as Enumerations.TimeInterval[]).ToList().GetRange(3, 4);
        }

        private void EnableDisableExtendedCronURI()
        {
            extendedCronURI_1.dayCb.Enabled = everySMHRbtn.Checked;
            extendedCronURI_1.hoursCb.Enabled = everySMHRbtn.Checked;
            extendedCronURI_1.minutesCb.Enabled = everySMHRbtn.Checked;
            extendedCronURI_1.monthCb.Enabled = everySMHRbtn.Checked;
            extendedCronURI_1.secondsCb.Enabled = everySMHRbtn.Checked;
            extendedCronURI_1.timeIntervalCb.Enabled = everySMHRbtn.Checked;
            extendedCronURI_1.timeIntervalValueCb.Enabled = everySMHRbtn.Checked;
            extendedCronURI_1.yearCb.Enabled = everySMHRbtn.Checked;
            extendedCronURI_1.Visible = everySMHRbtn.Checked;
            extendedCronURIEveryDMYAtSpecTime1.hoursCb.Enabled = specificTimeRbtn.Checked;
            extendedCronURIEveryDMYAtSpecTime1.minutesCb.Enabled = specificTimeRbtn.Checked;
            extendedCronURIEveryDMYAtSpecTime1.secondsCb.Enabled = specificTimeRbtn.Checked;
            extendedCronURIEveryDMYAtSpecTime1.timeIntervalCb.Enabled = specificTimeRbtn.Checked;
            extendedCronURIEveryDMYAtSpecTime1.timeIntervalValueCb.Enabled = specificTimeRbtn.Checked;
            extendedCronURIEveryDMYAtSpecTime1.Visible = specificTimeRbtn.Checked;
        }

        private void SubscribeToEvents()
        {
            extendedCronURI_1.dayCb.SelectedIndexChanged += extendedCronURI_1_SelectedIndexChanged;
            extendedCronURI_1.hoursCb.SelectedIndexChanged += extendedCronURI_1_SelectedIndexChanged;
            extendedCronURI_1.minutesCb.SelectedIndexChanged += extendedCronURI_1_SelectedIndexChanged;
            extendedCronURI_1.monthCb.SelectedIndexChanged += extendedCronURI_1_SelectedIndexChanged;
            extendedCronURI_1.secondsCb.SelectedIndexChanged += extendedCronURI_1_SelectedIndexChanged;
            extendedCronURI_1.timeIntervalCb.SelectedIndexChanged += extendedCronURI_1_SelectedIndexChanged;
            extendedCronURI_1.timeIntervalValueCb.SelectedIndexChanged += extendedCronURI_1_SelectedIndexChanged;
            extendedCronURI_1.yearCb.SelectedIndexChanged += extendedCronURI_1_SelectedIndexChanged;

            extendedCronURIEveryDMYAtSpecTime1.hoursCb.SelectedIndexChanged += extendedCronURI_2_SelectedIndexChanged;
            extendedCronURIEveryDMYAtSpecTime1.minutesCb.SelectedIndexChanged += extendedCronURI_2_SelectedIndexChanged;
            extendedCronURIEveryDMYAtSpecTime1.secondsCb.SelectedIndexChanged += extendedCronURI_2_SelectedIndexChanged;
            extendedCronURIEveryDMYAtSpecTime1.timeIntervalCb.SelectedIndexChanged += extendedCronURI_2_SelectedIndexChanged;
            extendedCronURIEveryDMYAtSpecTime1.timeIntervalValueCb.SelectedIndexChanged += extendedCronURI_2_SelectedIndexChanged;
        }

        private void extendedCronURI_2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (specificTimeRbtn.Checked == true)
            {
                var selectedIntervalValue = extendedCronURIEveryDMYAtSpecTime1.timeIntervalValueCb.SelectedItem;
                if (selectedIntervalValue != null)
                {
                    if ((Enumerations.TimeInterval)extendedCronURIEveryDMYAtSpecTime1.timeIntervalCb.SelectedItem == Enumerations.TimeInterval.Day_of_the_month)
                    {
                        cronExp.Seconds = extendedCronURIEveryDMYAtSpecTime1.secondsCb.SelectedItem.ToString();
                        cronExp.Minutes = extendedCronURIEveryDMYAtSpecTime1.minutesCb.SelectedItem.ToString();
                        cronExp.Hours = extendedCronURIEveryDMYAtSpecTime1.hoursCb.SelectedItem.ToString();
                        cronExp.DayOfMonth = String.Format("1/{0}", extendedCronURIEveryDMYAtSpecTime1.timeIntervalValueCb.SelectedItem);
                        cronExp.DayOfWeek = "?";
                        cronExp.Month = "*";
                        cronExp.Year = "*";
                    }
                    else if ((Enumerations.TimeInterval)extendedCronURIEveryDMYAtSpecTime1.timeIntervalCb.SelectedItem == Enumerations.TimeInterval.Day_of_the_week)
                    {
                        cronExp.Seconds = extendedCronURIEveryDMYAtSpecTime1.secondsCb.SelectedItem.ToString();
                        cronExp.Minutes = extendedCronURIEveryDMYAtSpecTime1.minutesCb.SelectedItem.ToString();
                        cronExp.Hours = extendedCronURIEveryDMYAtSpecTime1.hoursCb.SelectedItem.ToString();
                        cronExp.DayOfMonth = "?";
                        cronExp.Month = "*";
                        cronExp.DayOfWeek = extendedCronURIEveryDMYAtSpecTime1.timeIntervalValueCb.SelectedItem.ToString();
                        cronExp.Year = "*";
                    }
                    else if ((Enumerations.TimeInterval)extendedCronURI_1.timeIntervalCb.SelectedItem == Enumerations.TimeInterval.Month)
                    {
                        cronExp.Seconds = extendedCronURIEveryDMYAtSpecTime1.secondsCb.SelectedItem.ToString();
                        cronExp.Minutes = extendedCronURIEveryDMYAtSpecTime1.minutesCb.SelectedItem.ToString();
                        cronExp.Hours = extendedCronURIEveryDMYAtSpecTime1.hoursCb.SelectedItem.ToString();
                        cronExp.DayOfMonth = "?";
                        cronExp.Month = String.Format("1/{0}", extendedCronURIEveryDMYAtSpecTime1.timeIntervalValueCb.SelectedItem.ToString());
                        cronExp.DayOfWeek = "*";
                        cronExp.Year = "*";
                    }
                }
                else
                {
                    cronExp.SetCronExpression();
                }
            }
        }

        private void extendedCronURI_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (everySMHRbtn.Checked == true)
            {
                if ((Enumerations.TimeInterval)extendedCronURI_1.timeIntervalCb.SelectedItem == Enumerations.TimeInterval.Second)
                {
                    cronExp.Seconds = String.Format("0/{0}", extendedCronURI_1.timeIntervalValueCb.SelectedItem);
                    cronExp.Minutes = "*";
                    cronExp.Hours = "*";
                    cronExp.DayOfMonth = "1/1";
                    cronExp.DayOfWeek = "?";
                    cronExp.Month = "*";
                    cronExp.Year = "*";
                }
                else if ((Enumerations.TimeInterval)extendedCronURI_1.timeIntervalCb.SelectedItem == Enumerations.TimeInterval.Minute)
                {
                    cronExp.Seconds = "0";
                    cronExp.Minutes = String.Format("0/{0}", extendedCronURI_1.timeIntervalValueCb.SelectedItem);
                    cronExp.Hours = "*";
                    cronExp.DayOfMonth = "1/1";
                    cronExp.DayOfWeek = "?";
                    cronExp.Month = "*";
                    cronExp.Year = "*";
                }
                else if ((Enumerations.TimeInterval)extendedCronURI_1.timeIntervalCb.SelectedItem == Enumerations.TimeInterval.Hour)
                {
                    cronExp.Seconds = "0";
                    cronExp.Minutes = "0";
                    cronExp.Hours = String.Format("0/{0}", extendedCronURI_1.timeIntervalValueCb.SelectedItem);
                    cronExp.DayOfMonth = "1/1";
                    cronExp.DayOfWeek = "?";
                    cronExp.Month = "*";
                    cronExp.Year = "*";
                }
                SetStartDate();
            }
            else
            {
                cronExp.SetCronExpression();
            }
        }

        private void SetStartDate()
        {
            DateTime startDate = new DateTime((int)extendedCronURI_1.yearCb.SelectedItem,
                (int)extendedCronURI_1.monthCb.SelectedItem, (int)extendedCronURI_1.dayCb.SelectedItem,
                (int)extendedCronURI_1.hoursCb.SelectedItem, (int)extendedCronURI_1.minutesCb.SelectedItem,
                (int)extendedCronURI_1.secondsCb.SelectedItem);
            cronExp.StartDate = DateTime.SpecifyKind(startDate, DateTimeKind.Local);
        }
        private void everySMHRbtn_CheckedChanged(object sender, EventArgs e)
        {
            EnableDisableExtendedCronURI();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
