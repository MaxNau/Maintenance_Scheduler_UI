
using System;

namespace Maintenance_Scheduler_BAL.Models
{
    public class TriggerModel
    {
        public string TriggerName { get; set; }
        public string JobName { get; set; }
        public string Message { get; set; }
        public string MailSubject { get; set; }
        public string MailBody { get; set; }
        public string TriggerType { get; set; }
        public string JobType { get; set; }
        public string CronExpression { get; set; }
        public DateTimeOffset? PreviousFireTimeDate { get; set; }
        public DateTimeOffset? NextFireTimeDate { get; set; }
        public DateTimeOffset StartTimeDate { get; set; }
        public DateTimeOffset? EndTimeDate { get; set; }
    }
}
