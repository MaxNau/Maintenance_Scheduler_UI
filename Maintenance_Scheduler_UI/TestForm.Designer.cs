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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.viewLogsBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.showJobsAndTriggersInfoBtn, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.addMaintenanceScheduleViewE1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(787, 400);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // showJobsAndTriggersInfoBtn
            // 
            this.showJobsAndTriggersInfoBtn.Location = new System.Drawing.Point(3, 343);
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
            this.addMaintenanceScheduleViewE1.Location = new System.Drawing.Point(3, 3);
            this.addMaintenanceScheduleViewE1.Name = "addMaintenanceScheduleViewE1";
            this.addMaintenanceScheduleViewE1.Size = new System.Drawing.Size(781, 334);
            this.addMaintenanceScheduleViewE1.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.viewLogsBtn);
            this.panel1.Location = new System.Drawing.Point(3, 372);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(331, 25);
            this.panel1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.Location = new System.Drawing.Point(75, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 25);
            this.button1.TabIndex = 11;
            this.button1.Text = "Mailing settings";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // viewLogsBtn
            // 
            this.viewLogsBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.viewLogsBtn.Location = new System.Drawing.Point(0, 0);
            this.viewLogsBtn.Name = "viewLogsBtn";
            this.viewLogsBtn.Size = new System.Drawing.Size(75, 25);
            this.viewLogsBtn.TabIndex = 10;
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
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button showJobsAndTriggersInfoBtn;
        private AddMaintenanceSchedulerView addMaintenanceScheduleViewE1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button viewLogsBtn;
    }
}

