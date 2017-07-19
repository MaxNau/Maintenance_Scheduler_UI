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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.showJobsAndTriggersInfoBtn = new System.Windows.Forms.Button();
            this.addMaintenanceScheduleViewE1 = new Maintenance_Scheduler_UI.AddMaintenanceSchedulerView();
            this.viewLogsBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.showJobsAndTriggersInfoBtn, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.addMaintenanceScheduleViewE1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.viewLogsBtn, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(787, 400);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // showJobsAndTriggersInfoBtn
            // 
            this.showJobsAndTriggersInfoBtn.Location = new System.Drawing.Point(3, 335);
            this.showJobsAndTriggersInfoBtn.Name = "showJobsAndTriggersInfoBtn";
            this.showJobsAndTriggersInfoBtn.Size = new System.Drawing.Size(133, 23);
            this.showJobsAndTriggersInfoBtn.TabIndex = 5;
            this.showJobsAndTriggersInfoBtn.Text = "View jobs and triggers";
            this.showJobsAndTriggersInfoBtn.UseVisualStyleBackColor = true;
            this.showJobsAndTriggersInfoBtn.Click += new System.EventHandler(this.showJobsAndTriggersInfoBtn_Click);
            // 
            // addMaintenanceScheduleViewE1
            // 
            this.addMaintenanceScheduleViewE1.AutoScroll = true;
            this.addMaintenanceScheduleViewE1.AutoSize = true;
            this.addMaintenanceScheduleViewE1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addMaintenanceScheduleViewE1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addMaintenanceScheduleViewE1.Location = new System.Drawing.Point(3, 58);
            this.addMaintenanceScheduleViewE1.Name = "addMaintenanceScheduleViewE1";
            this.addMaintenanceScheduleViewE1.Size = new System.Drawing.Size(781, 271);
            this.addMaintenanceScheduleViewE1.TabIndex = 8;
            // 
            // viewLogsBtn
            // 
            this.viewLogsBtn.Location = new System.Drawing.Point(3, 372);
            this.viewLogsBtn.Name = "viewLogsBtn";
            this.viewLogsBtn.Size = new System.Drawing.Size(75, 23);
            this.viewLogsBtn.TabIndex = 9;
            this.viewLogsBtn.Text = "View logs";
            this.viewLogsBtn.UseVisualStyleBackColor = true;
            this.viewLogsBtn.Click += new System.EventHandler(this.viewLogsBtn_Click);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 400);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "TestForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button showJobsAndTriggersInfoBtn;
        private AddMaintenanceSchedulerView addMaintenanceScheduleViewE1;
        private System.Windows.Forms.Button viewLogsBtn;
    }
}

