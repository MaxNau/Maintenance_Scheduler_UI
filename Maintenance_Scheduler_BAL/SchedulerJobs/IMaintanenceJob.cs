
namespace Maintenance_Scheduler_BAL.SchedulerJobs
{
    interface IMaintanenceJob
    {
        void OnJobDone(string result);
    }
}
