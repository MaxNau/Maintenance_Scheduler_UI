namespace MaintenanceSchedulerControlLibrary
{
    partial class CombinedCronURI
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.specificTimeRbtn = new System.Windows.Forms.RadioButton();
            this.everySMHRbtn = new System.Windows.Forms.RadioButton();
            this.extendedCronURIEveryDMYAtSpecTime1 = new MaintenanceSchedulerControlLibrary.ExtendedCronURIEveryDMYAtSpecTime();
            this.extendedCronURI_1 = new MaintenanceSchedulerControlLibrary.ExtendedCronURIEverySMHStartAtSpecTime();
            this.extendedCronURIEveryYearsOnSpecifiedDateTime1 = new MaintenanceSchedulerControlLibrary.ExtendedCronURIEveryYearsOnSpecifiedDateTime();
            this.everyNYearsOnAtStartingRb = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.extendedCronURIEveryDMYAtSpecTime1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.extendedCronURI_1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.extendedCronURIEveryYearsOnSpecifiedDateTime1, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(658, 321);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.everyNYearsOnAtStartingRb);
            this.panel1.Controls.Add(this.specificTimeRbtn);
            this.panel1.Controls.Add(this.everySMHRbtn);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 76);
            this.panel1.TabIndex = 6;
            // 
            // specificTimeRbtn
            // 
            this.specificTimeRbtn.AutoSize = true;
            this.specificTimeRbtn.Location = new System.Drawing.Point(3, 26);
            this.specificTimeRbtn.Name = "specificTimeRbtn";
            this.specificTimeRbtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.specificTimeRbtn.Size = new System.Drawing.Size(381, 17);
            this.specificTimeRbtn.TabIndex = 1;
            this.specificTimeRbtn.Text = "Execute every n-days, -month, -years on specific week day at specified time";
            this.specificTimeRbtn.UseVisualStyleBackColor = true;
            this.specificTimeRbtn.CheckedChanged += new System.EventHandler(this.everySMHRbtn_CheckedChanged);
            // 
            // everySMHRbtn
            // 
            this.everySMHRbtn.AutoSize = true;
            this.everySMHRbtn.Checked = true;
            this.everySMHRbtn.Location = new System.Drawing.Point(4, 3);
            this.everySMHRbtn.Name = "everySMHRbtn";
            this.everySMHRbtn.Size = new System.Drawing.Size(335, 17);
            this.everySMHRbtn.TabIndex = 0;
            this.everySMHRbtn.TabStop = true;
            this.everySMHRbtn.Text = "Execute every n-seconds, -minutes, -hours starting at specific time";
            this.everySMHRbtn.UseVisualStyleBackColor = true;
            this.everySMHRbtn.CheckedChanged += new System.EventHandler(this.everySMHRbtn_CheckedChanged);
            // 
            // extendedCronURIEveryDMYAtSpecTime1
            // 
            this.extendedCronURIEveryDMYAtSpecTime1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.extendedCronURIEveryDMYAtSpecTime1.Location = new System.Drawing.Point(3, 188);
            this.extendedCronURIEveryDMYAtSpecTime1.Name = "extendedCronURIEveryDMYAtSpecTime1";
            this.extendedCronURIEveryDMYAtSpecTime1.Size = new System.Drawing.Size(652, 62);
            this.extendedCronURIEveryDMYAtSpecTime1.TabIndex = 5;
            // 
            // extendedCronURI_1
            // 
            this.extendedCronURI_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.extendedCronURI_1.Location = new System.Drawing.Point(3, 85);
            this.extendedCronURI_1.Name = "extendedCronURI_1";
            this.extendedCronURI_1.Size = new System.Drawing.Size(652, 97);
            this.extendedCronURI_1.TabIndex = 4;
            // 
            // extendedCronURIEveryYearsOnSpecifiedDateTime1
            // 
            this.extendedCronURIEveryYearsOnSpecifiedDateTime1.Location = new System.Drawing.Point(3, 256);
            this.extendedCronURIEveryYearsOnSpecifiedDateTime1.Name = "extendedCronURIEveryYearsOnSpecifiedDateTime1";
            this.extendedCronURIEveryYearsOnSpecifiedDateTime1.Size = new System.Drawing.Size(652, 59);
            this.extendedCronURIEveryYearsOnSpecifiedDateTime1.TabIndex = 7;
            // 
            // everyNYearsOnAtStartingRb
            // 
            this.everyNYearsOnAtStartingRb.AutoSize = true;
            this.everyNYearsOnAtStartingRb.Location = new System.Drawing.Point(4, 49);
            this.everyNYearsOnAtStartingRb.Name = "everyNYearsOnAtStartingRb";
            this.everyNYearsOnAtStartingRb.Size = new System.Drawing.Size(343, 17);
            this.everyNYearsOnAtStartingRb.TabIndex = 2;
            this.everyNYearsOnAtStartingRb.TabStop = true;
            this.everyNYearsOnAtStartingRb.Text = "Execute every n-years on specific date and time starting from year n";
            this.everyNYearsOnAtStartingRb.UseVisualStyleBackColor = true;
            this.everyNYearsOnAtStartingRb.CheckedChanged += new System.EventHandler(this.everySMHRbtn_CheckedChanged);
            // 
            // CombinedCronURI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CombinedCronURI";
            this.Size = new System.Drawing.Size(658, 321);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton specificTimeRbtn;
        private System.Windows.Forms.RadioButton everySMHRbtn;
        private ExtendedCronURIEveryDMYAtSpecTime extendedCronURIEveryDMYAtSpecTime1;
        private ExtendedCronURIEverySMHStartAtSpecTime extendedCronURI_1;
        private System.Windows.Forms.RadioButton everyNYearsOnAtStartingRb;
        private ExtendedCronURIEveryYearsOnSpecifiedDateTime extendedCronURIEveryYearsOnSpecifiedDateTime1;
    }
}
