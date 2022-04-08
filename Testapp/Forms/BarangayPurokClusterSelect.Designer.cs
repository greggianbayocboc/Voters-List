namespace gregg.Forms
{
    partial class BarangayPurokClusterSelect
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
            this.comboBoxEditBarangay = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxEditPurok = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxEditCluster = new DevExpress.XtraEditors.ComboBoxEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditBarangay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditPurok.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditCluster.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxEditBarangay
            // 
            this.comboBoxEditBarangay.Location = new System.Drawing.Point(64, 9);
            this.comboBoxEditBarangay.Name = "comboBoxEditBarangay";
            this.comboBoxEditBarangay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditBarangay.Size = new System.Drawing.Size(162, 20);
            this.comboBoxEditBarangay.TabIndex = 0;
            this.comboBoxEditBarangay.SelectedIndexChanged += new System.EventHandler(this.comboBoxEditBarangay_SelectedIndexChanged);
            this.comboBoxEditBarangay.SelectedValueChanged += new System.EventHandler(this.comboBoxEditBarangay_SelectedValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(46, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Barangay";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 64);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(27, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Purok";
            // 
            // comboBoxEditPurok
            // 
            this.comboBoxEditPurok.Location = new System.Drawing.Point(64, 61);
            this.comboBoxEditPurok.Name = "comboBoxEditPurok";
            this.comboBoxEditPurok.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditPurok.Size = new System.Drawing.Size(162, 20);
            this.comboBoxEditPurok.TabIndex = 2;
            this.comboBoxEditPurok.SelectedValueChanged += new System.EventHandler(this.comboBoxEditPurok_SelectedValueChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 90);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(34, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Cluster";
            // 
            // comboBoxEditCluster
            // 
            this.comboBoxEditCluster.Location = new System.Drawing.Point(64, 87);
            this.comboBoxEditCluster.Name = "comboBoxEditCluster";
            this.comboBoxEditCluster.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditCluster.Size = new System.Drawing.Size(162, 20);
            this.comboBoxEditCluster.TabIndex = 4;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(151, 123);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 6;
            this.simpleButton1.Text = "OK";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(64, 123);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 7;
            this.simpleButton2.Text = "Cancel";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(64, 35);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "Unassigned";
            this.checkEdit1.Size = new System.Drawing.Size(75, 20);
            this.checkEdit1.TabIndex = 8;
            this.checkEdit1.CheckedChanged += new System.EventHandler(this.checkEdit1_CheckedChanged);
            // 
            // BarangayPurokClusterSelect
            // 
            this.AcceptButton = this.simpleButton1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 158);
            this.ControlBox = false;
            this.Controls.Add(this.checkEdit1);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.comboBoxEditCluster);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.comboBoxEditPurok);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.comboBoxEditBarangay);
            this.Name = "BarangayPurokClusterSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select";
            this.Load += new System.EventHandler(this.BarangayPurokClusterSelect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditBarangay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditPurok.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditCluster.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEditBarangay;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEditPurok;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEditCluster;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        public DevExpress.XtraEditors.CheckEdit checkEdit1;
    }
}