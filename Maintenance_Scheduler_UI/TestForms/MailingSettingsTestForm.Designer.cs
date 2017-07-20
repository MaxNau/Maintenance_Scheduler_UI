namespace Maintenance_Scheduler_UI.TestForms
{
    partial class MailingSettingsTestForm
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
            this.mailingConfig1 = new MaintenanceSchedulerControlLibrary.MailingConfig();
            this.SuspendLayout();
            // 
            // mailingConfig1
            // 
            this.mailingConfig1.Email = "";
            this.mailingConfig1.Location = new System.Drawing.Point(12, 12);
            this.mailingConfig1.Name = "mailingConfig1";
            this.mailingConfig1.Size = new System.Drawing.Size(255, 124);
            this.mailingConfig1.SmtpDomain = "";
            this.mailingConfig1.SmtpPort = "";
            this.mailingConfig1.SslEnabled = false;
            this.mailingConfig1.TabIndex = 0;
            // 
            // MailingSettingsTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 149);
            this.Controls.Add(this.mailingConfig1);
            this.Name = "MailingSettingsTestForm";
            this.Text = "MailingSettingsTestForm";
            this.ResumeLayout(false);

        }

        #endregion

        private MaintenanceSchedulerControlLibrary.MailingConfig mailingConfig1;
    }
}