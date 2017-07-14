using Maintenance_Scheduler_DAL.DataAccess.DTOs;
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

        public void IntitializeViewModel(IJobsAndTriggersViewModel viewModel)
        {
            this.viewModel = viewModel;
            viewModel.UpdateTrigersDgv += ViewModel_UpdateTrigersDgv;
            viewModel.SubscribeToJobExecution();
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
            triggersDgv.DataSource = viewModel.Triggers;
            AddRemoveColumnToTriggersDgv();
        }

        private void triggersDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var dgv = sender as DataGridView;
            if (dgv.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0 && dgv.Columns[e.ColumnIndex].Name == "Remove")
            {
                var selectedTrigger = (TriggerDTO)(dgv.CurrentRow.DataBoundItem);
                viewModel.RemoveJob(selectedTrigger.JobName);
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
    }

    public interface IJobsAndTriggersViewModel
    {
        event EventHandler UpdateTrigersDgv;
        ObservableCollection<ITriggerViewModel> Triggers { get; set; }

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
