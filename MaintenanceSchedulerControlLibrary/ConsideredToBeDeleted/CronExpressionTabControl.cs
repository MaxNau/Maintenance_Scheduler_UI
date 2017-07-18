using StringsConstantsAndEnumerations;
using System;
using System.Linq;
using System.Windows.Forms;

namespace MaintenanceSchedulerControlLibrary
{
    public partial class CronExpressionTabControl : UserControl
    {
        private CronExp cronExp;

        public string CronExpression { get { return cronExp.CronExpression; } }

        public CronExpressionTabControl()
        {
            InitializeComponent();
            SetGroupBoxNames();
            SetDataSourceForTimeIntervalListBoxes();
            SubscribeToEvnets();
            cronExp = new CronExp();
        }

        private void SetGroupBoxNames()
        {
            secondsCronURIPart.GroupBoxText = "Seconds";
            minutesCronURIPart.GroupBoxText = "Minutes";
            hoursCronURIPart.GroupBoxText = "Hours";
            dayCronURIPart.GroupBoxText = "Day";
            monthCronURIPart.GroupBoxText = "Month";
            yearCronURIPart.GroupBoxText = "Year";
        }

        private void SetDataSourceForTimeIntervalListBoxes()
        {
            secondsCronURIPart.timeIntervalListbox.DataSource = Strings.Seconds;
            minutesCronURIPart.timeIntervalListbox.DataSource = Strings.Minutes;
            hoursCronURIPart.timeIntervalListbox.DataSource = Strings.Hours;
            dayCronURIPart.timeIntervalListbox.DataSource = Strings.Days;
            monthCronURIPart.timeIntervalListbox.DataSource = ((Enum.GetValues(typeof(Enumerations.Month))) as Enumerations.Month[]).ToList();
            yearCronURIPart.timeIntervalListbox.DataSource = Strings.Years;
        }

        private void SubscribeToEvnets()
        {
            secondsCronURIPart.timeIntervalListbox.SelectedIndexChanged += SecondsListbox_SelectedIndexChanged;
            secondsCronURIPart.selectIntervalRbtn.CheckedChanged += SelectSecondsRbtn_CheckedChanged;
            minutesCronURIPart.timeIntervalListbox.SelectedIndexChanged += MinutesListbox_SelectedIndexChanged;
            minutesCronURIPart.selectIntervalRbtn.CheckedChanged += SelectMinutesRbtn_CheckedChanged;
            hoursCronURIPart.timeIntervalListbox.SelectedIndexChanged += HoursListbox_SelectedIndexChanged;
            hoursCronURIPart.selectIntervalRbtn.CheckedChanged += HoursRbtn_CheckedChanged;
            dayCronURIPart.timeIntervalListbox.SelectedIndexChanged += DaysListbox_SelectedIndexChanged;
            dayCronURIPart.selectIntervalRbtn.CheckedChanged += SelectDayRbtn_CheckedChanged;
            monthCronURIPart.timeIntervalListbox.SelectedIndexChanged += MonthListbox_SelectedIndexChanged;
            monthCronURIPart.selectIntervalRbtn.CheckedChanged += SelectMonthRbtn_CheckedChanged;
            yearCronURIPart.timeIntervalListbox.SelectedIndexChanged += YearsListbox_SelectedIndexChanged;
            yearCronURIPart.selectIntervalRbtn.CheckedChanged += SelectYearRbtn_CheckedChanged;

            secondsCronURIPart.extendedCronURI1.timeIntervalValueCb.SelectedIndexChanged += TimeIntervalValueCb_SelectedIndexChanged;
        }

