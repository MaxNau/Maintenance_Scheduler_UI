namespace Maintenance_Scheduler_UI
{
    partial class JobsAndTriggersView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.triggersDgv = new System.Windows.Forms.DataGridView();
            this.jobAndTriggerView1 = new MaintenanceSchedulerControlLibrary.JobAndTriggerView();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.triggersDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.triggersDgv, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.jobAndTriggerView1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(459, 500);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // triggersDgv
            // 
            this.triggersDgv.AllowUserToAddRows = false;
            this.triggersDgv.AllowUserToDeleteRows = false;
            this.triggersDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.triggersDgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.triggersDgv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.triggersDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.triggersDgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.triggersDgv.Location = new System.Drawing.Point(3, 3);
            this.triggersDgv.Name = "triggersDgv";
            this.triggersDgv.ReadOnly = true;
            this.triggersDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.triggersDgv.Size = new System.Drawing.Size(453, 194);
            this.triggersDgv.TabIndex = 0;
            this.triggersDgv.DataSourceChanged += new System.EventHandler(this.triggersDgv_DataSourceChanged);
            this.triggersDgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.triggersDgv_CellClick);
            this.triggersDgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.triggersDgv_CellContentClick);
            // 
            // jobAndTriggerView1
            // 
            this.jobAndTriggerView1.CronExpression = "";
            this.jobAndTriggerView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.jobAndTriggerView1.JobAndTriggerViewButtonText = "Enter Text";
            this.jobAndTriggerView1.JobMessage = "";
            this.jobAndTriggerView1.JobName = "";
            this.jobAndTriggerView1.JobTypes = null;
            this.jobAndTriggerView1.Location = new System.Drawing.Point(3, 203);
            this.jobAndTriggerView1.MailBody = "";
            this.jobAndTriggerView1.MailSubject = "";
            this.jobAndTriggerView1.Name = "jobAndTriggerView1";
            this.jobAndTriggerView1.Size = new System.Drawing.Size(453, 294);
            this.jobAndTriggerView1.TabIndex = 1;
            this.jobAndTriggerView1.TriggerName = "";
            // 
            // JobsAndTriggersView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "JobsAndTriggersView";
            this.Size = new System.Drawing.Size(459, 500);
            this.Load += new System.EventHandler(this.JobsAndTriggersView_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.triggersDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView triggersDgv;
        private MaintenanceSchedulerControlLibrary.JobAndTriggerView jobAndTriggerView1;
    }
}
