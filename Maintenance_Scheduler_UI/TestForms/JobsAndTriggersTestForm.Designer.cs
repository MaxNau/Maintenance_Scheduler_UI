namespace Maintenance_Scheduler_UI.TestForms
{
    partial class JobsAndTriggersTestForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.jobsAndTriggersView1 = new Maintenance_Scheduler_UI.JobsAndTriggersView();
            this.SuspendLayout();
            // 
            // jobsAndTriggersView1
            // 
            this.jobsAndTriggersView1.AutoScroll = true;
            this.jobsAndTriggersView1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.jobsAndTriggersView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.jobsAndTriggersView1.Location = new System.Drawing.Point(0, 0);
            this.jobsAndTriggersView1.Name = "jobsAndTriggersView1";
            this.jobsAndTriggersView1.Size = new System.Drawing.Size(661, 516);
            this.jobsAndTriggersView1.TabIndex = 0;
            // 
            // JobsAndTriggersTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 516);
            this.Controls.Add(this.jobsAndTriggersView1);
            this.Name = "JobsAndTriggersTestForm";
            this.Text = "JobsAndTriggersTestForm";
            this.ResumeLayout(false);

        }

        #endregion

        private JobsAndTriggersView jobsAndTriggersView1;
    }
}