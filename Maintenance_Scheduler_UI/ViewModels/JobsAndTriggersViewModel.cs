using Maintenance_Scheduler_DAL.DataAccess;
using Maintenance_Scheduler_DAL.DataAccess.DTOs;
using Maintenance_Scheduler_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maintenance_Scheduler_UI.ViewModels
{
    public class JobsAndTriggersViewModel
    {
        public List<TriggerDTO> Triggers { get; set; }

        public JobsAndTriggersViewModel()
        {
            Triggers = MaintenanceSchedulerDb.GetAllTriggers();
        }
    }
}
