namespace Maintenance_Scheduler_UI
{
    partial class JobsAndTriggersView
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
            this.triggersDgv = new System.Windows.Forms.DataGridView();
            this.removeTrigger = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.triggersDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // triggersDgv
            // 
            this.triggersDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.triggersDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.removeTrigger});
            this.triggersDgv.Location = new System.Drawing.Point(3, 3);
            this.triggersDgv.Name = "triggersDgv";
            this.triggersDgv.Size = new System.Drawing.Size(408, 294);
            this.triggersDgv.TabIndex = 0;
            this.triggersDgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.triggersDgv_CellContentClick);
            // 
            // removeTrigger
            // 
            this.removeTrigger.HeaderText = "Remove";
            this.removeTrigger.Name = "removeTrigger";
            this.removeTrigger.Text = "Remove";
            this.removeTrigger.UseColumnTextForButtonValue = true;
            // 
            // JobsAndTriggersView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.triggersDgv);
            this.Name = "JobsAndTriggersView";
            this.Size = new System.Drawing.Size(414, 300);
            this.Load += new System.EventHandler(this.JobsAndTriggersView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.triggersDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView triggersDgv;
        private System.Windows.Forms.DataGridViewButtonColumn removeTrigger;
    }
}
