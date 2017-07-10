using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maintenance_Scheduler_BAL.SchedulerJobs
{
    public class MaintenanceJob : IJob, IMaintanenceJob
    {
        public static event EventHandler JobDone;

        public void Execute(IJobExecutionContext context)
        {
            var some = context.JobDetail.JobDataMap.GetString("Message");
            OnJobDone(some);
        }

        public void OnJobDone(string result)
        {
            JobDone?.Invoke(result, EventArgs.Empty);
        }
    }
}
