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
        log4net.ILog log;

        public TestForm()
        {
            InitializeComponent();
            MaintenanceScheduler.Start();
            addMaintenanceScheduleViewE1.InitializeViewModel(new AddMaintenanceSchedulerViewModel());
            var triggers = MaintenanceScheduler.GetAllTriggers();
            MaintenanceJob.JobDone += OnJobDone;
        }

        private void StartLogging()
        {
            log4net.Config.XmlConfigurator.Configure();
            log = log4net.LogManager.GetLogger(typeof(TestForm));
        }

        private void OnJobDone(object sender, EventArgs e)
        {
            try
            {
                if (IsHandleCreated)
                {
                    Invoke((MethodInvoker)delegate
                    {
                        Messanger messanger = new Messanger(sender as string);
                        messanger.ShowDialog();
                    });
                }
            }
            catch(Exception ex)
            {
                log.Error(ex.Message, ex);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StartLogging();
            log.Info("Log from TestForm");
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

        private void viewLogsBtn_Click(object sender, EventArgs e)
        {
            LogsTestForm logsForm = new LogsTestForm();
            logsForm.Show();
        }
    }
}
