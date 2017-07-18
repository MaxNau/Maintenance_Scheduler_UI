using System;

namespace MaintenanceSchedulerControlLibrary
{
    public class CronExp
    {
        public string Seconds { get; set; }
        public string Minutes { get; set; }
        public string Hours { get; set; }
        public string DayOfMonth { get; set; }
        public string Month { get; set; }
        public string DayOfWeek { get; set; }
        public string Year { get; set; }
        public DateTimeOffset StartDate { get; set; }

        public CronExp()
        {
            Seconds = Minutes = Hours = Month = DayOfWeek = Year = "*";
            DayOfMonth = "*";
            StartDate = DateTimeOffset.Now;
        }

        public string CronExpression
        {
            get
            {
                return String.Join(" ", Seconds, Minutes, Hours, DayOfMonth, Month, DayOfWeek, Year);
            }
        }

        public void SetCronExpression(string seconds = "*", string minutes = "*", string hours = "*",
            string dayOfMonth = "*", string dayOfWeek = "*", string month = "*", string year = "*")
        {
            Seconds = seconds;
            Minutes = minutes;
            Hours = hours;
            DayOfMonth = dayOfMonth;
            DayOfWeek = dayOfWeek;
            Month = month;
            Year = year;
        }
    }
}
