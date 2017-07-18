namespace MaintenanceSchedulerControlLibrary
{
    partial class ExtendedCronURIEveryDMYAtSpecTime
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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timeIntervalValueCb
            // 
            this.timeIntervalValueCb.FormattingEnabled = true;
            this.timeIntervalValueCb.Location = new System.Drawing.Point(3, 3);
            this.timeIntervalValueCb.Name = "timeIntervalValueCb";
            this.timeIntervalValueCb.Size = new System.Drawing.Size(72, 21);
            this.timeIntervalValueCb.TabIndex = 43;
            // 
            // timeIntervalCb
            // 
            this.timeIntervalCb.Enabled = false;
            this.timeIntervalCb.FormattingEnabled = true;
            this.timeIntervalCb.Location = new System.Drawing.Point(81, 3);
            this.timeIntervalCb.Name = "timeIntervalCb";
            this.timeIntervalCb.Size = new System.Drawing.Size(117, 21);
            this.timeIntervalCb.TabIndex = 42;
            this.timeIntervalCb.SelectedIndexChanged += new System.EventHandler(this.timeIntervalCb_SelectedIndexChanged);
            // 
            // secondsCb
            // 
            this.secondsCb.Enabled = false;
            this.secondsCb.FormattingEnabled = true;
            this.secondsCb.Location = new System.Drawing.Point(129, 30);
            this.secondsCb.Name = "secondsCb";
            this.secondsCb.Size = new System.Drawing.Size(40, 21);
            this.secondsCb.TabIndex = 41;
            // 
            // minutesCb
            // 
            this.minutesCb.Enabled = false;
            this.minutesCb.FormattingEnabled = true;
            this.minutesCb.Location = new System.Drawing.Point(81, 30);
            this.minutesCb.Name = "minutesCb";
            this.minutesCb.Size = new System.Drawing.Size(42, 21);
            this.minutesCb.TabIndex = 40;
            // 
            // hoursCb
            // 
            this.hoursCb.Enabled = false;
            this.hoursCb.FormattingEnabled = true;
            this.hoursCb.Location = new System.Drawing.Point(38, 30);
            this.hoursCb.Name = "hoursCb";
            this.hoursCb.Size = new System.Drawing.Size(37, 21);
            this.hoursCb.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "at";
            // 
            // ExtendedCronURIEveryDMYAtSpecTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timeIntervalValueCb);
            this.Controls.Add(this.timeIntervalCb);
            this.Controls.Add(this.secondsCb);
            this.Controls.Add(this.minutesCb);
            this.Controls.Add(this.hoursCb);
            this.Name = "ExtendedCronURIEveryDMYAtSpecTime";
            this.Size = new System.Drawing.Size(208, 62);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox timeIntervalValueCb;
        public System.Windows.Forms.ComboBox timeIntervalCb;
        public System.Windows.Forms.ComboBox secondsCb;
        public System.Windows.Forms.ComboBox minutesCb;
        public System.Windows.Forms.ComboBox hoursCb;
        private System.Windows.Forms.Label label1;
    }
}
