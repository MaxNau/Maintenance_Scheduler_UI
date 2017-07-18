namespace MaintenanceSchedulerControlLibrary
{
    partial class ExtendedCronURIEverySMHStartAtSpecTime
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
            this.timeIntervalValueCb = new System.Windows.Forms.ComboBox();
            this.timeIntervalCb = new System.Windows.Forms.ComboBox();
            this.secondsCb = new System.Windows.Forms.ComboBox();
            this.minutesCb = new System.Windows.Forms.ComboBox();
            this.hoursCb = new System.Windows.Forms.ComboBox();
            this.yearCb = new System.Windows.Forms.ComboBox();
            this.monthCb = new System.Windows.Forms.ComboBox();
            this.dayCb = new System.Windows.Forms.ComboBox();
            this.startingLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timeIntervalValueCb
            // 
            this.timeIntervalValueCb.FormattingEnabled = true;
            this.timeIntervalValueCb.Location = new System.Drawing.Point(10, 3);
            this.timeIntervalValueCb.Name = "timeIntervalValueCb";
            this.timeIntervalValueCb.Size = new System.Drawing.Size(72, 21);
            this.timeIntervalValueCb.TabIndex = 38;
            // 
            // timeIntervalCb
            // 
            this.timeIntervalCb.Enabled = false;
            this.timeIntervalCb.FormattingEnabled = true;
            this.timeIntervalCb.Location = new System.Drawing.Point(88, 3);
            this.timeIntervalCb.Name = "timeIntervalCb";
            this.timeIntervalCb.Size = new System.Drawing.Size(117, 21);
            this.timeIntervalCb.TabIndex = 37;
            this.timeIntervalCb.SelectedIndexChanged += new System.EventHandler(this.timeIntervalCb_SelectedIndexChanged);
            // 
            // secondsCb
            // 
            this.secondsCb.Enabled = false;
            this.secondsCb.FormattingEnabled = true;
            this.secondsCb.Location = new System.Drawing.Point(145, 68);
            this.secondsCb.Name = "secondsCb";
            this.secondsCb.Size = new System.Drawing.Size(40, 21);
            this.secondsCb.TabIndex = 36;
            // 
            // minutesCb
            // 
            this.minutesCb.Enabled = false;
            this.minutesCb.FormattingEnabled = true;
            this.minutesCb.Location = new System.Drawing.Point(96, 68);
            this.minutesCb.Name = "minutesCb";
            this.minutesCb.Size = new System.Drawing.Size(42, 21);
            this.minutesCb.TabIndex = 35;
            // 
            // hoursCb
            // 
            this.hoursCb.Enabled = false;
            this.hoursCb.FormattingEnabled = true;
            this.hoursCb.Location = new System.Drawing.Point(53, 68);
            this.hoursCb.Name = "hoursCb";
            this.hoursCb.Size = new System.Drawing.Size(37, 21);
            this.hoursCb.TabIndex = 34;
            // 
            // yearCb
            // 
            this.yearCb.Enabled = false;
            this.yearCb.FormattingEnabled = true;
            this.yearCb.Location = new System.Drawing.Point(144, 40);
            this.yearCb.Name = "yearCb";
            this.yearCb.Size = new System.Drawing.Size(61, 21);
            this.yearCb.TabIndex = 33;
            // 
            // monthCb
            // 
            this.monthCb.Enabled = false;
            this.monthCb.FormattingEnabled = true;
            this.monthCb.Location = new System.Drawing.Point(53, 40);
            this.monthCb.Name = "monthCb";
            this.monthCb.Size = new System.Drawing.Size(85, 21);
            this.monthCb.TabIndex = 32;
            // 
            // dayCb
            // 
            this.dayCb.Enabled = false;
            this.dayCb.FormattingEnabled = true;
            this.dayCb.Location = new System.Drawing.Point(10, 40);
            this.dayCb.Name = "dayCb";
            this.dayCb.Size = new System.Drawing.Size(37, 21);
            this.dayCb.TabIndex = 31;
            // 
            // startingLabel
            // 
            this.startingLabel.AutoSize = true;
            this.startingLabel.Location = new System.Drawing.Point(7, 24);
            this.startingLabel.Name = "startingLabel";
            this.startingLabel.Size = new System.Drawing.Size(43, 13);
            this.startingLabel.TabIndex = 30;
            this.startingLabel.Text = "Starting";
            // 
            // ExtendedCronURIEverySMHStartAtSpecTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.timeIntervalValueCb);
            this.Controls.Add(this.timeIntervalCb);
            this.Controls.Add(this.secondsCb);
            this.Controls.Add(this.minutesCb);
            this.Controls.Add(this.hoursCb);
            this.Controls.Add(this.yearCb);
            this.Controls.Add(this.monthCb);
            this.Controls.Add(this.dayCb);
            this.Controls.Add(this.startingLabel);
            this.Name = "ExtendedCronURIEverySMHStartAtSpecTime";
            this.Size = new System.Drawing.Size(216, 97);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox timeIntervalValueCb;
        public System.Windows.Forms.ComboBox timeIntervalCb;
        public System.Windows.Forms.ComboBox secondsCb;
        public System.Windows.Forms.ComboBox minutesCb;
        public System.Windows.Forms.ComboBox hoursCb;
        public System.Windows.Forms.ComboBox yearCb;
        public System.Windows.Forms.ComboBox monthCb;
        public System.Windows.Forms.ComboBox dayCb;
        private System.Windows.Forms.Label startingLabel;
    }
}
