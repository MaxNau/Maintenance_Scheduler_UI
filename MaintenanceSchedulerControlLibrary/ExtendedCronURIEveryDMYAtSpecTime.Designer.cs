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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timeIntervalValueCb
            // 
            this.timeIntervalValueCb.FormattingEnabled = true;
            this.timeIntervalValueCb.Location = new System.Drawing.Point(51, 3);
            this.timeIntervalValueCb.Name = "timeIntervalValueCb";
            this.timeIntervalValueCb.Size = new System.Drawing.Size(72, 21);
            this.timeIntervalValueCb.TabIndex = 43;
            this.timeIntervalValueCb.SelectedIndexChanged += new System.EventHandler(this.comboboxes_SelectedIndexChanged);
            // 
            // timeIntervalCb
            // 
            this.timeIntervalCb.FormattingEnabled = true;
            this.timeIntervalCb.Location = new System.Drawing.Point(129, 3);
            this.timeIntervalCb.Name = "timeIntervalCb";
            this.timeIntervalCb.Size = new System.Drawing.Size(117, 21);
            this.timeIntervalCb.TabIndex = 42;
            this.timeIntervalCb.SelectedIndexChanged += new System.EventHandler(this.timeIntervalCb_SelectedIndexChanged);
            // 
            // secondsCb
            // 
            this.secondsCb.FormattingEnabled = true;
            this.secondsCb.Location = new System.Drawing.Point(365, 3);
            this.secondsCb.Name = "secondsCb";
            this.secondsCb.Size = new System.Drawing.Size(40, 21);
            this.secondsCb.TabIndex = 41;
            this.secondsCb.SelectedIndexChanged += new System.EventHandler(this.comboboxes_SelectedIndexChanged);
            // 
            // minutesCb
            // 
            this.minutesCb.FormattingEnabled = true;
            this.minutesCb.Location = new System.Drawing.Point(317, 3);
            this.minutesCb.Name = "minutesCb";
            this.minutesCb.Size = new System.Drawing.Size(42, 21);
            this.minutesCb.TabIndex = 40;
            this.minutesCb.SelectedIndexChanged += new System.EventHandler(this.comboboxes_SelectedIndexChanged);
            // 
            // hoursCb
            // 
            this.hoursCb.FormattingEnabled = true;
            this.hoursCb.Location = new System.Drawing.Point(274, 3);
            this.hoursCb.Name = "hoursCb";
            this.hoursCb.Size = new System.Drawing.Size(37, 21);
            this.hoursCb.TabIndex = 39;
            this.hoursCb.SelectedIndexChanged += new System.EventHandler(this.comboboxes_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "at";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Every";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "h";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(331, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "m";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(381, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "s";
            // 
            // ExtendedCronURIEveryDMYAtSpecTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timeIntervalValueCb);
            this.Controls.Add(this.timeIntervalCb);
            this.Controls.Add(this.secondsCb);
            this.Controls.Add(this.minutesCb);
            this.Controls.Add(this.hoursCb);
            this.Name = "ExtendedCronURIEveryDMYAtSpecTime";
            this.Size = new System.Drawing.Size(419, 45);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
