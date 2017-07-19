using Maintenance_Scheduler_UI.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maintenance_Scheduler_UI.TestForms
{
    public partial class LogsTestForm : Form
    {
        private LogsViewModel viewModel;

        public LogsTestForm()
        {
            InitializeComponent();
            viewModel = new LogsViewModel();
            logsDgv.DataSource = viewModel.Logs;
        }
    }
}
