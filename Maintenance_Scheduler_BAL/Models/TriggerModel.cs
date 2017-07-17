
using System;

namespace Maintenance_Scheduler_BAL.Models
{
    public class TriggerModel
    {
        public string Name { get; set; }
        public string JobName { get; set; }
        public string Message { get; set; }
        public string Type { get; set; }
        public string CronExpression { get; set; }
        public DateTimeOffset? PreviousFireTimeDate { get; set; }
        public DateTimeOffset? NextFireTimeDate { get; set; }
        public DateTimeOffset StartTimeDate { get; set; }
        public DateTimeOffset? EndTimeDate { get; set; }
    }
}
