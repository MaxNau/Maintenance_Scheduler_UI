namespace Maintenance_Scheduler_UI
{
    partial class TestForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.maintanceMessager1 = new Maintenance_Scheduler_UI.MaintanceMessager();
            this.addMaintenanceScheduleView1 = new Maintenance_Scheduler_UI.AddMaintenanceScheduleView();
            this.jobsAndTriggersView1 = new Maintenance_Scheduler_UI.JobsAndTriggersView();
            this.SuspendLayout();
            // 
            // maintanceMessager1
            // 
            this.maintanceMessager1.Location = new System.Drawing.Point(18, 12);
            this.maintanceMessager1.Name = "maintanceMessager1";
            this.maintanceMessager1.Size = new System.Drawing.Size(304, 46);
            this.maintanceMessager1.TabIndex = 0;
            // 
            // addMaintenanceScheduleView1
            // 
            this.addMaintenanceScheduleView1.Location = new System.Drawing.Point(33, 64);
            this.addMaintenanceScheduleView1.Name = "addMaintenanceScheduleView1";
            this.addMaintenanceScheduleView1.Size = new System.Drawing.Size(332, 255);
            this.addMaintenanceScheduleView1.TabIndex = 1;
            // 
            // jobsAndTriggersView1
            // 
            this.jobsAndTriggersView1.Location = new System.Drawing.Point(371, 31);
            this.jobsAndTriggersView1.Name = "jobsAndTriggersView1";
            this.jobsAndTriggersView1.Size = new System.Drawing.Size(414, 300);
            this.jobsAndTriggersView1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 400);
            this.Controls.Add(this.jobsAndTriggersView1);
            this.Controls.Add(this.addMaintenanceScheduleView1);
            this.Controls.Add(this.maintanceMessager1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MaintanceMessager maintanceMessager1;
        private AddMaintenanceScheduleView addMaintenanceScheduleView1;
        private JobsAndTriggersView jobsAndTriggersView1;
    }
}

