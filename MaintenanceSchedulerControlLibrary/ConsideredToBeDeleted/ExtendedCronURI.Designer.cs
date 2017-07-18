namespace MaintenanceSchedulerControlLibrary
{
    partial class ExtendedCronURI
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
            this.secondsCb = new System.Windows.Forms.ComboBox();
            this.minutesCb = new System.Windows.Forms.ComboBox();
            this.hoursCb = new System.Windows.Forms.ComboBox();
            this.atLb = new System.Windows.Forms.Label();
            this.yearCb = new System.Windows.Forms.ComboBox();
            this.monthCb = new System.Windows.Forms.ComboBox();
            this.dayCb = new System.Windows.Forms.ComboBox();
            this.startingLabel = new System.Windows.Forms.Label();
            this.timeIntervalCb = new System.Windows.Forms.ComboBox();
            this.timeIntervalValueCb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // secondsCb
            // 
            this.secondsCb.Enabled = false;
            this.secondsCb.FormattingEnabled = true;
            this.secondsCb.Location = new System.Drawing.Point(148, 69);
            this.secondsCb.Name = "secondsCb";
            this.secondsCb.Size = new System.Drawing.Size(40, 21);
            this.secondsCb.TabIndex = 27;
            // 
            // minutesCb
            // 
            this.minutesCb.Enabled = false;
            this.minutesCb.FormattingEnabled = true;
            this.minutesCb.Location = new System.Drawing.Point(99, 69);
            this.minutesCb.Name = "minutesCb";
            this.minutesCb.Size = new System.Drawing.Size(42, 21);
            this.minutesCb.TabIndex = 26;
            // 
            // hoursCb
            // 
            this.hoursCb.Enabled = false;
            this.hoursCb.FormattingEnabled = true;
            this.hoursCb.Location = new System.Drawing.Point(56, 69);
            this.hoursCb.Name = "hoursCb";
            this.hoursCb.Size = new System.Drawing.Size(37, 21);
            this.hoursCb.TabIndex = 25;
            // 
            // atLb
            // 
            this.atLb.AutoSize = true;
            this.atLb.Location = new System.Drawing.Point(-21, 175);
            this.atLb.Name = "atLb";
            this.atLb.Size = new System.Drawing.Size(16, 13);
            this.atLb.TabIndex = 24;
            this.atLb.Text = "at";
            // 
            // yearCb
            // 
            this.yearCb.Enabled = false;
            this.yearCb.FormattingEnabled = true;
            this.yearCb.Location = new System.Drawing.Point(147, 41);
            this.yearCb.Name = "yearCb";
            this.yearCb.Size = new System.Drawing.Size(61, 21);
            this.yearCb.TabIndex = 23;
            // 
            // monthCb
            // 
            this.monthCb.Enabled = false;
            this.monthCb.FormattingEnabled = true;
            this.monthCb.Location = new System.Drawing.Point(56, 41);
            this.monthCb.Name = "monthCb";
            this.monthCb.Size = new System.Drawing.Size(85, 21);
            this.monthCb.TabIndex = 22;
            // 
            // dayCb
            // 
            this.dayCb.Enabled = false;
            this.dayCb.FormattingEnabled = true;
            this.dayCb.Location = new System.Drawing.Point(13, 41);
            this.dayCb.Name = "dayCb";
            this.dayCb.Size = new System.Drawing.Size(37, 21);
            this.dayCb.TabIndex = 21;
            // 
            // startingLabel
            // 
            this.startingLabel.AutoSize = true;
            this.startingLabel.Location = new System.Drawing.Point(10, 25);
            this.startingLabel.Name = "startingLabel";
            this.startingLabel.Size = new System.Drawing.Size(43, 13);
            this.startingLabel.TabIndex = 20;
            this.startingLabel.Text = "Starting";
            // 
            // timeIntervalCb
            // 
            this.timeIntervalCb.Enabled = false;
            this.timeIntervalCb.FormattingEnabled = true;
            this.timeIntervalCb.Location = new System.Drawing.Point(91, 4);
            this.timeIntervalCb.Name = "timeIntervalCb";
            this.timeIntervalCb.Size = new System.Drawing.Size(117, 21);
            this.timeIntervalCb.TabIndex = 28;
            this.timeIntervalCb.SelectedIndexChanged += new System.EventHandler(this.timeIntervalCb_SelectedIndexChanged);
            // 
            // timeIntervalValueCb
            // 
            this.timeIntervalValueCb.FormattingEnabled = true;
            this.timeIntervalValueCb.Location = new System.Drawing.Point(13, 4);
            this.timeIntervalValueCb.Name = "timeIntervalValueCb";
            this.timeIntervalValueCb.Size = new System.Drawing.Size(72, 21);
            this.timeIntervalValueCb.TabIndex = 29;
            // 
            // ExtendedCronURI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.timeIntervalValueCb);
            this.Controls.Add(this.timeIntervalCb);
            this.Controls.Add(this.secondsCb);
            this.Controls.Add(this.minutesCb);
            this.Controls.Add(this.hoursCb);
            this.Controls.Add(this.atLb);
            this.Controls.Add(this.yearCb);
            this.Controls.Add(this.monthCb);
            this.Controls.Add(this.dayCb);
            this.Controls.Add(this.startingLabel);
            this.Name = "ExtendedCronURI";
            this.Size = new System.Drawing.Size(223, 111);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox secondsCb;
        public System.Windows.Forms.ComboBox minutesCb;
        public System.Windows.Forms.ComboBox hoursCb;
        private System.Windows.Forms.Label atLb;
        public System.Windows.Forms.ComboBox yearCb;
        public System.Windows.Forms.ComboBox monthCb;
        public System.Windows.Forms.ComboBox dayCb;
        private System.Windows.Forms.Label startingLabel;
        public System.Windows.Forms.ComboBox timeIntervalCb;
        public System.Windows.Forms.ComboBox timeIntervalValueCb;
    }
}
