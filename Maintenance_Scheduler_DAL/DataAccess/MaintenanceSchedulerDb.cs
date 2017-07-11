using Maintenance_Scheduler_DAL.DataAccess.DTOs;
using Maintenance_Scheduler_DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maintenance_Scheduler_DAL.DataAccess
{
    public class MaintenanceSchedulerDb
    {
        public static List<TriggerDTO> GetAllTriggers()
        {
            List<TriggerDTO> triggers = new List<TriggerDTO>();
            using (MaintenanceSchedulerContext context = new MaintenanceSchedulerContext())
            {
                try
                {
                    triggers = (from t in context.qrtz_triggers
                                select new TriggerDTO()
                                {
                                    Name = t.TRIGGER_NAME,
                                    JobName = t.JOB_NAME,
                                    Type = t.TRIGGER_TYPE,
                                    NextFireTime = t.NEXT_FIRE_TIME,
                                    PreviousFireTime = t.PREV_FIRE_TIME,
                                    StartTime = t.START_TIME,
                                    EndTime = t.END_TIME
                                }).ToList();
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            return triggers;
        }
    }
}
