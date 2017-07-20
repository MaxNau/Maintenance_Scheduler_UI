using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using StringsConstantsAndEnumerations;
using System.ComponentModel;

namespace MaintenanceSchedulerControlLibrary
{
    public partial class ExtendedCronURIEveryDMYAtSpecTime : UserControl
    {
        public delegate void SelectedDateTimeIndexChangedDelegate();

        [Category("Event")]
        [Description("Fires when the selected date time index is changed.")]
        public event SelectedDateTimeIndexChangedDelegate SelectedDateTimeIndexChanged;

        public ExtendedCronURIEveryDMYAtSpecTime()
        {
            InitializeComponent();
            timeIntervalCb.DataSource = ((Enum.GetValues(typeof(Enumerations.TimeInterval))) as Enumerations.TimeInterval[]).ToList().GetRange(3, 4);
            hoursCb.DataSource = new List<int>(Strings.Hours);
            minutesCb.DataSource = new List<int>(Strings.Minutes);
            secondsCb.DataSource = new List<int>(Strings.Seconds);
        }

        public int SelectedSecond
        {
            get { return (int)secondsCb.SelectedItem; }
        }

        public int SelectedMinute
        {
            get { return (int)minutesCb.SelectedItem; }
        }

        public int SelectedHour
        {
            get { return (int)hoursCb.SelectedItem; }
        }

        public int SelectedTimeIntervalValue
        {
            get { return (int)timeIntervalValueCb.SelectedItem; }
        }

        public Enumerations.TimeInterval SelectedTimeInterval
        {
            get { return (Enumerations.TimeInterval)timeIntervalCb.SelectedItem; }
        }

        protected virtual void OnSelectedDateTimeIndexChanged()
        {
            SelectedDateTimeIndexChanged?.Invoke();
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

            OnSelectedDateTimeIndexChanged();
        }

        private void comboboxes_SelectedIndexChanged(object sender, EventArgs e)
        {
            OnSelectedDateTimeIndexChanged();
        }
    }
}
