using StringsConstantsAndEnumerations;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Forms;

namespace Maintenance_Scheduler_UI
{
    public partial class JobsAndTriggersView : UserControl
    {
        ITriggerViewModel currentSelectedTriggerAndJob;
        IJobsAndTriggersViewModel viewModel;
        public JobsAndTriggersView()
        {
            InitializeComponent();
        }

        public void IntitializeViewModel(IJobsAndTriggersViewModel viewModel, IAddMaintenanceSchedulerViewModel viewModel2)
        {
            this.viewModel = viewModel;
            viewModel.UpdateTrigersDgv += ViewModel_UpdateTrigersDgv;
            viewModel.SubscribeToJobExecution();
            triggersDgv.DataSource = viewModel.Triggers;
        }


        private void ViewModel_UpdateTrigersDgv(object sender, EventArgs e)
        {
            if (IsHandleCreated)
            {
                triggersDgv.Invoke(new MethodInvoker(delegate
                {
                    triggersDgv.DataSource = null;
                    triggersDgv.DataSource = viewModel.Triggers;
                    triggersDgv.Refresh();
                }));
            }
        }

        private void JobsAndTriggersView_Load(object sender, EventArgs e)
        {
         
        }

        private void triggersDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void triggersDgv_DataSourceChanged(object sender, EventArgs e)
        {

        }

        private void triggersDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currentSelectedTriggerAndJob = (ITriggerViewModel)((sender as DataGridView)
                .CurrentRow.DataBoundItem);
            jobAndTriggerView1.TriggerName = currentSelectedTriggerAndJob.Name;
            jobAndTriggerView1.JobName = currentSelectedTriggerAndJob.JobName;
            jobAndTriggerView1.JobMessage = currentSelectedTriggerAndJob.Message;
            jobAndTriggerView1.CronExpression = currentSelectedTriggerAndJob.CronExpression;
            jobAndTriggerView1.MailBody = currentSelectedTriggerAndJob.MailBody;
            jobAndTriggerView1.MailSubject = currentSelectedTriggerAndJob.MailSubject;
            jobAndTriggerView1.JobTypes = Enum.GetValues(typeof(Enumerations.MaintenanceJobType));
        }

        private void removeJobTriggerButton_Click(object sender, EventArgs e)
        {
            if (currentSelectedTriggerAndJob != null)
            {
                ITriggerViewModel triggerToRemove = (ITriggerViewModel)(triggersDgv.CurrentRow.DataBoundItem);
                viewModel.RemoveJob(triggerToRemove.JobName);
            }
        }
    }

    public interface IJobsAndTriggersViewModel
    {
        event EventHandler UpdateTrigersDgv;
        BindingList<ITriggerViewModel> Triggers { get; set; }
        IAddMaintenanceSchedulerViewModel viewModel { get; set; }

        /// <summary>
        /// Removes job from the database 
        /// </summary>
        /// <param name="jobName"></param>
        void RemoveJob(string jobName);

        /// <summary>
        /// Removes job from the databound collection 
        /// </summary>
        /// <param name="jobName"></param>
        void RemoveJobFromTheDataSource(string jobName);

        /// <summary>
        /// Subscribes to the job execution event
        /// </summary>
        void SubscribeToJobExecution();

        /// <summary>
        /// Unsubscribes from the job execution event
        /// </summary>
        void UnsuscribeFromJobExecution();
    }

    public interface ITriggerViewModel
    {
        string Name { get; set; }
        string JobName { get; set; }
        string Message { get; set; }

        [Browsable(false)]
        Enumerations.MaintenanceJobType SelectedJobType { get; set; }

        [Browsable(false)]
        List<Enumerations.MaintenanceJobType> JobTypes { get; set; }

        string TriggerType { get; set; }
        string MailSubject { get; set; }
        string MailBody { get; set; }
        string CronExpression { get; set; }
        DateTimeOffset? PreviousFireTimeDate { get; set; }
        DateTimeOffset? NextFireTimeDate { get; set; }
        DateTimeOffset StartTimeDate { get; set; }
        DateTimeOffset? EndTimeDate { get; set; }
    }
}
