using BrightIdeasSoftware;
using Maintenance_Scheduler_UI.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            objectListView1.SetObjects(viewModel.Triggers);
            objectListView1.RebuildColumns();
        }
    }
}
