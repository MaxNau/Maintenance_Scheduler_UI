using Maintenance_Scheduler_DAL.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maintenance_Scheduler_UI.ViewModels
{
    public class LogsViewModel
    {
        public LogsViewModel()
        {
            GetLogs();
        }

        public BindingList<log> Logs { get; set; }

        private void GetLogs()
        {
            using (LogsDb context = new LogsDb())
            {
                Logs = new BindingList<log>(context.logs.ToList());
            }
        }
    }
}
