﻿
using System;

namespace Maintenance_Scheduler_UI
{
    partial class AddMaintenanceSchedulerView
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
            this.jobMessageLb = new System.Windows.Forms.Label();
            this.jobNameLb = new System.Windows.Forms.Label();
            this.triggerNameLb = new System.Windows.Forms.Label();
            this.jobNameTb = new System.Windows.Forms.TextBox();
            this.triggerNameTb = new System.Windows.Forms.TextBox();
            this.jobMessageTb = new System.Windows.Forms.TextBox();
            this.viewHolder = new System.Windows.Forms.TableLayoutPanel();
            this.cronExpressionTb = new System.Windows.Forms.TextBox();
            this.addTriggerBtn = new System.Windows.Forms.Button();
            this.jobTypesCb = new System.Windows.Forms.ComboBox();
            this.jobTypeLb = new System.Windows.Forms.Label();
            this.cronExpressionLb = new System.Windows.Forms.Label();
            this.mailSubjectLb = new System.Windows.Forms.Label();
            this.mailSubjectTb = new System.Windows.Forms.TextBox();
            this.mailBody = new System.Windows.Forms.Label();
            this.mailBodyRtb = new System.Windows.Forms.RichTextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.combinedCronURI1 = new MaintenanceSchedulerControlLibrary.CombinedCronURI();
            this.viewHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
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
            // jobNameTb
            // 
            this.jobNameTb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.jobNameTb.Location = new System.Drawing.Point(163, 3);
            this.jobNameTb.Name = "jobNameTb";
            this.jobNameTb.Size = new System.Drawing.Size(101, 20);
            this.jobNameTb.TabIndex = 10;
            this.jobNameTb.Validating += new System.ComponentModel.CancelEventHandler(this.jobNameTb_Validating);
            // 
            // triggerNameTb
            // 
            this.triggerNameTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.triggerNameTb.Location = new System.Drawing.Point(163, 264);
            this.triggerNameTb.Name = "triggerNameTb";
            this.triggerNameTb.Size = new System.Drawing.Size(101, 20);
            this.triggerNameTb.TabIndex = 2;
            this.triggerNameTb.Validating += new System.ComponentModel.CancelEventHandler(this.triggerNameTb_Validating);
            // 
            // jobMessageTb
            // 
            this.jobMessageTb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.jobMessageTb.Location = new System.Drawing.Point(163, 29);
            this.jobMessageTb.Name = "jobMessageTb";
            this.jobMessageTb.Size = new System.Drawing.Size(101, 20);
            this.jobMessageTb.TabIndex = 9;
            this.jobMessageTb.Validating += new System.ComponentModel.CancelEventHandler(this.jobMessageTb_Validating);
            // 
            // viewHolder
            // 
            this.viewHolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewHolder.AutoSize = true;
            this.viewHolder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.viewHolder.ColumnCount = 2;
            this.viewHolder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.viewHolder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.viewHolder.Controls.Add(this.cronExpressionTb, 1, 6);
            this.viewHolder.Controls.Add(this.addTriggerBtn, 1, 7);
            this.viewHolder.Controls.Add(this.jobTypesCb, 1, 2);
            this.viewHolder.Controls.Add(this.jobMessageTb, 1, 1);
            this.viewHolder.Controls.Add(this.jobNameTb, 1, 0);
            this.viewHolder.Controls.Add(this.jobNameLb, 0, 0);
            this.viewHolder.Controls.Add(this.jobMessageLb, 0, 1);
            this.viewHolder.Controls.Add(this.jobTypeLb, 0, 2);
            this.viewHolder.Controls.Add(this.cronExpressionLb, 0, 6);
            this.viewHolder.Controls.Add(this.triggerNameLb, 0, 5);
            this.viewHolder.Controls.Add(this.triggerNameTb, 1, 5);
            this.viewHolder.Controls.Add(this.mailSubjectLb, 0, 3);
            this.viewHolder.Controls.Add(this.mailSubjectTb, 1, 3);
            this.viewHolder.Controls.Add(this.mailBody, 0, 4);
            this.viewHolder.Controls.Add(this.mailBodyRtb, 1, 4);
            this.viewHolder.Controls.Add(this.combinedCronURI1, 0, 8);
            this.viewHolder.Location = new System.Drawing.Point(0, 0);
            this.viewHolder.Name = "viewHolder";
            this.viewHolder.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.viewHolder.RowCount = 9;
            this.viewHolder.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.viewHolder.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.viewHolder.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.viewHolder.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.viewHolder.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.viewHolder.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.viewHolder.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.viewHolder.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.viewHolder.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.viewHolder.Size = new System.Drawing.Size(297, 529);
            this.viewHolder.TabIndex = 0;
            // 
            // cronExpressionTb
            // 
            this.cronExpressionTb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cronExpressionTb.Location = new System.Drawing.Point(163, 290);
            this.cronExpressionTb.Name = "cronExpressionTb";
            this.cronExpressionTb.Size = new System.Drawing.Size(101, 20);
            this.cronExpressionTb.TabIndex = 23;
            this.cronExpressionTb.Validating += new System.ComponentModel.CancelEventHandler(this.cronExpressionTb_Validating);
            // 
            // addTriggerBtn
            // 
            this.addTriggerBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.addTriggerBtn.Location = new System.Drawing.Point(189, 316);
            this.addTriggerBtn.Name = "addTriggerBtn";
            this.addTriggerBtn.Size = new System.Drawing.Size(75, 24);
            this.addTriggerBtn.TabIndex = 22;
            this.addTriggerBtn.Text = "Add";
            this.addTriggerBtn.UseVisualStyleBackColor = true;
            this.addTriggerBtn.Click += new System.EventHandler(this.addTriggerBtn_Click);
            // 
            // jobTypesCb
            // 
            this.jobTypesCb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.jobTypesCb.FormattingEnabled = true;
            this.jobTypesCb.Location = new System.Drawing.Point(163, 55);
            this.jobTypesCb.Name = "jobTypesCb";
            this.jobTypesCb.Size = new System.Drawing.Size(101, 21);
            this.jobTypesCb.TabIndex = 20;
            this.jobTypesCb.SelectedIndexChanged += new System.EventHandler(this.jobTypesCb_SelectedIndexChanged);
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
            // mailSubjectTb
            // 
            this.mailSubjectTb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mailSubjectTb.Location = new System.Drawing.Point(163, 82);
            this.mailSubjectTb.Name = "mailSubjectTb";
            this.mailSubjectTb.Size = new System.Drawing.Size(101, 20);
            this.mailSubjectTb.TabIndex = 25;
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
            // mailBodyRtb
            // 
            this.mailBodyRtb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mailBodyRtb.Location = new System.Drawing.Point(163, 108);
            this.mailBodyRtb.Name = "mailBodyRtb";
            this.mailBodyRtb.Size = new System.Drawing.Size(101, 150);
            this.mailBodyRtb.TabIndex = 27;
            this.mailBodyRtb.Text = "";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // combinedCronURI1
            // 
            this.viewHolder.SetColumnSpan(this.combinedCronURI1, 2);
            this.combinedCronURI1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.combinedCronURI1.Location = new System.Drawing.Point(3, 346);
            this.combinedCronURI1.Name = "combinedCronURI1";
            this.combinedCronURI1.Size = new System.Drawing.Size(261, 180);
            this.combinedCronURI1.TabIndex = 28;
            // 
            // AddMaintenanceSchedulerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.viewHolder);
            this.Name = "AddMaintenanceSchedulerView";
            this.Size = new System.Drawing.Size(297, 532);
            this.viewHolder.ResumeLayout(false);
            this.viewHolder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label jobMessageLb;
        private System.Windows.Forms.Label jobNameLb;
        private System.Windows.Forms.Label triggerNameLb;
        private System.Windows.Forms.TextBox jobNameTb;
        private System.Windows.Forms.TextBox triggerNameTb;
        private System.Windows.Forms.TextBox jobMessageTb;
        private System.Windows.Forms.TableLayoutPanel viewHolder;
        private System.Windows.Forms.Label cronExpressionLb;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label jobTypeLb;
        private System.Windows.Forms.TextBox cronExpressionTb;
        private System.Windows.Forms.Label mailSubjectLb;
        private System.Windows.Forms.TextBox mailSubjectTb;
        private System.Windows.Forms.Label mailBody;
        private System.Windows.Forms.RichTextBox mailBodyRtb;
        private System.Windows.Forms.ComboBox jobTypesCb;
        private System.Windows.Forms.Button addTriggerBtn;
        private MaintenanceSchedulerControlLibrary.CombinedCronURI combinedCronURI1;
    }
}
