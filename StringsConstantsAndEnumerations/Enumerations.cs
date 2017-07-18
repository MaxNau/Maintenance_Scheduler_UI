
namespace StringsConstantsAndEnumerations
{
    public class Enumerations
    {
        public enum MaintenanceJobType
        {
            Local,
            Mailing
        }

        public enum Month
        {
            JAN = 1,
            FEB,
            MAR,
            APR,
            MAY,
            JUN,
            JUL,
            AUG,
            SEP,
            OCT,
            NOV,
            DEC
        }

        public enum DayOfWeek
        {
            MON,
            TUE,
            WED,
            THU,
            FRI,
            SAT,
            SUN
        }

        public enum TimeInterval
        {
            Second,
            Minute,
            Hour,
            Day_of_the_month,
            Day_of_the_week,
            Month,
            Year
        }
    }
}
