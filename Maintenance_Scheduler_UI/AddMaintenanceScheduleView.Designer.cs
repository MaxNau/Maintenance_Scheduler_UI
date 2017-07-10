namespace Maintenance_Scheduler_UI
{
    partial class AddMaintenanceScheduleView
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
            this.trigerStartTimeDtp = new System.Windows.Forms.DateTimePicker();
            this.jobMessageLb = new System.Windows.Forms.Label();
            this.jobNameLb = new System.Windows.Forms.Label();
            this.triggerNameLb = new System.Windows.Forms.Label();
            this.jobNameTb = new System.Windows.Forms.TextBox();
            this.triggerNameTb = new System.Windows.Forms.TextBox();
            this.triggerTypeLb = new System.Windows.Forms.Label();
            this.triggerTypeCb = new System.Windows.Forms.ComboBox();
            this.reapeatCountLb = new System.Windows.Forms.Label();
            this.repeatCountTb = new System.Windows.Forms.TextBox();
            this.addTriggerBtn = new System.Windows.Forms.Button();
            this.jobMessageTb = new System.Windows.Forms.TextBox();
            this.viewHolder = new System.Windows.Forms.TableLayoutPanel();
            this.triggerStartTimeLb = new System.Windows.Forms.Label();
            this.viewHolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // trigerStartTimeDtp
            // 
            this.trigerStartTimeDtp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trigerStartTimeDtp.Location = new System.Drawing.Point(98, 55);
            this.trigerStartTimeDtp.Name = "trigerStartTimeDtp";
            this.trigerStartTimeDtp.Size = new System.Drawing.Size(216, 20);
            this.trigerStartTimeDtp.TabIndex = 13;
            // 
            // jobMessageLb
            // 
            this.jobMessageLb.AutoSize = true;
            this.jobMessageLb.Location = new System.Drawing.Point(3, 26);
            this.jobMessageLb.Name = "jobMessageLb";
            this.jobMessageLb.Size = new System.Drawing.Size(69, 13);
            this.jobMessageLb.TabIndex = 12;
            this.jobMessageLb.Text = "Job message";
            // 
            // jobNameLb
            // 
            this.jobNameLb.AutoSize = true;
            this.jobNameLb.Location = new System.Drawing.Point(3, 0);
            this.jobNameLb.Name = "jobNameLb";
            this.jobNameLb.Size = new System.Drawing.Size(53, 13);
            this.jobNameLb.TabIndex = 11;
            this.jobNameLb.Text = "Job name";
            // 
            // triggerNameLb
            // 
            this.triggerNameLb.AutoSize = true;
            this.triggerNameLb.Location = new System.Drawing.Point(3, 78);
            this.triggerNameLb.Name = "triggerNameLb";
            this.triggerNameLb.Size = new System.Drawing.Size(71, 13);
            this.triggerNameLb.TabIndex = 1;
            this.triggerNameLb.Text = "Trigger Name";
            // 
            // jobNameTb
            // 
            this.jobNameTb.Location = new System.Drawing.Point(98, 3);
            this.jobNameTb.Name = "jobNameTb";
            this.jobNameTb.Size = new System.Drawing.Size(100, 20);
            this.jobNameTb.TabIndex = 10;
            // 
            // triggerNameTb
            // 
            this.triggerNameTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.triggerNameTb.Location = new System.Drawing.Point(98, 81);
            this.triggerNameTb.Name = "triggerNameTb";
            this.triggerNameTb.Size = new System.Drawing.Size(216, 20);
            this.triggerNameTb.TabIndex = 2;
            // 
            // triggerTypeLb
            // 
            this.triggerTypeLb.AutoSize = true;
            this.triggerTypeLb.Location = new System.Drawing.Point(3, 118);
            this.triggerTypeLb.Name = "triggerTypeLb";
            this.triggerTypeLb.Size = new System.Drawing.Size(63, 13);
            this.triggerTypeLb.TabIndex = 3;
            this.triggerTypeLb.Text = "Trigger type";
            // 
            // triggerTypeCb
            // 
            this.triggerTypeCb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.triggerTypeCb.FormattingEnabled = true;
            this.triggerTypeCb.Location = new System.Drawing.Point(98, 121);
            this.triggerTypeCb.Name = "triggerTypeCb";
            this.triggerTypeCb.Size = new System.Drawing.Size(216, 21);
            this.triggerTypeCb.TabIndex = 4;
            // 
            // reapeatCountLb
            // 
            this.reapeatCountLb.AutoSize = true;
            this.reapeatCountLb.Location = new System.Drawing.Point(3, 158);
            this.reapeatCountLb.Name = "reapeatCountLb";
            this.reapeatCountLb.Size = new System.Drawing.Size(73, 13);
            this.reapeatCountLb.TabIndex = 5;
            this.reapeatCountLb.Text = "Repeat Count";
            // 
            // repeatCountTb
            // 
            this.repeatCountTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.repeatCountTb.Location = new System.Drawing.Point(98, 161);
            this.repeatCountTb.Name = "repeatCountTb";
            this.repeatCountTb.Size = new System.Drawing.Size(216, 20);
            this.repeatCountTb.TabIndex = 6;
            // 
            // addTriggerBtn
            // 
            this.addTriggerBtn.Location = new System.Drawing.Point(98, 201);
            this.addTriggerBtn.Name = "addTriggerBtn";
            this.addTriggerBtn.Size = new System.Drawing.Size(75, 23);
            this.addTriggerBtn.TabIndex = 7;
            this.addTriggerBtn.Text = "Add";
            this.addTriggerBtn.UseVisualStyleBackColor = true;
            this.addTriggerBtn.Click += new System.EventHandler(this.addTriggerBtn_Click);
            // 
            // jobMessageTb
            // 
            this.jobMessageTb.Location = new System.Drawing.Point(98, 29);
            this.jobMessageTb.Name = "jobMessageTb";
            this.jobMessageTb.Size = new System.Drawing.Size(100, 20);
            this.jobMessageTb.TabIndex = 9;
            // 
            // viewHolder
            // 
            this.viewHolder.ColumnCount = 2;
            this.viewHolder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.viewHolder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.viewHolder.Controls.Add(this.jobMessageTb, 1, 1);
            this.viewHolder.Controls.Add(this.addTriggerBtn, 1, 6);
            this.viewHolder.Controls.Add(this.repeatCountTb, 1, 5);
            this.viewHolder.Controls.Add(this.reapeatCountLb, 0, 5);
            this.viewHolder.Controls.Add(this.triggerTypeCb, 1, 4);
            this.viewHolder.Controls.Add(this.triggerTypeLb, 0, 4);
            this.viewHolder.Controls.Add(this.triggerNameTb, 1, 3);
            this.viewHolder.Controls.Add(this.jobNameTb, 1, 0);
            this.viewHolder.Controls.Add(this.triggerNameLb, 0, 3);
            this.viewHolder.Controls.Add(this.jobNameLb, 0, 0);
            this.viewHolder.Controls.Add(this.jobMessageLb, 0, 1);
            this.viewHolder.Controls.Add(this.trigerStartTimeDtp, 1, 2);
            this.viewHolder.Controls.Add(this.triggerStartTimeLb, 0, 2);
            this.viewHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewHolder.Location = new System.Drawing.Point(0, 0);
            this.viewHolder.Name = "viewHolder";
            this.viewHolder.RowCount = 7;
            this.viewHolder.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.viewHolder.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.viewHolder.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.viewHolder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.viewHolder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.viewHolder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.viewHolder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.viewHolder.Size = new System.Drawing.Size(317, 232);
            this.viewHolder.TabIndex = 0;
            // 
            // triggerStartTimeLb
            // 
            this.triggerStartTimeLb.AutoSize = true;
            this.triggerStartTimeLb.Location = new System.Drawing.Point(3, 52);
            this.triggerStartTimeLb.Name = "triggerStartTimeLb";
            this.triggerStartTimeLb.Size = new System.Drawing.Size(85, 13);
            this.triggerStartTimeLb.TabIndex = 14;
            this.triggerStartTimeLb.Text = "Trigger start time";
            // 
            // AddMaintenanceScheduleView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.viewHolder);
            this.Name = "AddMaintenanceScheduleView";
            this.Size = new System.Drawing.Size(317, 232);
            this.viewHolder.ResumeLayout(false);
            this.viewHolder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker trigerStartTimeDtp;
        private System.Windows.Forms.Label jobMessageLb;
        private System.Windows.Forms.Label jobNameLb;
        private System.Windows.Forms.Label triggerNameLb;
        private System.Windows.Forms.TextBox jobNameTb;
        private System.Windows.Forms.TextBox triggerNameTb;
        private System.Windows.Forms.Label triggerTypeLb;
        private System.Windows.Forms.ComboBox triggerTypeCb;
        private System.Windows.Forms.Label reapeatCountLb;
        private System.Windows.Forms.TextBox repeatCountTb;
        private System.Windows.Forms.Button addTriggerBtn;
        private System.Windows.Forms.TextBox jobMessageTb;
        private System.Windows.Forms.TableLayoutPanel viewHolder;
        private System.Windows.Forms.Label triggerStartTimeLb;
    }
}
