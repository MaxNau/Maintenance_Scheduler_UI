using StringsConstantsAndEnumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MaintenanceSchedulerControlLibrary
{
    public partial class ExtendedCronURIEverySMHStartAtSpecTime : UserControl
    {
        public ExtendedCronURIEverySMHStartAtSpecTime()
        {
            InitializeComponent();
            timeIntervalCb.DataSource = ((Enum.GetValues(typeof(Enumerations.TimeInterval))) as Enumerations.TimeInterval[]).ToList();
            dayCb.DataSource = new List<int>(Strings.Days);
            monthCb.DataSource = ((Enum.GetValues(typeof(Enumerations.Month))) as Enumerations.Month[]);
            yearCb.DataSource = new List<int>(Strings.Years);
            hoursCb.DataSource = new List<int>(Strings.Hours);
            minutesCb.DataSource = new List<int>(Strings.Minutes);
            secondsCb.DataSource = new List<int>(Strings.Seconds);
        }

        private void timeIntervalCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            timeIntervalValueCb.DataSource = null;
            var selectedTimeInterval = (Enumerations.TimeInterval)(sender as ComboBox).SelectedItem;
            if (selectedTimeInterval == Enumerations.TimeInterval.Second)
            {
                timeIntervalValueCb.DataSource = Strings.Seconds;
            }
            else if (selectedTimeInterval == Enumerations.TimeInterval.Minute)
            {
                timeIntervalValueCb.DataSource = Strings.Minutes;
            }
            else if (selectedTimeInterval == Enumerations.TimeInterval.Hour)
            {
                timeIntervalValueCb.DataSource = Strings.Hours;
            }
            else if (selectedTimeInterval == Enumerations.TimeInterval.Day_of_the_month)
            {
                timeIntervalValueCb.DataSource = Strings.Days;
            }
            else if (selectedTimeInterval == Enumerations.TimeInterval.Day_of_the_week)
            {
                timeIntervalValueCb.DataSource = ((Enum.GetValues(typeof(Enumerations.DayOfWeek))) as Enumerations.DayOfWeek[]);
            }
            else if (selectedTimeInterval == Enumerations.TimeInterval.Month)
            {
                timeIntervalValueCb.DataSource = ((Enum.GetValues(typeof(Enumerations.Month))) as Enumerations.Month[]);
            }
            else
            {
                timeIntervalValueCb.DataSource = Strings.YearStep;
            }
        }
    }
}
