﻿using Maintenance_Scheduler_BAL;
using Maintenance_Scheduler_BAL.SchedulerJobs;
using Maintenance_Scheduler_DAL.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maintenance_Scheduler_UI
{
    public partial class TestForm : Form
    { 

        public TestForm()
        {
            
            InitializeComponent();
            MaintanceScheduler.Start();
            MaintenanceJob.JobDone += ReplaceFanucBatteries_JobDone;
        }

        private void ReplaceFanucBatteries_JobDone(object sender, EventArgs e)
        {
            Invoke((MethodInvoker)delegate
            {
                Messanger messanger = new Messanger(sender as string);
                messanger.ShowDialog();
            });
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
