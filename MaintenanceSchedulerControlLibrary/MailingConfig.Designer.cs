namespace MaintenanceSchedulerControlLibrary
{
    partial class MailingConfig
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.emailLb = new System.Windows.Forms.Label();
            this.smtpDomainLb = new System.Windows.Forms.Label();
            this.emailTb = new System.Windows.Forms.TextBox();
            this.smtpDomainTb = new System.Windows.Forms.TextBox();
            this.portLb = new System.Windows.Forms.Label();
            this.enableSslCheckB = new System.Windows.Forms.CheckBox();
            this.enableSslLb = new System.Windows.Forms.Label();
            this.smtpPortTb = new System.Windows.Forms.TextBox();
            this.saveSettingsBtn = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.emailLb, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.smtpDomainLb, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.emailTb, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.smtpDomainTb, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.portLb, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.enableSslCheckB, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.enableSslLb, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.smtpPortTb, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.saveSettingsBtn, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(255, 124);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // emailLb
            // 
            this.emailLb.AutoSize = true;
            this.emailLb.Location = new System.Drawing.Point(3, 0);
            this.emailLb.Name = "emailLb";
            this.emailLb.Size = new System.Drawing.Size(32, 13);
            this.emailLb.TabIndex = 0;
            this.emailLb.Text = "Email";
            // 
            // smtpDomainLb
            // 
            this.smtpDomainLb.AutoSize = true;
            this.smtpDomainLb.Location = new System.Drawing.Point(3, 26);
            this.smtpDomainLb.Name = "smtpDomainLb";
            this.smtpDomainLb.Size = new System.Drawing.Size(74, 13);
            this.smtpDomainLb.TabIndex = 1;
            this.smtpDomainLb.Text = "SMTP domain";
            // 
            // emailTb
            // 
            this.emailTb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.emailTb.Location = new System.Drawing.Point(83, 3);
            this.emailTb.Name = "emailTb";
            this.emailTb.Size = new System.Drawing.Size(169, 20);
            this.emailTb.TabIndex = 2;
            // 
            // smtpDomainTb
            // 
            this.smtpDomainTb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.smtpDomainTb.Location = new System.Drawing.Point(83, 29);
            this.smtpDomainTb.Name = "smtpDomainTb";
            this.smtpDomainTb.Size = new System.Drawing.Size(169, 20);
            this.smtpDomainTb.TabIndex = 3;
            // 
            // portLb
            // 
            this.portLb.AutoSize = true;
            this.portLb.Location = new System.Drawing.Point(3, 52);
            this.portLb.Name = "portLb";
            this.portLb.Size = new System.Drawing.Size(58, 13);
            this.portLb.TabIndex = 4;
            this.portLb.Text = "SMTP port";
            // 
            // enableSslCheckB
            // 
            this.enableSslCheckB.AutoSize = true;
            this.enableSslCheckB.Location = new System.Drawing.Point(83, 81);
            this.enableSslCheckB.Name = "enableSslCheckB";
            this.enableSslCheckB.Size = new System.Drawing.Size(15, 14);
            this.enableSslCheckB.TabIndex = 5;
            this.enableSslCheckB.UseVisualStyleBackColor = true;
            // 
            // enableSslLb
            // 
            this.enableSslLb.AutoSize = true;
            this.enableSslLb.Location = new System.Drawing.Point(3, 78);
            this.enableSslLb.Name = "enableSslLb";
            this.enableSslLb.Size = new System.Drawing.Size(57, 13);
            this.enableSslLb.TabIndex = 6;
            this.enableSslLb.Text = "Enable Ssl";
            // 
            // smtpPortTb
            // 
            this.smtpPortTb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.smtpPortTb.Location = new System.Drawing.Point(83, 55);
            this.smtpPortTb.Name = "smtpPortTb";
            this.smtpPortTb.Size = new System.Drawing.Size(169, 20);
            this.smtpPortTb.TabIndex = 7;
            // 
            // saveSettingsBtn
            // 
            this.saveSettingsBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.saveSettingsBtn.Location = new System.Drawing.Point(177, 101);
            this.saveSettingsBtn.Name = "saveSettingsBtn";
            this.saveSettingsBtn.Size = new System.Drawing.Size(75, 20);
            this.saveSettingsBtn.TabIndex = 8;
            this.saveSettingsBtn.Text = "Save";
            this.saveSettingsBtn.UseVisualStyleBackColor = true;
            this.saveSettingsBtn.Click += new System.EventHandler(this.saveSettingsBtn_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // MailingConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MailingConfig";
            this.Size = new System.Drawing.Size(255, 124);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label emailLb;
        private System.Windows.Forms.Label smtpDomainLb;
        private System.Windows.Forms.TextBox emailTb;
        private System.Windows.Forms.TextBox smtpDomainTb;
        private System.Windows.Forms.Label portLb;
        private System.Windows.Forms.CheckBox enableSslCheckB;
        private System.Windows.Forms.Label enableSslLb;
        private System.Windows.Forms.TextBox smtpPortTb;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button saveSettingsBtn;
    }
}
