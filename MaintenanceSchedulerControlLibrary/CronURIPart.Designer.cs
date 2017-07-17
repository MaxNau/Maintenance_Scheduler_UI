namespace MaintenanceSchedulerControlLibrary
{
    partial class CronURIPart
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.extendedCronURI1 = new MaintenanceSchedulerControlLibrary.ExtendedCronURI();
            this.selectIntervalRbtn = new System.Windows.Forms.RadioButton();
            this.allRbtn = new System.Windows.Forms.RadioButton();
            this.timeIntervalListbox = new System.Windows.Forms.ListBox();
            this.everyRbtn = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.everyRbtn);
            this.groupBox1.Controls.Add(this.extendedCronURI1);
            this.groupBox1.Controls.Add(this.selectIntervalRbtn);
            this.groupBox1.Controls.Add(this.allRbtn);
            this.groupBox1.Controls.Add(this.timeIntervalListbox);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 361);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Minutes";
            // 
            // extendedCronURI1
            // 
            this.extendedCronURI1.Location = new System.Drawing.Point(7, 257);
            this.extendedCronURI1.Name = "extendedCronURI1";
            this.extendedCronURI1.Size = new System.Drawing.Size(223, 98);
            this.extendedCronURI1.TabIndex = 9;
            // 
            // selectIntervalRbtn
            // 
            this.selectIntervalRbtn.AutoSize = true;
            this.selectIntervalRbtn.Location = new System.Drawing.Point(6, 43);
            this.selectIntervalRbtn.Name = "selectIntervalRbtn";
            this.selectIntervalRbtn.Size = new System.Drawing.Size(85, 17);
            this.selectIntervalRbtn.TabIndex = 8;
            this.selectIntervalRbtn.TabStop = true;
            this.selectIntervalRbtn.Text = "Specific time";
            this.selectIntervalRbtn.UseVisualStyleBackColor = true;
            this.selectIntervalRbtn.CheckedChanged += new System.EventHandler(this.selectIntervalRbtn_CheckedChanged);
            // 
            // allRbtn
            // 
            this.allRbtn.AutoSize = true;
            this.allRbtn.Checked = true;
            this.allRbtn.Location = new System.Drawing.Point(7, 20);
            this.allRbtn.Name = "allRbtn";
            this.allRbtn.Size = new System.Drawing.Size(36, 17);
            this.allRbtn.TabIndex = 7;
            this.allRbtn.TabStop = true;
            this.allRbtn.Text = "All";
            this.allRbtn.UseVisualStyleBackColor = true;
            this.allRbtn.CheckedChanged += new System.EventHandler(this.allRbtn_CheckedChanged);
            // 
            // timeIntervalListbox
            // 
            this.timeIntervalListbox.Enabled = false;
            this.timeIntervalListbox.FormattingEnabled = true;
            this.timeIntervalListbox.Location = new System.Drawing.Point(22, 66);
            this.timeIntervalListbox.Name = "timeIntervalListbox";
            this.timeIntervalListbox.Size = new System.Drawing.Size(57, 173);
            this.timeIntervalListbox.TabIndex = 6;
            // 
            // everyRbtn
            // 
            this.everyRbtn.AutoSize = true;
            this.everyRbtn.Location = new System.Drawing.Point(98, 234);
            this.everyRbtn.Name = "everyRbtn";
            this.everyRbtn.Size = new System.Drawing.Size(52, 17);
            this.everyRbtn.TabIndex = 10;
            this.everyRbtn.TabStop = true;
            this.everyRbtn.Text = "Every";
            this.everyRbtn.UseVisualStyleBackColor = true;
            // 
            // CronURIPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "CronURIPart";
            this.Size = new System.Drawing.Size(259, 367);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ListBox timeIntervalListbox;
        public System.Windows.Forms.RadioButton selectIntervalRbtn;
        public System.Windows.Forms.RadioButton allRbtn;
        private ExtendedCronURI extendedCronURI1;
        private System.Windows.Forms.RadioButton everyRbtn;
    }
}
