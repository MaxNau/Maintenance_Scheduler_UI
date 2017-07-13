using Maintenance_Scheduler_BAL.Models;
using System;

namespace Maintenance_Scheduler_UI.ViewModels
{
    public class TriggerViewModel : ITriggerViewModel
    {
        public TriggerViewModel(TriggerModel model)
        {
            Name = model.Name;
            JobName = model.JobName;
            Message = model.Message;
            Type = model.Type;
            PreviousFireTimeDate = model.PreviousFireTimeDate;
            NextFireTimeDate = model.NextFireTimeDate;
            StartTimeDate = model.StartTimeDate;
            EndTimeDate = model.EndTimeDate;
        }

        public string Name { get; set; }
        public string JobName { get; set; }
        public string Message { get; set; }
        public string Type { get; set; }
        public DateTimeOffset? PreviousFireTimeDate { get; set; }
        public DateTimeOffset? NextFireTimeDate { get; set; }
        public DateTimeOffset StartTimeDate { get; set; }
        public DateTimeOffset? EndTimeDate { get; set; }
    }
}
