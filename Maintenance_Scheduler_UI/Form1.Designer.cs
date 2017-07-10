namespace Maintenance_Scheduler_UI
{
    partial class Form1
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
            this.maintanceMessager1 = new Maintenance_Scheduler_UI.MaintanceMessager();
            this.addMaintenanceScheduleView1 = new Maintenance_Scheduler_UI.AddMaintenanceScheduleView();
            this.SuspendLayout();
            // 
            // maintanceMessager1
            // 
            this.maintanceMessager1.Location = new System.Drawing.Point(18, 12);
            this.maintanceMessager1.Name = "maintanceMessager1";
            this.maintanceMessager1.Size = new System.Drawing.Size(304, 46);
            this.maintanceMessager1.TabIndex = 0;
            // 
            // addMaintenanceScheduleView1
            // 
            this.addMaintenanceScheduleView1.Location = new System.Drawing.Point(36, 52);
            this.addMaintenanceScheduleView1.Name = "addMaintenanceScheduleView1";
            this.addMaintenanceScheduleView1.Size = new System.Drawing.Size(317, 232);
            this.addMaintenanceScheduleView1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 296);
            this.Controls.Add(this.addMaintenanceScheduleView1);
            this.Controls.Add(this.maintanceMessager1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private MaintanceMessager maintanceMessager1;
        private AddMaintenanceScheduleView addMaintenanceScheduleView1;
    }
}

