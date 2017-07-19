namespace Maintenance_Scheduler_UI.TestForms
{
    partial class LogsTestForm
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
            this.logsDgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.logsDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // logsDgv
            // 
            this.logsDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.logsDgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logsDgv.Location = new System.Drawing.Point(0, 0);
            this.logsDgv.Name = "logsDgv";
            this.logsDgv.Size = new System.Drawing.Size(652, 261);
            this.logsDgv.TabIndex = 0;
            // 
            // LogsTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 261);
            this.Controls.Add(this.logsDgv);
            this.Name = "LogsTestForm";
            this.Text = "LogsTestForm";
            ((System.ComponentModel.ISupportInitialize)(this.logsDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView logsDgv;
    }
}