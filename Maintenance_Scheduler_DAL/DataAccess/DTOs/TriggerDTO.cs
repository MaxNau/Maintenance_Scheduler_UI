using System;
using System.ComponentModel;

namespace Maintenance_Scheduler_DAL.DataAccess.DTOs
{
    public class TriggerDTO
    {
        private long? nextFireTime;
        private long? previousFireTime;
        private long startTime;
        private long? endTime;

        public string Name { get; set; }
        public string JobName { get; set; }
        public string Message { get; set; }
        public string Type { get; set; }
        public DateTime PreviousFireTimeDate { get; set; }
        public DateTime NextFireTimeDate { get; set; }
        public DateTime StartTimeDate { get; set; }
        public DateTime EndTimeDate { get; set; }

        [Browsable(false)]
        public long StartTime
        {
            get { return startTime; }
            set
            {
                startTime = value;
                StartTimeDate = new DateTime(startTime);
            }
        }

        [Browsable(false)]
        public long? EndTime
        {
            get { return endTime; }
            set
            {
                endTime = value;
                if (endTime != null)
                    EndTimeDate = new DateTime(endTime.Value);
            }
        }

        [Browsable(false)]
        public long? PreviousFireTime
        {
            get { return previousFireTime; }
            set
            {
                previousFireTime = value;
                if (previousFireTime != null)
                    PreviousFireTimeDate = new DateTime(previousFireTime.Value);
            }
        }

        [Browsable(false)]
        public long? NextFireTime
        {
            get { return nextFireTime; }
            set
            {
                nextFireTime = value;
                if (nextFireTime != null)
                    NextFireTimeDate = new DateTime(((long)nextFireTime.Value));
            }
        }
    }
}
