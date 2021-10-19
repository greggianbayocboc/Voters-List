namespace gregg.Forms
{
    partial class PieChartByBarangayForm
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
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelPosition = new DevExpress.XtraEditors.LabelControl();
            this.labelCandidate = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraScrollableControl1.Location = new System.Drawing.Point(12, 72);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(914, 597);
            this.xtraScrollableControl1.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(76, 24);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Position ";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(12, 42);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(96, 24);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Candidate ";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(120, 12);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(7, 24);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = ":";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(120, 42);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(7, 24);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = ":";
            // 
            // labelPosition
            // 
            this.labelPosition.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.labelPosition.Appearance.Options.UseFont = true;
            this.labelPosition.LineColor = System.Drawing.Color.Black;
            this.labelPosition.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom;
            this.labelPosition.Location = new System.Drawing.Point(142, 12);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(12, 24);
            this.labelPosition.TabIndex = 5;
            this.labelPosition.Text = "_";
            // 
            // labelCandidate
            // 
            this.labelCandidate.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.labelCandidate.Appearance.Options.UseFont = true;
            this.labelCandidate.LineColor = System.Drawing.Color.Black;
            this.labelCandidate.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom;
            this.labelCandidate.Location = new System.Drawing.Point(142, 42);
            this.labelCandidate.Name = "labelCandidate";
            this.labelCandidate.Size = new System.Drawing.Size(12, 24);
            this.labelCandidate.TabIndex = 6;
            this.labelCandidate.Text = "_";
            // 
            // PieChartByBarangayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 681);
            this.Controls.Add(this.labelCandidate);
            this.Controls.Add(this.labelPosition);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.xtraScrollableControl1);
            this.Name = "PieChartByBarangayForm";
            this.Text = "PieChartByBarangayForm";
            this.Load += new System.EventHandler(this.PieChartByBarangayForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        public DevExpress.XtraEditors.LabelControl labelPosition;
        public DevExpress.XtraEditors.LabelControl labelCandidate;
    }
}