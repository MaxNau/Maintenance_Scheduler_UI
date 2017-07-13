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
        public JobsAndTriggersTestForm()
        {
            InitializeComponent();
            jobsAndTriggersView1.IntitializeViewModel(new JobsAndTriggersViewModel());
        }
    }
}
