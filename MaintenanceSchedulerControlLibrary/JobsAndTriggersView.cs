using StringsConstantsAndEnumerations;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Forms;

namespace Maintenance_Scheduler_UI
{
    public partial class JobsAndTriggersView : UserControl
    {
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
            AddRemoveColumnToTriggersDgv();
        }


        private void ViewModel_UpdateTrigersDgv(object sender, EventArgs e)
        {
            triggersDgv.Invoke(new MethodInvoker(delegate {
                triggersDgv.DataSource = null;
                triggersDgv.DataSource = viewModel.Triggers;
                triggersDgv.Refresh(); }));
            }

        private void JobsAndTriggersView_Load(object sender, EventArgs e)
        {
         
        }

        private void triggersDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var dgv = sender as DataGridView;
            if (dgv.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0 && dgv.Columns[e.ColumnIndex].Name == "Remove")
            {
                ITriggerViewModel triggerToRemove = (ITriggerViewModel)(dgv.CurrentRow.DataBoundItem);
                viewModel.RemoveJob(triggerToRemove.JobName);
            }
        }

        /// <summary>
        /// Adds DataGridViewButtonColumn that removes job
        /// </summary>
        private void AddRemoveColumnToTriggersDgv()
        {
            DataGridViewButtonColumn removeButton = new DataGridViewButtonColumn();
            removeButton.Name = "Remove";
            removeButton.Text = "Remove";
            removeButton.UseColumnTextForButtonValue = true;

            triggersDgv.Columns.Add(removeButton);
        }

        private void triggersDgv_DataSourceChanged(object sender, EventArgs e)
        {

        }

        private void triggersDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ITriggerViewModel trigger = (ITriggerViewModel)((sender as DataGridView)
                .CurrentRow.DataBoundItem);
            jobAndTriggerView1.TriggerName = trigger.Name;
            jobAndTriggerView1.JobName = trigger.JobName;
            jobAndTriggerView1.JobMessage = trigger.Message;
            jobAndTriggerView1.CronExpression = trigger.CronExpression;
            jobAndTriggerView1.MailBody = trigger.MailBody;
        }
    }

    public interface IJobsAndTriggersViewModel
    {
        event EventHandler UpdateTrigersDgv;
        ObservableCollection<ITriggerViewModel> Triggers { get; set; }
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
        Enumerations.MaintenanceJobType SelectedJobType { get; set; }
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
