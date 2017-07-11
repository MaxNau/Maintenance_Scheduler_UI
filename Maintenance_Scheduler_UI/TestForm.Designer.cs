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
            this.showJobsAndTriggersInfoBtn = new System.Windows.Forms.Button();
            this.addMaintenanceScheduleView1 = new Maintenance_Scheduler_UI.AddMaintenanceScheduleView();
            this.SuspendLayout();
            // 
            // maintanceMessager1
            // 
            this.maintanceMessager1.Location = new System.Drawing.Point(18, 12);
            this.maintanceMessager1.Name = "maintanceMessager1";
            this.maintanceMessager1.Size = new System.Drawing.Size(304, 46);
            this.maintanceMessager1.TabIndex = 0;
            // 
            // showJobsAndTriggersInfoBtn
            // 
            this.showJobsAndTriggersInfoBtn.Location = new System.Drawing.Point(18, 274);
            this.showJobsAndTriggersInfoBtn.Name = "showJobsAndTriggersInfoBtn";
            this.showJobsAndTriggersInfoBtn.Size = new System.Drawing.Size(133, 23);
            this.showJobsAndTriggersInfoBtn.TabIndex = 2;
            this.showJobsAndTriggersInfoBtn.Text = "View jobs and triggers";
            this.showJobsAndTriggersInfoBtn.UseVisualStyleBackColor = true;
            this.showJobsAndTriggersInfoBtn.Click += new System.EventHandler(this.showJobsAndTriggersInfoBtn_Click);
            // 
            // addMaintenanceScheduleView1
            // 
            this.addMaintenanceScheduleView1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addMaintenanceScheduleView1.Location = new System.Drawing.Point(18, 107);
            this.addMaintenanceScheduleView1.Name = "addMaintenanceScheduleView1";
            this.addMaintenanceScheduleView1.Size = new System.Drawing.Size(757, 134);
            this.addMaintenanceScheduleView1.TabIndex = 3;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 400);
            this.Controls.Add(this.addMaintenanceScheduleView1);
            this.Controls.Add(this.showJobsAndTriggersInfoBtn);
            this.Controls.Add(this.maintanceMessager1);
            this.Name = "TestForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MaintanceMessager maintanceMessager1;
        private System.Windows.Forms.Button showJobsAndTriggersInfoBtn;
        private AddMaintenanceScheduleView addMaintenanceScheduleView1;
    }
}

