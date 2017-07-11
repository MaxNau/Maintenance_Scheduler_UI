using Maintenance_Scheduler_BAL;
using Maintenance_Scheduler_DAL.DataAccess;
using Maintenance_Scheduler_DAL.DataAccess.DTOs;
using Maintenance_Scheduler_DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maintenance_Scheduler_UI.ViewModels
{
    public class JobsAndTriggersViewModel
    {
        public BindingList<TriggerDTO> Triggers { get; set; }

        public JobsAndTriggersViewModel()
        {
            Triggers = new BindingList<TriggerDTO>(MaintenanceSchedulerDb.GetAllTriggers());
        }

        public void RemoveJob(string jobName)
        {
            MaintanceScheduler.RemoveJob(jobName);
            var trigger = Triggers.FirstOrDefault(t => t.JobName == jobName);
            Triggers.Remove(trigger);
        }
    }
}
