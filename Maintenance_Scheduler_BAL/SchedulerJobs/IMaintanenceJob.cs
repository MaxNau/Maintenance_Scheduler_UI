using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maintenance_Scheduler_BAL.SchedulerJobs
{
    interface IMaintanenceJob
    {
        void OnJobDone(string result);
    }
}
