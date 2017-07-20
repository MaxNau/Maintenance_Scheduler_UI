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

        private void logsDgv_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            logsDgv.Columns[0].FillWeight = 0.8f;
            logsDgv.Columns[1].FillWeight = 1.8f;
            logsDgv.Columns[2].FillWeight = 3.4f;
            logsDgv.Columns[3].FillWeight = 1f;
            logsDgv.Columns[4].FillWeight = 5f;
            logsDgv.Columns[5].FillWeight = 6f;
            logsDgv.Columns[6].FillWeight = 3.5f;
        }
    }
}
