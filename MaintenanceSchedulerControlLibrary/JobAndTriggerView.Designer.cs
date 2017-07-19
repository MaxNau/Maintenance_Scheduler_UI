using System;

namespace MaintenanceSchedulerControlLibrary
{
    partial class JobAndTriggerView
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
            this.viewHolder = new System.Windows.Forms.TableLayoutPanel();
            this.combinedCronURI1 = new MaintenanceSchedulerControlLibrary.CombinedCronURI();
            this.jobNameTb = new System.Windows.Forms.TextBox();
            this.updateTypePanel = new System.Windows.Forms.Panel();
            this.updateTriggerRbtn = new System.Windows.Forms.RadioButton();
            this.updateJobRbtn = new System.Windows.Forms.RadioButton();
            this.cronExpressionTb = new System.Windows.Forms.TextBox();
            this.jobTypeLb = new System.Windows.Forms.Label();
            this.cronExpressionLb = new System.Windows.Forms.Label();
            this.jobNameLb = new System.Windows.Forms.Label();
            this.mailSubjectLb = new System.Windows.Forms.Label();
            this.mailBody = new System.Windows.Forms.Label();
            this.mailSubjectTb = new System.Windows.Forms.TextBox();
            this.jobMessageLb = new System.Windows.Forms.Label();
            this.triggerNameTb = new System.Windows.Forms.TextBox();
            this.jobTypesCb = new System.Windows.Forms.ComboBox();
            this.jobMessageTb = new System.Windows.Forms.TextBox();
            this.mailBodyRtb = new System.Windows.Forms.RichTextBox();
            this.triggerNameLb = new System.Windows.Forms.Label();
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.updateButton = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.viewHolder.SuspendLayout();
            this.updateTypePanel.SuspendLayout();
            this.buttonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // viewHolder
            // 
            this.viewHolder.AutoSize = true;
            this.viewHolder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.viewHolder.ColumnCount = 2;
            this.viewHolder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.viewHolder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.viewHolder.Controls.Add(this.combinedCronURI1, 0, 8);
            this.viewHolder.Controls.Add(this.jobNameTb, 1, 0);
            this.viewHolder.Controls.Add(this.updateTypePanel, 0, 7);
            this.viewHolder.Controls.Add(this.cronExpressionTb, 1, 6);
            this.viewHolder.Controls.Add(this.jobTypeLb, 0, 2);
            this.viewHolder.Controls.Add(this.cronExpressionLb, 0, 6);
            this.viewHolder.Controls.Add(this.jobNameLb, 0, 0);
            this.viewHolder.Controls.Add(this.mailSubjectLb, 0, 3);
            this.viewHolder.Controls.Add(this.mailBody, 0, 4);
            this.viewHolder.Controls.Add(this.mailSubjectTb, 1, 3);
            this.viewHolder.Controls.Add(this.jobMessageLb, 0, 1);
            this.viewHolder.Controls.Add(this.triggerNameTb, 1, 5);
            this.viewHolder.Controls.Add(this.jobTypesCb, 1, 2);
            this.viewHolder.Controls.Add(this.jobMessageTb, 1, 1);
            this.viewHolder.Controls.Add(this.mailBodyRtb, 1, 4);
            this.viewHolder.Controls.Add(this.triggerNameLb, 0, 5);
            this.viewHolder.Controls.Add(this.buttonPanel, 0, 9);
            this.viewHolder.Dock = System.Windows.Forms.DockStyle.Top;
            this.viewHolder.Location = new System.Drawing.Point(0, 0);
            this.viewHolder.Name = "viewHolder";
            this.viewHolder.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.viewHolder.RowCount = 10;
            this.viewHolder.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.viewHolder.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.viewHolder.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.viewHolder.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.viewHolder.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.viewHolder.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.viewHolder.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.viewHolder.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.viewHolder.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.viewHolder.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.viewHolder.Size = new System.Drawing.Size(307, 584);
            this.viewHolder.TabIndex = 1;
            // 
            // combinedCronURI1
            // 
            this.viewHolder.SetColumnSpan(this.combinedCronURI1, 2);
            this.combinedCronURI1.Dock = System.Windows.Forms.DockStyle.Top;
            this.combinedCronURI1.Location = new System.Drawing.Point(3, 345);
            this.combinedCronURI1.Name = "combinedCronURI1";
            this.combinedCronURI1.Size = new System.Drawing.Size(271, 200);
            this.combinedCronURI1.TabIndex = 30;
            // 
            // jobNameTb
            // 
            this.jobNameTb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.jobNameTb.Location = new System.Drawing.Point(163, 3);
            this.jobNameTb.Name = "jobNameTb";
            this.jobNameTb.ReadOnly = true;
            this.jobNameTb.Size = new System.Drawing.Size(111, 20);
            this.jobNameTb.TabIndex = 10;
            // 
            // updateTypePanel
            // 
            this.updateTypePanel.AutoSize = true;
            this.viewHolder.SetColumnSpan(this.updateTypePanel, 2);
            this.updateTypePanel.Controls.Add(this.updateTriggerRbtn);
            this.updateTypePanel.Controls.Add(this.updateJobRbtn);
            this.updateTypePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updateTypePanel.Location = new System.Drawing.Point(3, 316);
            this.updateTypePanel.Name = "updateTypePanel";
            this.updateTypePanel.Size = new System.Drawing.Size(271, 23);
            this.updateTypePanel.TabIndex = 30;
            // 
            // updateTriggerRbtn
            // 
            this.updateTriggerRbtn.AutoSize = true;
            this.updateTriggerRbtn.Location = new System.Drawing.Point(187, 3);
            this.updateTriggerRbtn.Name = "updateTriggerRbtn";
            this.updateTriggerRbtn.Size = new System.Drawing.Size(92, 17);
            this.updateTriggerRbtn.TabIndex = 1;
            this.updateTriggerRbtn.Text = "Update trigger";
            this.updateTriggerRbtn.UseVisualStyleBackColor = true;
            this.updateTriggerRbtn.CheckedChanged += new System.EventHandler(this.updateJobeAndTriggerBtn_Click);
            // 
            // updateJobRbtn
            // 
            this.updateJobRbtn.AutoSize = true;
            this.updateJobRbtn.Checked = true;
            this.updateJobRbtn.Location = new System.Drawing.Point(95, 3);
            this.updateJobRbtn.Name = "updateJobRbtn";
            this.updateJobRbtn.Size = new System.Drawing.Size(77, 17);
            this.updateJobRbtn.TabIndex = 0;
            this.updateJobRbtn.TabStop = true;
            this.updateJobRbtn.Text = "Update job";
            this.updateJobRbtn.UseVisualStyleBackColor = true;
            this.updateJobRbtn.CheckedChanged += new System.EventHandler(this.rbtn_CheckedChanged);
            // 
            // cronExpressionTb
            // 
            this.cronExpressionTb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cronExpressionTb.Location = new System.Drawing.Point(163, 290);
            this.cronExpressionTb.Name = "cronExpressionTb";
            this.cronExpressionTb.ReadOnly = true;
            this.cronExpressionTb.Size = new System.Drawing.Size(111, 20);
            this.cronExpressionTb.TabIndex = 23;
            // 
            // jobTypeLb
            // 
            this.jobTypeLb.AutoSize = true;
            this.jobTypeLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.jobTypeLb.Location = new System.Drawing.Point(3, 52);
            this.jobTypeLb.Name = "jobTypeLb";
            this.jobTypeLb.Size = new System.Drawing.Size(70, 17);
            this.jobTypeLb.TabIndex = 18;
            this.jobTypeLb.Text = "Job type";
            // 
            // cronExpressionLb
            // 
            this.cronExpressionLb.AutoSize = true;
            this.cronExpressionLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cronExpressionLb.Location = new System.Drawing.Point(3, 287);
            this.cronExpressionLb.Name = "cronExpressionLb";
            this.cronExpressionLb.Size = new System.Drawing.Size(125, 17);
            this.cronExpressionLb.TabIndex = 15;
            this.cronExpressionLb.Text = "Cron expression";
            // 
            // jobNameLb
            // 
            this.jobNameLb.AutoSize = true;
            this.jobNameLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobNameLb.Location = new System.Drawing.Point(3, 0);
            this.jobNameLb.Name = "jobNameLb";
            this.jobNameLb.Size = new System.Drawing.Size(78, 17);
            this.jobNameLb.TabIndex = 11;
            this.jobNameLb.Text = "Job name";
            // 
            // mailSubjectLb
            // 
            this.mailSubjectLb.AutoSize = true;
            this.mailSubjectLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.mailSubjectLb.Location = new System.Drawing.Point(3, 79);
            this.mailSubjectLb.Name = "mailSubjectLb";
            this.mailSubjectLb.Size = new System.Drawing.Size(94, 17);
            this.mailSubjectLb.TabIndex = 24;
            this.mailSubjectLb.Text = "Mail subject";
            // 
            // mailBody
            // 
            this.mailBody.AutoSize = true;
            this.mailBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.mailBody.Location = new System.Drawing.Point(3, 105);
            this.mailBody.Name = "mailBody";
            this.mailBody.Size = new System.Drawing.Size(77, 17);
            this.mailBody.TabIndex = 26;
            this.mailBody.Text = "Mail body";
            // 
            // mailSubjectTb
            // 
            this.mailSubjectTb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mailSubjectTb.Location = new System.Drawing.Point(163, 82);
            this.mailSubjectTb.Name = "mailSubjectTb";
            this.mailSubjectTb.Size = new System.Drawing.Size(111, 20);
            this.mailSubjectTb.TabIndex = 25;
            // 
            // jobMessageLb
            // 
            this.jobMessageLb.AutoSize = true;
            this.jobMessageLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobMessageLb.Location = new System.Drawing.Point(3, 26);
            this.jobMessageLb.Name = "jobMessageLb";
            this.jobMessageLb.Size = new System.Drawing.Size(103, 17);
            this.jobMessageLb.TabIndex = 12;
            this.jobMessageLb.Text = "Job message";
            // 
            // triggerNameTb
            // 
            this.triggerNameTb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.triggerNameTb.Location = new System.Drawing.Point(163, 264);
            this.triggerNameTb.Name = "triggerNameTb";
            this.triggerNameTb.Size = new System.Drawing.Size(111, 20);
            this.triggerNameTb.TabIndex = 2;
            // 
            // jobTypesCb
            // 
            this.jobTypesCb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.jobTypesCb.Enabled = false;
            this.jobTypesCb.FormattingEnabled = true;
            this.jobTypesCb.Location = new System.Drawing.Point(163, 55);
            this.jobTypesCb.Name = "jobTypesCb";
            this.jobTypesCb.Size = new System.Drawing.Size(111, 21);
            this.jobTypesCb.TabIndex = 20;
            this.jobTypesCb.SelectedValueChanged += new System.EventHandler(this.jobTypesCb_SelectedValueChanged);
            // 
            // jobMessageTb
            // 
            this.jobMessageTb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.jobMessageTb.Location = new System.Drawing.Point(163, 29);
            this.jobMessageTb.Name = "jobMessageTb";
            this.jobMessageTb.Size = new System.Drawing.Size(111, 20);
            this.jobMessageTb.TabIndex = 9;
            // 
            // mailBodyRtb
            // 
            this.mailBodyRtb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mailBodyRtb.Location = new System.Drawing.Point(163, 108);
            this.mailBodyRtb.Name = "mailBodyRtb";
            this.mailBodyRtb.Size = new System.Drawing.Size(111, 150);
            this.mailBodyRtb.TabIndex = 27;
            this.mailBodyRtb.Text = "";
            // 
            // triggerNameLb
            // 
            this.triggerNameLb.AutoSize = true;
            this.triggerNameLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.triggerNameLb.Location = new System.Drawing.Point(3, 261);
            this.triggerNameLb.Name = "triggerNameLb";
            this.triggerNameLb.Size = new System.Drawing.Size(107, 17);
            this.triggerNameLb.TabIndex = 1;
            this.triggerNameLb.Text = "Trigger Name";
            // 
            // buttonPanel
            // 
            this.viewHolder.SetColumnSpan(this.buttonPanel, 2);
            this.buttonPanel.Controls.Add(this.updateButton);
            this.buttonPanel.Controls.Add(this.removeBtn);
            this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPanel.Location = new System.Drawing.Point(3, 551);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(271, 30);
            this.buttonPanel.TabIndex = 31;
            // 
            // updateButton
            // 
            this.updateButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.updateButton.Location = new System.Drawing.Point(96, 0);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(100, 30);
            this.updateButton.TabIndex = 1;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.removeBtn.Location = new System.Drawing.Point(196, 0);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(75, 30);
            this.removeBtn.TabIndex = 0;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // JobAndTriggerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.viewHolder);
            this.Name = "JobAndTriggerView";
            this.Size = new System.Drawing.Size(307, 288);
            this.viewHolder.ResumeLayout(false);
            this.viewHolder.PerformLayout();
            this.updateTypePanel.ResumeLayout(false);
            this.updateTypePanel.PerformLayout();
            this.buttonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel viewHolder;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Panel updateTypePanel;
        private System.Windows.Forms.RadioButton updateTriggerRbtn;
        private System.Windows.Forms.RadioButton updateJobRbtn;
        private CombinedCronURI combinedCronURI1;
        private System.Windows.Forms.TextBox cronExpressionTb;
        private System.Windows.Forms.Label jobTypeLb;
        private System.Windows.Forms.Label cronExpressionLb;
        private System.Windows.Forms.Label jobNameLb;
        private System.Windows.Forms.Label mailSubjectLb;
        private System.Windows.Forms.Label mailBody;
        private System.Windows.Forms.TextBox mailSubjectTb;
        private System.Windows.Forms.Label jobMessageLb;
        private System.Windows.Forms.TextBox triggerNameTb;
        private System.Windows.Forms.ComboBox jobTypesCb;
        private System.Windows.Forms.TextBox jobMessageTb;
        private System.Windows.Forms.RichTextBox mailBodyRtb;
        private System.Windows.Forms.Label triggerNameLb;
        private System.Windows.Forms.TextBox jobNameTb;
        private System.Windows.Forms.Panel buttonPanel;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button removeBtn;
    }
}
