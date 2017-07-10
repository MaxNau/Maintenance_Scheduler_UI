using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Maintenance_Scheduler_BAL;

namespace Maintenance_Scheduler_UI
{
    public partial class AddMaintenanceScheduleView : UserControl
    {
        public AddMaintenanceScheduleView()
        {
            InitializeComponent();
            trigerStartTimeDtp.Format = DateTimePickerFormat.Custom;
            trigerStartTimeDtp.CustomFormat = "yyyy.MM.dd HH:mm";
        }

        // this method will save job details, trigger and will schedule the job 
        private void addTriggerBtn_Click(object sender, EventArgs e)
        {
            //MaintanceScheduler.ScheduleJob(jobNameTb.Text, jobMessageTb.Text, triggerNameTb.Text);
            MaintanceScheduler.ScheduleDailyJob(jobNameTb.Text, jobMessageTb.Text, triggerNameTb.Text, trigerStartTimeDtp.Value, 1);
        }
    }
}
