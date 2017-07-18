using System;
using System.Windows.Forms;
using StringsConstantsAndEnumerations;

namespace MaintenanceSchedulerControlLibrary
{
    public partial class ExtendedCronURI : UserControl
    {
        public ExtendedCronURI()
        {
            InitializeComponent();
            timeIntervalCb.DataSource = ((Enum.GetValues(typeof(Enumerations.TimeInterval))) as Enumerations.TimeInterval[]);
            dayCb.DataSource = Strings.Days;
            monthCb.DataSource = ((Enum.GetValues(typeof(Enumerations.Month))) as Enumerations.Month[]);
            yearCb.DataSource = Strings.Years;
            hoursCb.DataSource = Strings.Hours;
            minutesCb.DataSource = Strings.Minutes;
            secondsCb.DataSource = Strings.Seconds;
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
                
            }
            else if (selectedTimeInterval == Enumerations.TimeInterval.Month)
            {
                timeIntervalValueCb.DataSource = ((Enum.GetValues(typeof(Enumerations.Month))) as Enumerations.Month[]);
            }
            else
            {
                timeIntervalValueCb.DataSource = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            }
        }
    }
}
