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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.triggersDgv = new System.Windows.Forms.DataGridView();
            this.jobAndTriggerView1 = new MaintenanceSchedulerControlLibrary.JobAndTriggerView();
            this.removeJobTriggerButton = new System.Windows.Forms.Button();
            this.updateJobTriggerBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.triggersDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.triggersDgv, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.jobAndTriggerView1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.removeJobTriggerButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.updateJobTriggerBtn, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(459, 600);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // triggersDgv
            // 
            this.triggersDgv.AllowUserToAddRows = false;
            this.triggersDgv.AllowUserToDeleteRows = false;
            this.triggersDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.triggersDgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.triggersDgv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.triggersDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.triggersDgv.DefaultCellStyle = dataGridViewCellStyle1;
            this.triggersDgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.triggersDgv.Location = new System.Drawing.Point(3, 3);
            this.triggersDgv.Name = "triggersDgv";
            this.triggersDgv.ReadOnly = true;
            this.triggersDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.triggersDgv.Size = new System.Drawing.Size(453, 210);
            this.triggersDgv.TabIndex = 0;
            this.triggersDgv.DataSourceChanged += new System.EventHandler(this.triggersDgv_DataSourceChanged);
            this.triggersDgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.triggersDgv_CellClick);
            this.triggersDgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.triggersDgv_CellContentClick);
            // 
            // jobAndTriggerView1
            // 
            this.jobAndTriggerView1.AutoScroll = true;
            this.jobAndTriggerView1.CronExpression = "";
            this.jobAndTriggerView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.jobAndTriggerView1.JobMessage = "";
            this.jobAndTriggerView1.JobName = "";
            this.jobAndTriggerView1.JobTypes = null;
            this.jobAndTriggerView1.Location = new System.Drawing.Point(3, 219);
            this.jobAndTriggerView1.MailBody = "";
            this.jobAndTriggerView1.MailSubject = "";
            this.jobAndTriggerView1.Name = "jobAndTriggerView1";
            this.jobAndTriggerView1.Size = new System.Drawing.Size(453, 318);
            this.jobAndTriggerView1.TabIndex = 1;
            this.jobAndTriggerView1.TriggerName = "";
            // 
            // removeJobTriggerButton
            // 
            this.removeJobTriggerButton.Location = new System.Drawing.Point(3, 543);
            this.removeJobTriggerButton.Name = "removeJobTriggerButton";
            this.removeJobTriggerButton.Size = new System.Drawing.Size(75, 23);
            this.removeJobTriggerButton.TabIndex = 2;
            this.removeJobTriggerButton.Text = "Remove";
            this.removeJobTriggerButton.UseVisualStyleBackColor = true;
            this.removeJobTriggerButton.Click += new System.EventHandler(this.removeJobTriggerButton_Click);
            // 
            // updateJobTriggerBtn
            // 
            this.updateJobTriggerBtn.Location = new System.Drawing.Point(3, 573);
            this.updateJobTriggerBtn.Name = "updateJobTriggerBtn";
            this.updateJobTriggerBtn.Size = new System.Drawing.Size(75, 23);
            this.updateJobTriggerBtn.TabIndex = 3;
            this.updateJobTriggerBtn.Text = "Update";
            this.updateJobTriggerBtn.UseVisualStyleBackColor = true;
            // 
            // JobsAndTriggersView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "JobsAndTriggersView";
            this.Size = new System.Drawing.Size(459, 600);
            this.Load += new System.EventHandler(this.JobsAndTriggersView_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.triggersDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView triggersDgv;
        private MaintenanceSchedulerControlLibrary.JobAndTriggerView jobAndTriggerView1;
        private System.Windows.Forms.Button removeJobTriggerButton;
        private System.Windows.Forms.Button updateJobTriggerBtn;
    }
}
