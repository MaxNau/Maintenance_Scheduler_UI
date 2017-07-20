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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.logsDgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.logsDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // logsDgv
            // 
            this.logsDgv.AllowUserToAddRows = false;
            this.logsDgv.AllowUserToDeleteRows = false;
            this.logsDgv.AllowUserToResizeColumns = false;
            this.logsDgv.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.logsDgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.logsDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.logsDgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.logsDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.logsDgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.logsDgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logsDgv.Location = new System.Drawing.Point(0, 0);
            this.logsDgv.Name = "logsDgv";
            this.logsDgv.ReadOnly = true;
            this.logsDgv.RowHeadersVisible = false;
            this.logsDgv.Size = new System.Drawing.Size(652, 261);
            this.logsDgv.TabIndex = 0;
            this.logsDgv.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.logsDgv_DataBindingComplete);
            // 
            // LogsTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 261);
            this.Controls.Add(this.logsDgv);
            this.Name = "LogsTestForm";
            this.Text = "LogsTestForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.logsDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView logsDgv;
    }
}