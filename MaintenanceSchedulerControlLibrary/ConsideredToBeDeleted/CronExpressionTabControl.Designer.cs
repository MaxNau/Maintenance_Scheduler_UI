namespace MaintenanceSchedulerControlLibrary
{
    partial class CronExpressionTabControl
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
            this.cronTabControl = new System.Windows.Forms.TabControl();
            this.secondsTab = new System.Windows.Forms.TabPage();
            this.secondsCronURIPart = new MaintenanceSchedulerControlLibrary.CronURIPart();
            this.minutesTab = new System.Windows.Forms.TabPage();
            this.minutesCronURIPart = new MaintenanceSchedulerControlLibrary.CronURIPart();
            this.hoursTab = new System.Windows.Forms.TabPage();
            this.hoursCronURIPart = new MaintenanceSchedulerControlLibrary.CronURIPart();
            this.dayOfMonthTab = new System.Windows.Forms.TabPage();
            this.dayCronURIPart = new MaintenanceSchedulerControlLibrary.CronURIPart();
            this.monthTab = new System.Windows.Forms.TabPage();
            this.monthCronURIPart = new MaintenanceSchedulerControlLibrary.CronURIPart();
            this.yearTab = new System.Windows.Forms.TabPage();
            this.yearCronURIPart = new MaintenanceSchedulerControlLibrary.CronURIPart();
            this.cronTabControl.SuspendLayout();
            this.secondsTab.SuspendLayout();
            this.minutesTab.SuspendLayout();
            this.hoursTab.SuspendLayout();
            this.dayOfMonthTab.SuspendLayout();
            this.monthTab.SuspendLayout();
            this.yearTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // cronTabControl
            // 
            this.cronTabControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.cronTabControl.Controls.Add(this.secondsTab);
            this.cronTabControl.Controls.Add(this.minutesTab);
            this.cronTabControl.Controls.Add(this.hoursTab);
            this.cronTabControl.Controls.Add(this.dayOfMonthTab);
            this.cronTabControl.Controls.Add(this.monthTab);
            this.cronTabControl.Controls.Add(this.yearTab);
            this.cronTabControl.Location = new System.Drawing.Point(3, 3);
            this.cronTabControl.Multiline = true;
            this.cronTabControl.Name = "cronTabControl";
            this.cronTabControl.SelectedIndex = 0;
            this.cronTabControl.Size = new System.Drawing.Size(265, 434);
            this.cronTabControl.TabIndex = 2;
            // 
            // secondsTab
            // 
            this.secondsTab.Controls.Add(this.secondsCronURIPart);
            this.secondsTab.Location = new System.Drawing.Point(23, 4);
            this.secondsTab.Name = "secondsTab";
            this.secondsTab.Padding = new System.Windows.Forms.Padding(3);
            this.secondsTab.Size = new System.Drawing.Size(238, 426);
            this.secondsTab.TabIndex = 0;
            this.secondsTab.Text = "Seconds";
            this.secondsTab.UseVisualStyleBackColor = true;
            // 
            // secondsCronURIPart
            // 
            this.secondsCronURIPart.GroupBoxText = "Minutes";
            this.secondsCronURIPart.Location = new System.Drawing.Point(5, 6);
            this.secondsCronURIPart.Name = "secondsCronURIPart";
            this.secondsCronURIPart.Size = new System.Drawing.Size(227, 414);
            this.secondsCronURIPart.TabIndex = 0;
            // 
            // minutesTab
            // 
            this.minutesTab.Controls.Add(this.minutesCronURIPart);
            this.minutesTab.Location = new System.Drawing.Point(23, 4);
            this.minutesTab.Name = "minutesTab";
            this.minutesTab.Padding = new System.Windows.Forms.Padding(3);
            this.minutesTab.Size = new System.Drawing.Size(238, 426);
            this.minutesTab.TabIndex = 1;
            this.minutesTab.Text = "Minutes";
            this.minutesTab.UseVisualStyleBackColor = true;
            // 
            // minutesCronURIPart
            // 
            this.minutesCronURIPart.GroupBoxText = "Minutes";
            this.minutesCronURIPart.Location = new System.Drawing.Point(3, 6);
            this.minutesCronURIPart.Name = "minutesCronURIPart";
            this.minutesCronURIPart.Size = new System.Drawing.Size(229, 424);
            this.minutesCronURIPart.TabIndex = 0;
            // 
            // hoursTab
            // 
            this.hoursTab.Controls.Add(this.hoursCronURIPart);
            this.hoursTab.Location = new System.Drawing.Point(23, 4);
            this.hoursTab.Name = "hoursTab";
            this.hoursTab.Padding = new System.Windows.Forms.Padding(3);
            this.hoursTab.Size = new System.Drawing.Size(238, 426);
            this.hoursTab.TabIndex = 2;
            this.hoursTab.Text = "Hours";
            this.hoursTab.UseVisualStyleBackColor = true;
            // 
            // hoursCronURIPart
            // 
            this.hoursCronURIPart.GroupBoxText = "Minutes";
            this.hoursCronURIPart.Location = new System.Drawing.Point(6, 9);
            this.hoursCronURIPart.Name = "hoursCronURIPart";
            this.hoursCronURIPart.Size = new System.Drawing.Size(229, 411);
            this.hoursCronURIPart.TabIndex = 0;
            // 
            // dayOfMonthTab
            // 
            this.dayOfMonthTab.Controls.Add(this.dayCronURIPart);
            this.dayOfMonthTab.Location = new System.Drawing.Point(23, 4);
            this.dayOfMonthTab.Name = "dayOfMonthTab";
            this.dayOfMonthTab.Padding = new System.Windows.Forms.Padding(3);
            this.dayOfMonthTab.Size = new System.Drawing.Size(238, 426);
            this.dayOfMonthTab.TabIndex = 3;
            this.dayOfMonthTab.Text = "Day";
            this.dayOfMonthTab.UseVisualStyleBackColor = true;
            // 
            // dayCronURIPart
            // 
            this.dayCronURIPart.GroupBoxText = "Minutes";
            this.dayCronURIPart.Location = new System.Drawing.Point(6, 9);
            this.dayCronURIPart.Name = "dayCronURIPart";
            this.dayCronURIPart.Size = new System.Drawing.Size(226, 411);
            this.dayCronURIPart.TabIndex = 0;
            // 
            // monthTab
            // 
            this.monthTab.Controls.Add(this.monthCronURIPart);
            this.monthTab.Location = new System.Drawing.Point(23, 4);
            this.monthTab.Name = "monthTab";
            this.monthTab.Padding = new System.Windows.Forms.Padding(3);
            this.monthTab.Size = new System.Drawing.Size(238, 426);
            this.monthTab.TabIndex = 4;
            this.monthTab.Text = "Month";
            this.monthTab.UseVisualStyleBackColor = true;
            // 
            // monthCronURIPart
            // 
            this.monthCronURIPart.GroupBoxText = "Minutes";
            this.monthCronURIPart.Location = new System.Drawing.Point(6, 9);
            this.monthCronURIPart.Name = "monthCronURIPart";
            this.monthCronURIPart.Size = new System.Drawing.Size(229, 411);
            this.monthCronURIPart.TabIndex = 0;
            // 
            // yearTab
            // 
            this.yearTab.Controls.Add(this.yearCronURIPart);
            this.yearTab.Location = new System.Drawing.Point(23, 4);
            this.yearTab.Name = "yearTab";
            this.yearTab.Padding = new System.Windows.Forms.Padding(3);
            this.yearTab.Size = new System.Drawing.Size(238, 426);
            this.yearTab.TabIndex = 5;
            this.yearTab.Text = "Year";
            this.yearTab.UseVisualStyleBackColor = true;
            // 
            // yearCronURIPart
            // 
            this.yearCronURIPart.GroupBoxText = "Minutes";
            this.yearCronURIPart.Location = new System.Drawing.Point(7, 7);
            this.yearCronURIPart.Name = "yearCronURIPart";
            this.yearCronURIPart.Size = new System.Drawing.Size(225, 413);
            this.yearCronURIPart.TabIndex = 0;
            // 
            // CronExpressionTabControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cronTabControl);
            this.Name = "CronExpressionTabControl";
            this.Size = new System.Drawing.Size(271, 467);
            this.cronTabControl.ResumeLayout(false);
            this.secondsTab.ResumeLayout(false);
            this.minutesTab.ResumeLayout(false);
            this.hoursTab.ResumeLayout(false);
            this.dayOfMonthTab.ResumeLayout(false);
            this.monthTab.ResumeLayout(false);
            this.yearTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl cronTabControl;
        private System.Windows.Forms.TabPage secondsTab;
        private System.Windows.Forms.TabPage minutesTab;
        private System.Windows.Forms.TabPage hoursTab;
        private System.Windows.Forms.TabPage dayOfMonthTab;
        private System.Windows.Forms.TabPage monthTab;
        private System.Windows.Forms.TabPage yearTab;
        private CronURIPart secondsCronURIPart;
        private CronURIPart minutesCronURIPart;
        private CronURIPart hoursCronURIPart;
        private CronURIPart dayCronURIPart;
        private CronURIPart monthCronURIPart;
        private CronURIPart yearCronURIPart;
    }
}
