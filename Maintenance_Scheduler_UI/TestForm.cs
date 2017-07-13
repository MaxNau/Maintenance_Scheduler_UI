using Maintenance_Scheduler_BAL;
using Maintenance_Scheduler_BAL.SchedulerJobs;
using Maintenance_Scheduler_UI.TestForms;
using Maintenance_Scheduler_UI.ViewModels;
using System;
using System.Windows.Forms;

namespace Maintenance_Scheduler_UI
{
    public partial class TestForm : Form
    { 
        public TestForm()
        {
            InitializeComponent();
            MaintenanceScheduler.Start();
            addMaintenanceScheduleViewE1.InitializeViewModel(new AddMaintenanceSchedulerViewModel());
            var triggers = MaintenanceScheduler.GetAllTriggers();
            MaintenanceJob.JobDone += OnJobDone;
        }

        private void OnJobDone(object sender, EventArgs e)
        {
            Invoke((MethodInvoker)delegate
            {
                Messanger messanger = new Messanger(sender as string);
                messanger.ShowDialog();
            });
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MaintenanceScheduler.Stop();
        }

        private void showJobsAndTriggersInfoBtn_Click(object sender, EventArgs e)
        {
            JobsAndTriggersTestForm form = new JobsAndTriggersTestForm();
            form.Show();
        }
    }
}
