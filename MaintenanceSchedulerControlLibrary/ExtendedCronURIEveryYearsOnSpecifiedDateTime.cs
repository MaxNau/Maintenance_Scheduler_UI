using System;
using System.Collections.Generic;
using System.Windows.Forms;
using StringsConstantsAndEnumerations;
using System.ComponentModel;

namespace MaintenanceSchedulerControlLibrary
{
    public partial class ExtendedCronURIEveryYearsOnSpecifiedDateTime : UserControl
    {
        public delegate void SelectedDateTimeIndexChangedDelegate();

        [Category("Event")]
        [Description("Fires when the selected date time index is changed.")]
        public event SelectedDateTimeIndexChangedDelegate SelectedDateTimeIndexChanged;

        protected virtual void OnSelectedDateTimeIndexChanged()
        {
            SelectedDateTimeIndexChanged?.Invoke();
        }

        public ExtendedCronURIEveryYearsOnSpecifiedDateTime()
        {
            InitializeComponent();
            yearsStepCb.DataSource = new List<int>(Strings.YearStep);
            dayCb.DataSource = new List<int>(Strings.Days);
            monthCb.DataSource = ((Enum.GetValues(typeof(Enumerations.Month))) as Enumerations.Month[]);
            yearCb.DataSource = new List<int>(Strings.Years);
            hourCb.DataSource = new List<int>(Strings.Hours);
            minuteCb.DataSource = new List<int>(Strings.Minutes);
            secondCb.DataSource = new List<int>(Strings.Seconds);
        }

        public int SelectedYearStep
        {
            get { return (int)yearsStepCb.SelectedItem; }
        }

        public Enumerations.Month SelectedMonth
        {
            get { return (Enumerations.Month)monthCb.SelectedItem; }
        }

        public int SelectedDay
        {
            get { return (int)dayCb.SelectedItem; }
        }

        public int SelectedHour
        {
            get { return (int)hourCb.SelectedItem; }
        }

        public int SelectedMinute
        {
            get { return (int)minuteCb.SelectedItem; }
        }

        public int SelectedSecond
        {
            get { return (int)secondCb.SelectedItem; }
        }

        public int SelectedYear
        {
            get { return (int)yearCb.SelectedItem; }
        }

        private void comboboxes_SelectedIndexChanged(object sender, EventArgs e)
        {
            OnSelectedDateTimeIndexChanged();
        }
    }
}
