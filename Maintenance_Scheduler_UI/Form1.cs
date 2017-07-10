using Maintenance_Scheduler_BAL;
using Maintenance_Scheduler_BAL.SchedulerJobs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maintenance_Scheduler_UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            MaintanceScheduler.Start();
            InitializeComponent();
        }
    }
}
