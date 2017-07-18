

namespace StringsConstantsAndEnumerations
{
    public class Strings
    {
        #region AddMaintenanceSchedulerView User Control strings

        public static readonly string FieldIsRequiredMessage = "This field is required";
        public static readonly string JobNameAlreadyExists = "Job name already exists in the database";
        public static readonly string TriggerNameAlreadyExists = "Trigger name already exists in the database";
        public static readonly string MustBeValidCronExpression = "Must be a valid cron expression";

        #endregion

        #region Cron
        public static readonly int[] Seconds = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14,
        15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39,
        40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59 };

        public static readonly int[] Minutes = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14,
        15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39,
        40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59 };

        public static readonly int[] Hours = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17,
        18, 19, 20, 21, 22, 23};

        public static readonly int[] Days = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18,
        19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31 };

        public static readonly int[] Years = { 2017, 2018, 2019, 2020, 2021, 2022, 2023, 2024, 2025, 2026, 2027,
        2028, 2029, 2030, 2031, 2032, 2033, 2034, 2035, 2036, 2037, 2038, 2039, 2040, 2041, 2042, 2043, 2044, 2045 };

        public static readonly int[] YearStep = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        #endregion
    }
}
