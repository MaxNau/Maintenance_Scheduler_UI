using StringsConstantsAndEnumerations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace Maintenance_Scheduler_UI
{
    public partial class JobsAndTriggersView : UserControl
    {
        IJobsAndTriggersViewModel viewModel;
        public JobsAndTriggersView()
        {
            InitializeComponent();
            jobAndTriggerView1.RemoveButtonClicked += JobAndTriggerView1_RemoveButtonClicked;
            jobAndTriggerView1.UpdateJobButtonClicked += JobAndTriggerView1_UpdateJobButtonClicked;
            jobAndTriggerView1.UpdateTriggerButtonClicked += JobAndTriggerView1_UpdateTriggerButtonClicked;
        }

        private void JobAndTriggerView1_UpdateTriggerButtonClicked()
        {

            if (viewModel.oldJobAndTrigger != null)
            {
                viewModel.JobAndTriggerToUpdate.Name = jobAndTriggerView1.TriggerName;
                viewModel.JobAndTriggerToUpdate.JobName = jobAndTriggerView1.JobName;
                viewModel.JobAndTriggerToUpdate.Message = jobAndTriggerView1.JobMessage;
                viewModel.JobAndTriggerToUpdate.CronExpression = jobAndTriggerView1.CronExpression;
                viewModel.JobAndTriggerToUpdate.MailBody = jobAndTriggerView1.MailBody;
                viewModel.JobAndTriggerToUpdate.MailSubject = jobAndTriggerView1.MailSubject;
                viewModel.JobAndTriggerToUpdate.StartTimeDate = jobAndTriggerView1.TriggerStartDate;
                if (viewModel.UpdateTrigger(viewModel.oldJobAndTrigger.Name, viewModel.JobAndTriggerToUpdate.Name,
                    viewModel.JobAndTriggerToUpdate.CronExpression, viewModel.JobAndTriggerToUpdate.StartTimeDate))
                {
                    MessageBox.Show("Trigger updated and rescheduled");
                }
                else
                {
                    MessageBox.Show("Unable to updated or reschedule trigger");
                }
            }
        }

        private void JobAndTriggerView1_UpdateJobButtonClicked()
        {
            if (viewModel.oldJobAndTrigger != null)
            {
                viewModel.UpdateJob(jobAndTriggerView1.JobName, jobAndTriggerView1.JobMessage, 
                    (Enumerations.MaintenanceJobType)jobAndTriggerView1.SelectedJobType, jobAndTriggerView1.MailSubject, jobAndTriggerView1.MailBody);
            }
        }

        private void JobAndTriggerView1_RemoveButtonClicked()
        {
            if (viewModel.oldJobAndTrigger != null)
            {
                ITriggerViewModel triggerToRemove = viewModel.oldJobAndTrigger;
                viewModel.RemoveJob(triggerToRemove.JobName);
            }
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

        private void triggersDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            viewModel.oldJobAndTrigger = (ITriggerViewModel)((sender as DataGridView)
                .CurrentRow.DataBoundItem);
            jobAndTriggerView1.TriggerName = viewModel.oldJobAndTrigger.Name;
            jobAndTriggerView1.JobName = viewModel.oldJobAndTrigger.JobName;
            jobAndTriggerView1.JobMessage = viewModel.oldJobAndTrigger.Message;
            jobAndTriggerView1.CronExpressionManual = viewModel.oldJobAndTrigger.CronExpression;
            jobAndTriggerView1.MailBody = viewModel.oldJobAndTrigger.MailBody;
            jobAndTriggerView1.MailSubject = viewModel.oldJobAndTrigger.MailSubject;
            jobAndTriggerView1.JobTypes = Enum.GetValues(typeof(Enumerations.MaintenanceJobType));
            jobAndTriggerView1.SelectedJobType = viewModel.oldJobAndTrigger.SelectedJobType;
        }
    }

    public interface IJobsAndTriggersViewModel
    {
        event EventHandler UpdateTrigersDgv;
        BindingList<ITriggerViewModel> Triggers { get; set; }
        IAddMaintenanceSchedulerViewModel viewModel { get; set; }
        ITriggerViewModel JobAndTriggerToUpdate { get; set; }
        ITriggerViewModel oldJobAndTrigger { get; set; }

        /// <summary>
        /// Removes job from the database 
        /// </summary>
        /// <param name="jobName"></param>
        void RemoveJob(string jobName);

        /// <summary>
        /// Updates and reschedules old trigger with new one
        /// </summary>
        /// <param name="oldTriggerName"></param>
        /// <param name="newTriggerName"></param>
        /// <param name="cronExpression"></param>
        /// <param name="startDate"></param>
        /// <returns></returns>
        bool UpdateTrigger(string oldTriggerName, string newTriggerName, string cronExpression, DateTimeOffset startDate);

        /// <summary>
        /// Updates existing job
        /// </summary>
        /// <param name="jobName"></param>
        /// <param name="message"></param>
        void UpdateJob(string jobName, string message, Enumerations.MaintenanceJobType jobType, string jobMailSubject = "", string jobMailBody = "");

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
