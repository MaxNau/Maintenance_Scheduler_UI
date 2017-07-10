﻿namespace Maintenance_Scheduler_UI
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
            this.jobMessageLb = new System.Windows.Forms.Label();
            this.jobNameLb = new System.Windows.Forms.Label();
            this.triggerNameLb = new System.Windows.Forms.Label();
            this.jobNameTb = new System.Windows.Forms.TextBox();
            this.triggerNameTb = new System.Windows.Forms.TextBox();
            this.addTriggerBtn = new System.Windows.Forms.Button();
            this.jobMessageTb = new System.Windows.Forms.TextBox();
            this.viewHolder = new System.Windows.Forms.TableLayoutPanel();
            this.cronExpressionLb = new System.Windows.Forms.Label();
            this.cronExpressionTb = new System.Windows.Forms.TextBox();
            this.viewHolder.SuspendLayout();
            this.SuspendLayout();
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
            this.triggerNameLb.Location = new System.Drawing.Point(3, 52);
            this.triggerNameLb.Name = "triggerNameLb";
            this.triggerNameLb.Size = new System.Drawing.Size(71, 13);
            this.triggerNameLb.TabIndex = 1;
            this.triggerNameLb.Text = "Trigger Name";
            // 
            // jobNameTb
            // 
            this.jobNameTb.Location = new System.Drawing.Point(102, 3);
            this.jobNameTb.Name = "jobNameTb";
            this.jobNameTb.Size = new System.Drawing.Size(100, 20);
            this.jobNameTb.TabIndex = 10;
            // 
            // triggerNameTb
            // 
            this.triggerNameTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.triggerNameTb.Location = new System.Drawing.Point(102, 55);
            this.triggerNameTb.Name = "triggerNameTb";
            this.triggerNameTb.Size = new System.Drawing.Size(227, 20);
            this.triggerNameTb.TabIndex = 2;
            // 
            // addTriggerBtn
            // 
            this.addTriggerBtn.Location = new System.Drawing.Point(102, 175);
            this.addTriggerBtn.Name = "addTriggerBtn";
            this.addTriggerBtn.Size = new System.Drawing.Size(75, 23);
            this.addTriggerBtn.TabIndex = 7;
            this.addTriggerBtn.Text = "Add";
            this.addTriggerBtn.UseVisualStyleBackColor = true;
            this.addTriggerBtn.Click += new System.EventHandler(this.addTriggerBtn_Click);
            // 
            // jobMessageTb
            // 
            this.jobMessageTb.Location = new System.Drawing.Point(102, 29);
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
            this.viewHolder.Controls.Add(this.triggerNameTb, 1, 3);
            this.viewHolder.Controls.Add(this.jobNameTb, 1, 0);
            this.viewHolder.Controls.Add(this.triggerNameLb, 0, 3);
            this.viewHolder.Controls.Add(this.jobNameLb, 0, 0);
            this.viewHolder.Controls.Add(this.jobMessageLb, 0, 1);
            this.viewHolder.Controls.Add(this.cronExpressionLb, 0, 4);
            this.viewHolder.Controls.Add(this.cronExpressionTb, 1, 4);
            this.viewHolder.Controls.Add(this.addTriggerBtn, 1, 6);
            this.viewHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewHolder.Location = new System.Drawing.Point(0, 0);
            this.viewHolder.Name = "viewHolder";
            this.viewHolder.RowCount = 9;
            this.viewHolder.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.viewHolder.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.viewHolder.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.viewHolder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.viewHolder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.viewHolder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.viewHolder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.viewHolder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.viewHolder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.viewHolder.Size = new System.Drawing.Size(332, 255);
            this.viewHolder.TabIndex = 0;
            // 
            // cronExpressionLb
            // 
            this.cronExpressionLb.AutoSize = true;
            this.cronExpressionLb.Location = new System.Drawing.Point(3, 92);
            this.cronExpressionLb.Name = "cronExpressionLb";
            this.cronExpressionLb.Size = new System.Drawing.Size(82, 13);
            this.cronExpressionLb.TabIndex = 15;
            this.cronExpressionLb.Text = "Cron expression";
            // 
            // cronExpressionTb
            // 
            this.cronExpressionTb.Location = new System.Drawing.Point(102, 95);
            this.cronExpressionTb.Name = "cronExpressionTb";
            this.cronExpressionTb.Size = new System.Drawing.Size(100, 20);
            this.cronExpressionTb.TabIndex = 16;
            // 
            // AddMaintenanceScheduleView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.viewHolder);
            this.Name = "AddMaintenanceScheduleView";
            this.Size = new System.Drawing.Size(332, 255);
            this.viewHolder.ResumeLayout(false);
            this.viewHolder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label jobMessageLb;
        private System.Windows.Forms.Label jobNameLb;
        private System.Windows.Forms.Label triggerNameLb;
        private System.Windows.Forms.TextBox jobNameTb;
        private System.Windows.Forms.TextBox triggerNameTb;
        private System.Windows.Forms.Button addTriggerBtn;
        private System.Windows.Forms.TextBox jobMessageTb;
        private System.Windows.Forms.TableLayoutPanel viewHolder;
        private System.Windows.Forms.Label cronExpressionLb;
        private System.Windows.Forms.TextBox cronExpressionTb;
    }
}