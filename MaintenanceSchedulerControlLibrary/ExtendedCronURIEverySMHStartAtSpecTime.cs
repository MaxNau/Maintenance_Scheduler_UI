using StringsConstantsAndEnumerations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace MaintenanceSchedulerControlLibrary
{
    public partial class ExtendedCronURIEverySMHStartAtSpecTime : UserControl
    {
        public delegate void SelectedDateTimeIndexChangedDelegate();

        [Category("Event")]
        [Description("Fires when the selected date time index is changed.")]
        public event SelectedDateTimeIndexChangedDelegate SelectedDateTimeIndexChanged;

        public ExtendedCronURIEverySMHStartAtSpecTime()
        {
            InitializeComponent();
            SetDataSourceOfComboBoxes();
        }

        private void SetDataSourceOfComboBoxes()
        {
            timeIntervalCb.DataSource = ((Enum.GetValues(typeof(Enumerations.TimeInterval))) as Enumerations.TimeInterval[]).ToList().GetRange(0, 3);
            dayCb.DataSource = new List<int>(Strings.Days);
            monthCb.DataSource = ((Enum.GetValues(typeof(Enumerations.Month))) as Enumerations.Month[]);
            yearCb.DataSource = new List<int>(Strings.Years);
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

        public int SelectedDayOfMonth
        {
            get { return (int)dayCb.SelectedItem; }
        }

        public Enumerations.Month SelectedMonth
        {
            get { return (Enumerations.Month)monthCb.SelectedItem; }
        }

        public int SelectedYear
        {
            get { return (int)yearCb.SelectedItem; }
        }

        public Enumerations.TimeInterval SelectedTimeInterval
        {
            get { return (Enumerations.TimeInterval)timeIntervalCb.SelectedItem; }
        }

        public object SelectedTimeIntervalValue
        {
            get { return timeIntervalValueCb.SelectedItem; }
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
