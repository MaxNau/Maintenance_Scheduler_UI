using BrightIdeasSoftware;
using Maintenance_Scheduler_UI.ViewModels;
using System.Windows.Forms;

namespace Maintenance_Scheduler_UI.TestForms
{
    public partial class JobsAndTriggersTestForm : Form
    {
        IJobsAndTriggersViewModel viewModel;

        public JobsAndTriggersTestForm()
        {
            InitializeComponent();  
            viewModel = new JobsAndTriggersViewModel();
            jobsAndTriggersView1.IntitializeViewModel(viewModel, new AddMaintenanceSchedulerViewModel());

        }

        private void objectListView1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            var selectedItem = (TriggerViewModel)((sender as ObjectListView).SelectedObject);
        }
    }
}
