using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Maintenance_Scheduler_BAL;
using Maintenance_Scheduler_UI.ViewModels;
using Maintenance_Scheduler_DAL.DataAccess.DTOs;

namespace Maintenance_Scheduler_UI
{
    public partial class JobsAndTriggersView : UserControl
    {
        JobsAndTriggersViewModel viewModel;
        public JobsAndTriggersView()
        {
            InitializeComponent();
            viewModel = new JobsAndTriggersViewModel();
        }

        private void JobsAndTriggersView_Load(object sender, EventArgs e)
        {
            triggersDgv.DataSource = viewModel.Triggers;
        }

        private void triggersDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedTrigger = (TriggerDTO)((sender as DataGridView).CurrentRow.DataBoundItem);
            MaintanceScheduler.RemoveJob(selectedTrigger.JobName);
        }
    }
}
