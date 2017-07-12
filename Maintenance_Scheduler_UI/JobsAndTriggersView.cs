using System;
using System.Windows.Forms;
using Maintenance_Scheduler_UI.ViewModels;
using Maintenance_Scheduler_DAL.DataAccess.DTOs;

namespace Maintenance_Scheduler_UI
{
    public partial class JobsAndTriggersView : UserControl
    {
        JobsAndTriggersViewModel viewModel;
        public JobsAndTriggersView()
        {
            viewModel = new JobsAndTriggersViewModel();
            InitializeComponent();
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
}
