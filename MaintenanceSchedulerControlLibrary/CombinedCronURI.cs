using StringsConstantsAndEnumerations;
using System;
using System.Collections.Generic;
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
        }

        private void EnableDisableExtendedCronURI()
        {
            extendedCronURI_1.Enabled = everySMHRbtn.Checked;
            extendedCronURI_1.Visible = everySMHRbtn.Checked;
            
            extendedCronURIEveryDMYAtSpecTime1.Enabled = specificTimeRbtn.Checked;
            extendedCronURIEveryDMYAtSpecTime1.Visible = specificTimeRbtn.Checked;

            extendedCronURIEveryYearsOnSpecifiedDateTime1.Enabled = everyNYearsOnAtStartingRb.Checked;
            extendedCronURIEveryYearsOnSpecifiedDateTime1.Visible = everyNYearsOnAtStartingRb.Checked;
        }

        private void SubscribeToEvents()
        {
            extendedCronURI_1.SelectedDateTimeIndexChanged += ExtendedCronURI_1_SelectedDateTimeIndexChanged;
             
            extendedCronURIEveryDMYAtSpecTime1.SelectedDateTimeIndexChanged += ExtendedCronURIEveryDMYAtSpecTime1_SelectedDateTimeIndexChanged;

            extendedCronURIEveryYearsOnSpecifiedDateTime1.SelectedDateTimeIndexChanged += ExtendedCronURIEveryYearsOnSpecifiedDateTime1_SelectedDateTimeIndexChanged;
        }

        private void ExtendedCronURI_1_SelectedDateTimeIndexChanged()
        {
            if (everySMHRbtn.Checked == true)
            {
                if (extendedCronURI_1.SelectedTimeInterval == Enumerations.TimeInterval.Second)
                {
                    cronExp.Seconds = String.Format("0/{0}", extendedCronURI_1.SelectedTimeInterval);
                    cronExp.Minutes = "*";
                    cronExp.Hours = "*";
                    cronExp.DayOfMonth = "1/1";
                    cronExp.DayOfWeek = "?";
                    cronExp.Month = "*";
                    cronExp.Year = "*";
                }
                else if (extendedCronURI_1.SelectedTimeInterval == Enumerations.TimeInterval.Minute)
                {
                    cronExp.Seconds = "0";
                    cronExp.Minutes = String.Format("0/{0}", extendedCronURI_1.SelectedTimeIntervalValue);
                    cronExp.Hours = "*";
                    cronExp.DayOfMonth = "1/1";
                    cronExp.DayOfWeek = "?";
                    cronExp.Month = "*";
                    cronExp.Year = "*";
                }
                else if (extendedCronURI_1.SelectedTimeInterval == Enumerations.TimeInterval.Hour)
                {
                    cronExp.Seconds = "0";
                    cronExp.Minutes = "0";
                    cronExp.Hours = String.Format("0/{0}", extendedCronURI_1.SelectedTimeIntervalValue);
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

        private void ExtendedCronURIEveryDMYAtSpecTime1_SelectedDateTimeIndexChanged()
        {
            if (specificTimeRbtn.Checked == true)
            {
                if (extendedCronURIEveryDMYAtSpecTime1.SelectedTimeInterval == Enumerations.TimeInterval.Day_of_the_month)
                {
                    cronExp.Seconds = extendedCronURIEveryDMYAtSpecTime1.SelectedSecond.ToString();
                    cronExp.Minutes = extendedCronURIEveryDMYAtSpecTime1.SelectedMinute.ToString();
                    cronExp.Hours = extendedCronURIEveryDMYAtSpecTime1.SelectedHour.ToString();
                    cronExp.DayOfMonth = String.Format("1/{0}", extendedCronURIEveryDMYAtSpecTime1.SelectedTimeInterval);
                    cronExp.DayOfWeek = "?";
                    cronExp.Month = "*";
                    cronExp.Year = "*";
                }
                else if (extendedCronURIEveryDMYAtSpecTime1.SelectedTimeInterval == Enumerations.TimeInterval.Day_of_the_week)
                {
                    cronExp.Seconds = extendedCronURIEveryDMYAtSpecTime1.SelectedSecond.ToString();
                    cronExp.Minutes = extendedCronURIEveryDMYAtSpecTime1.SelectedMinute.ToString();
                    cronExp.Hours = extendedCronURIEveryDMYAtSpecTime1.SelectedHour.ToString();
                    cronExp.DayOfMonth = "?";
                    cronExp.Month = "*";
                    cronExp.DayOfWeek = extendedCronURIEveryDMYAtSpecTime1.SelectedTimeIntervalValue.ToString();
                    cronExp.Year = "*";
                }
                else if (extendedCronURI_1.SelectedTimeInterval == Enumerations.TimeInterval.Month)
                {
                    cronExp.Seconds = extendedCronURIEveryDMYAtSpecTime1.SelectedSecond.ToString();
                    cronExp.Minutes = extendedCronURIEveryDMYAtSpecTime1.SelectedMinute.ToString();
                    cronExp.Hours = extendedCronURIEveryDMYAtSpecTime1.SelectedHour.ToString();
                    cronExp.DayOfMonth = "?";
                    cronExp.Month = String.Format("1/{0}", extendedCronURIEveryDMYAtSpecTime1.SelectedTimeIntervalValue.ToString());
                    cronExp.DayOfWeek = "*";
                    cronExp.Year = "*";
                }
            }
            else
            {
                cronExp.SetCronExpression();
            }
        }

        private void ExtendedCronURIEveryYearsOnSpecifiedDateTime1_SelectedDateTimeIndexChanged()
        {
            if (everyNYearsOnAtStartingRb.Checked == true)
            {
                cronExp.Seconds = extendedCronURIEveryYearsOnSpecifiedDateTime1.SelectedSecond.ToString();
                cronExp.Minutes = extendedCronURIEveryYearsOnSpecifiedDateTime1.SelectedMinute.ToString();
                cronExp.Hours = extendedCronURIEveryYearsOnSpecifiedDateTime1.SelectedHour.ToString();
                cronExp.DayOfMonth = extendedCronURIEveryYearsOnSpecifiedDateTime1.SelectedDay.ToString();
                cronExp.DayOfWeek = "?";
                cronExp.Month = extendedCronURIEveryYearsOnSpecifiedDateTime1.SelectedMonth.ToString();
                cronExp.Year = extendedCronURIEveryYearsOnSpecifiedDateTime1.SelectedYear.ToString() + "/"
                    + extendedCronURIEveryYearsOnSpecifiedDateTime1.SelectedYearStep.ToString();
            }
            else
            {
                cronExp.SetCronExpression();
            }
        }

        private void SetStartDate()
        {
            DateTime startDate = new DateTime(extendedCronURI_1.SelectedYear,
                (int)extendedCronURI_1.SelectedMonth, extendedCronURI_1.SelectedDayOfMonth,
                extendedCronURI_1.SelectedHour, extendedCronURI_1.SelectedMinute,
                extendedCronURI_1.SelectedSecond);
            cronExp.StartDate = DateTime.SpecifyKind(startDate, DateTimeKind.Local);
        }
        private void everySMHRbtn_CheckedChanged(object sender, EventArgs e)
        {
            cronExp.SetCronExpression();
            EnableDisableExtendedCronURI();
        }
    }
}
