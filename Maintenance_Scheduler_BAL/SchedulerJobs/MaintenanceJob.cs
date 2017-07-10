using Quartz;
using System;

namespace Maintenance_Scheduler_BAL.SchedulerJobs
{
    public class MaintenanceJob : IJob, IMaintanenceJob
    {
        public static event EventHandler JobDone;

        public void Execute(IJobExecutionContext context)
        {
            var message = context.JobDetail.JobDataMap.GetString("Message");
            OnJobDone(message);
        }

        public void OnJobDone(string result)
        {
            JobDone?.Invoke(result, EventArgs.Empty);
        }
    }
}
