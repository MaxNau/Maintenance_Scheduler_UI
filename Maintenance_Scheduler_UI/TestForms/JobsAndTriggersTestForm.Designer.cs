namespace Maintenance_Scheduler_UI.TestForms
{
    partial class JobsAndTriggersTestForm
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
            this.jobsAndTriggersView1 = new Maintenance_Scheduler_UI.JobsAndTriggersView();
            this.objectListView1 = new BrightIdeasSoftware.ObjectListView();
            this.jobNameColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.jobMessageColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.mailSubjectColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.mailBodyColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.triggerNameColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.cronExpressionColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.startDateColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).BeginInit();
            this.SuspendLayout();
            // 
            // jobsAndTriggersView1
            // 
            this.jobsAndTriggersView1.AutoScroll = true;
            this.jobsAndTriggersView1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.jobsAndTriggersView1.Location = new System.Drawing.Point(0, 0);
            this.jobsAndTriggersView1.Name = "jobsAndTriggersView1";
            this.jobsAndTriggersView1.Size = new System.Drawing.Size(470, 284);
            this.jobsAndTriggersView1.TabIndex = 0;
            // 
            // objectListView1
            // 
            this.objectListView1.AllColumns.Add(this.jobNameColumn);
            this.objectListView1.AllColumns.Add(this.jobMessageColumn);
            this.objectListView1.AllColumns.Add(this.mailSubjectColumn);
            this.objectListView1.AllColumns.Add(this.mailBodyColumn);
            this.objectListView1.AllColumns.Add(this.triggerNameColumn);
            this.objectListView1.AllColumns.Add(this.cronExpressionColumn);
            this.objectListView1.AllColumns.Add(this.startDateColumn);
            this.objectListView1.CellEditUseWholeCell = false;
            this.objectListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.jobNameColumn,
            this.jobMessageColumn,
            this.mailSubjectColumn,
            this.mailBodyColumn,
            this.triggerNameColumn,
            this.cronExpressionColumn,
            this.startDateColumn});
            this.objectListView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.objectListView1.FullRowSelect = true;
            this.objectListView1.Location = new System.Drawing.Point(26, 302);
            this.objectListView1.Name = "objectListView1";
            this.objectListView1.Size = new System.Drawing.Size(601, 97);
            this.objectListView1.TabIndex = 1;
            this.objectListView1.UseCompatibleStateImageBehavior = false;
            this.objectListView1.View = System.Windows.Forms.View.Details;
            // 
            // jobNameColumn
            // 
            this.jobNameColumn.AspectName = "JobName";
            this.jobNameColumn.Text = "Job Name";
            this.jobNameColumn.Width = 100;
            // 
            // jobMessageColumn
            // 
            this.jobMessageColumn.AspectName = "Message";
            this.jobMessageColumn.Text = "Job Message";
            this.jobMessageColumn.Width = 200;
            this.jobMessageColumn.WordWrap = true;
            // 
            // mailSubjectColumn
            // 
            this.mailSubjectColumn.AspectName = "MailSubject";
            this.mailSubjectColumn.Text = "Mail subject";
            this.mailSubjectColumn.Width = 71;
            // 
            // mailBodyColumn
            // 
            this.mailBodyColumn.AspectName = "MailBody";
            this.mailBodyColumn.Text = "Mail body";
            this.mailBodyColumn.Width = 200;
            // 
            // triggerNameColumn
            // 
            this.triggerNameColumn.AspectName = "Name";
            this.triggerNameColumn.Text = "Trigger Name";
            // 
            // cronExpressionColumn
            // 
            this.cronExpressionColumn.AspectName = "CronExpression";
            this.cronExpressionColumn.Text = "Cron expression";
            this.cronExpressionColumn.Width = 80;
            // 
            // startDateColumn
            // 
            this.startDateColumn.AspectName = "StartTimeDate";
            this.startDateColumn.AspectToStringFormat = "{0:d/M/yyyy HH:mm:ss}";
            this.startDateColumn.Text = "Start date";
            // 
            // JobsAndTriggersTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 516);
            this.Controls.Add(this.objectListView1);
            this.Controls.Add(this.jobsAndTriggersView1);
            this.Name = "JobsAndTriggersTestForm";
            this.Text = "JobsAndTriggersTestForm";
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private JobsAndTriggersView jobsAndTriggersView1;
        private BrightIdeasSoftware.ObjectListView objectListView1;
        private BrightIdeasSoftware.OLVColumn jobNameColumn;
        private BrightIdeasSoftware.OLVColumn jobMessageColumn;
        private BrightIdeasSoftware.OLVColumn mailSubjectColumn;
        private BrightIdeasSoftware.OLVColumn mailBodyColumn;
        private BrightIdeasSoftware.OLVColumn triggerNameColumn;
        private BrightIdeasSoftware.OLVColumn cronExpressionColumn;
        private BrightIdeasSoftware.OLVColumn startDateColumn;
    }
}