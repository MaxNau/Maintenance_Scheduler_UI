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
            this.extendedCronURI_1 = new MaintenanceSchedulerControlLibrary.ExtendedCronURIEverySMHStartAtSpecTime();
            this.extendedCronURIEveryDMYAtSpecTime1 = new MaintenanceSchedulerControlLibrary.ExtendedCronURIEveryDMYAtSpecTime();
            this.panel1 = new System.Windows.Forms.Panel();
            this.specificTimeRbtn = new System.Windows.Forms.RadioButton();
            this.everySMHRbtn = new System.Windows.Forms.RadioButton();
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
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(334, 261);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // extendedCronURI_1
            // 
            this.extendedCronURI_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.extendedCronURI_1.Location = new System.Drawing.Point(3, 94);
            this.extendedCronURI_1.Name = "extendedCronURI_1";
            this.extendedCronURI_1.Size = new System.Drawing.Size(328, 97);
            this.extendedCronURI_1.TabIndex = 4;
            // 
            // extendedCronURIEveryDMYAtSpecTime1
            // 
            this.extendedCronURIEveryDMYAtSpecTime1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.extendedCronURIEveryDMYAtSpecTime1.Location = new System.Drawing.Point(3, 197);
            this.extendedCronURIEveryDMYAtSpecTime1.Name = "extendedCronURIEveryDMYAtSpecTime1";
            this.extendedCronURIEveryDMYAtSpecTime1.Size = new System.Drawing.Size(328, 62);
            this.extendedCronURIEveryDMYAtSpecTime1.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.specificTimeRbtn);
            this.panel1.Controls.Add(this.everySMHRbtn);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 85);
            this.panel1.TabIndex = 6;
            // 
            // specificTimeRbtn
            // 
            this.specificTimeRbtn.Location = new System.Drawing.Point(3, 44);
            this.specificTimeRbtn.Name = "specificTimeRbtn";
            this.specificTimeRbtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.specificTimeRbtn.Size = new System.Drawing.Size(266, 35);
            this.specificTimeRbtn.TabIndex = 1;
            this.specificTimeRbtn.Text = "Execute every n-days, -month, -years on specific week day at specified time";
            this.specificTimeRbtn.UseVisualStyleBackColor = true;
            // 
            // everySMHRbtn
            // 
            this.everySMHRbtn.Checked = true;
            this.everySMHRbtn.Location = new System.Drawing.Point(4, 3);
            this.everySMHRbtn.Name = "everySMHRbtn";
            this.everySMHRbtn.Size = new System.Drawing.Size(266, 35);
            this.everySMHRbtn.TabIndex = 0;
            this.everySMHRbtn.TabStop = true;
            this.everySMHRbtn.Text = "Execute every n-seconds, -minutes, -hours starting at specific time";
            this.everySMHRbtn.UseVisualStyleBackColor = true;
            this.everySMHRbtn.CheckedChanged += new System.EventHandler(this.everySMHRbtn_CheckedChanged);
            // 
            // CombinedCronURI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CombinedCronURI";
            this.Size = new System.Drawing.Size(334, 261);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton specificTimeRbtn;
        private System.Windows.Forms.RadioButton everySMHRbtn;
        private ExtendedCronURIEveryDMYAtSpecTime extendedCronURIEveryDMYAtSpecTime1;
        private ExtendedCronURIEverySMHStartAtSpecTime extendedCronURI_1;
    }
}