        private void TimeIntervalValueCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedIntervalValue = (sender as ComboBox).SelectedItem;
            if ((Enumerations.TimeInterval)secondsCronURIPart.extendedCronURI1.timeIntervalCb.SelectedItem == Enumerations.TimeInterval.Second)
            {
                cronExp.Seconds = String.Format("0/{0}", selectedIntervalValue);
                cronExp.Minutes = "0/1";
                cronExp.Hours = "*";
                cronExp.DayOfMonth = "1/1";
                cronExp.Month = "*";
                cronExp.Year = "*";
            }
            else if ((Enumerations.TimeInterval) secondsCronURIPart.extendedCronURI1.timeIntervalCb.SelectedItem == Enumerations.TimeInterval.Minute)
            {
                cronExp.Seconds = "0";
                cronExp.Minutes = String.Format("0/{0}", selectedIntervalValue);
                cronExp.Hours = "*";
                cronExp.DayOfMonth = "*";
                cronExp.Month = "*";
                cronExp.Year = "*";
            }
            else if ((Enumerations.TimeInterval)secondsCronURIPart.extendedCronURI1.timeIntervalCb.SelectedItem == Enumerations.TimeInterval.Hour)
            {
                cronExp.Seconds = "0";
                cronExp.Minutes = "0";
                cronExp.Hours = String.Format("0/{0}", selectedIntervalValue);
                cronExp.DayOfMonth = "*";
                cronExp.Month = "*";
                cronExp.Year = "*";
            }
            else if ((Enumerations.TimeInterval)secondsCronURIPart.extendedCronURI1.timeIntervalCb.SelectedItem == Enumerations.TimeInterval.Day_of_the_month)
            {
                cronExp.Seconds = "0";
                cronExp.Minutes = "0";
                cronExp.Hours = "12";
                cronExp.DayOfMonth = String.Format("1/{0}", selectedIntervalValue);
                cronExp.Month = "*";
                cronExp.Year = "*";
            }
        }

        private void secondsCronURIPartAllRbtn_CheckedChanged(object sender, EventArgs e)
        {
            secondsCronURIPart.timeIntervalListbox.Enabled = secondsCronURIPart.selectIntervalRbtn.Checked;
        }

        private void AllRbtn_CheckedChanged(object sender, EventArgs e)
        {  
            secondsCronURIPart.timeIntervalListbox.Enabled = secondsCronURIPart.selectIntervalRbtn.Checked;
            minutesCronURIPart.timeIntervalListbox.Enabled = minutesCronURIPart.selectIntervalRbtn.Checked;
            hoursCronURIPart.timeIntervalListbox.Enabled = hoursCronURIPart.selectIntervalRbtn.Checked;
            dayCronURIPart.timeIntervalListbox.Enabled = dayCronURIPart.selectIntervalRbtn.Checked;
            monthCronURIPart.timeIntervalListbox.Enabled = monthCronURIPart.selectIntervalRbtn.Checked;
            yearCronURIPart.timeIntervalListbox.Enabled = yearCronURIPart.selectIntervalRbtn.Checked;
        }

        private void CheckUncheckAllRbtnCronURIPart(bool isChecked)
        {
            secondsCronURIPart.allRbtn.Checked = isChecked;
            minutesCronURIPart.allRbtn.Checked = isChecked;
            hoursCronURIPart.allRbtn.Checked = isChecked;
            dayCronURIPart.allRbtn.Checked = isChecked;
            monthCronURIPart.allRbtn.Checked = isChecked;
            yearCronURIPart.allRbtn.Checked = isChecked;
        }

        private void SelectYearRbtn_CheckedChanged(object sender, EventArgs e)
        {
            cronExp.Year = "*";
        }

        private void YearsListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            cronExp.Year = (sender as ListBox).SelectedItem.ToString();
        }

        private void SelectMonthRbtn_CheckedChanged(object sender, EventArgs e)
        {
            cronExp.Month = "*";
        }

        private void MonthListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            cronExp.Month = (sender as ListBox).SelectedItem.ToString();
        }

        private void SelectDayRbtn_CheckedChanged(object sender, EventArgs e)
        {
            cronExp.DayOfMonth = "*";
        }

        private void DaysListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            cronExp.DayOfMonth = (sender as ListBox).SelectedItem.ToString();
        }

        private void HoursRbtn_CheckedChanged(object sender, EventArgs e)
        {
            cronExp.Hours = "*";
        }

        private void HoursListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            cronExp.Hours = (sender as ListBox).SelectedItem.ToString();
        }

        private void SelectMinutesRbtn_CheckedChanged(object sender, EventArgs e)
        {
            cronExp.Minutes = "*";
        }

        private void MinutesListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            cronExp.Minutes = (sender as ListBox).SelectedItem.ToString();
        }

        private void SelectSecondsRbtn_CheckedChanged(object sender, EventArgs e)
        {
            cronExp.Seconds = "*";
        }

        private void SecondsListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            cronExp.Seconds = (sender as ListBox).SelectedItem.ToString();
        }
    }
}
