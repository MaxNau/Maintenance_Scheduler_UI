using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Maintenance_Scheduler_BAL.SchedulerJobs;

namespace Maintenance_Scheduler_UI
{
    public partial class MaintanceMessager : UserControl
    {
        public MaintanceMessager()
        {
            InitializeComponent();
            MaintenanceJob.JobDone += ReplaceFanucBatteries_JobDone;
        }

        private void ReplaceFanucBatteries_JobDone(object sender, EventArgs e)
        {
            Invoke((MethodInvoker)delegate
            {
                textBox1.Text = sender as string;
            });
        }
    }
}
