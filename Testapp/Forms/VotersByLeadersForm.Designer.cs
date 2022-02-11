namespace gregg.Forms
{
    partial class VotersByLeadersForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VotersByLeadersForm));
            this.comboBoxBarangay = new DevExpress.XtraEditors.ComboBoxEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxPurok = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxCluster = new DevExpress.XtraEditors.ComboBoxEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.barangayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purokBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clusterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bandedGridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnMayor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemRadioGroup1 = new DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup();
            this.columnVice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxBarangay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxPurok.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxCluster.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barangayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purokBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clusterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxBarangay
            // 
            this.comboBoxBarangay.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.barangayBindingSource, "ID", true));
            this.comboBoxBarangay.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.barangayBindingSource, "BarangayName", true));
            this.comboBoxBarangay.Location = new System.Drawing.Point(5, 49);
            this.comboBoxBarangay.Name = "comboBoxBarangay";
            this.comboBoxBarangay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxBarangay.Properties.SelectedValueChanged += new System.EventHandler(this.comboBoxEdit1_Properties_SelectedValueChanged);
            this.comboBoxBarangay.Size = new System.Drawing.Size(252, 20);
            this.comboBoxBarangay.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.simpleButton2);
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.comboBoxCluster);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.comboBoxPurok);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.comboBoxBarangay);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1144, 109);
            this.groupControl1.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(5, 30);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(46, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Barangay";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(275, 30);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(63, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Purok Leader";
            // 
            // comboBoxPurok
            // 
            this.comboBoxPurok.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.purokBindingSource, "ID", true));
            this.comboBoxPurok.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purokBindingSource, "PurokName", true));
            this.comboBoxPurok.Location = new System.Drawing.Point(275, 49);
            this.comboBoxPurok.Name = "comboBoxPurok";
            this.comboBoxPurok.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxPurok.Properties.SelectedValueChanged += new System.EventHandler(this.comboBoxEdit2_Properties_SelectedValueChanged);
            this.comboBoxPurok.Size = new System.Drawing.Size(252, 20);
            this.comboBoxPurok.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(542, 30);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(70, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Cluster Leader";
            // 
            // comboBoxCluster
            // 
            this.comboBoxCluster.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.clusterBindingSource, "ID", true));
            this.comboBoxCluster.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clusterBindingSource, "Leader", true));
            this.comboBoxCluster.Location = new System.Drawing.Point(542, 49);
            this.comboBoxCluster.Name = "comboBoxCluster";
            this.comboBoxCluster.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxCluster.Size = new System.Drawing.Size(252, 20);
            this.comboBoxCluster.TabIndex = 4;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(800, 30);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(118, 74);
            this.simpleButton1.TabIndex = 6;
            this.simpleButton1.Text = "Load Voters";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // barangayBindingSource
            // 
            this.barangayBindingSource.DataSource = typeof(Testapp.Models.Barangay);
            // 
            // purokBindingSource
            // 
            this.purokBindingSource.DataSource = typeof(Testapp.Models.Purok);
            // 
            // clusterBindingSource
            // 
            this.clusterBindingSource.DataSource = typeof(Testapp.Models.Cluster);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Location = new System.Drawing.Point(12, 127);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemRadioGroup1,
            this.repositoryItemCheckEdit1});
            this.gridControl1.Size = new System.Drawing.Size(1144, 546);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.bandedGridColumn1,
            this.columnMayor,
            this.columnVice});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            // 
            // bandedGridColumn1
            // 
            this.bandedGridColumn1.Caption = "Voter Name";
            this.bandedGridColumn1.FieldName = "Fullname";
            this.bandedGridColumn1.MinWidth = 250;
            this.bandedGridColumn1.Name = "bandedGridColumn1";
            this.bandedGridColumn1.OptionsColumn.AllowEdit = false;
            this.bandedGridColumn1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.bandedGridColumn1.Visible = true;
            this.bandedGridColumn1.VisibleIndex = 0;
            this.bandedGridColumn1.Width = 250;
            // 
            // columnMayor
            // 
            this.columnMayor.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.columnMayor.AppearanceHeader.Options.UseFont = true;
            this.columnMayor.AppearanceHeader.Options.UseTextOptions = true;
            this.columnMayor.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.columnMayor.Caption = "(MAYOR) Ongie Bernales-Lim";
            this.columnMayor.ColumnEdit = this.repositoryItemRadioGroup1;
            this.columnMayor.FieldName = "Mayor";
            this.columnMayor.MinWidth = 300;
            this.columnMayor.Name = "columnMayor";
            this.columnMayor.Visible = true;
            this.columnMayor.VisibleIndex = 1;
            this.columnMayor.Width = 300;
            // 
            // repositoryItemRadioGroup1
            // 
            this.repositoryItemRadioGroup1.ColumnIndent = 2;
            this.repositoryItemRadioGroup1.Columns = 4;
            this.repositoryItemRadioGroup1.ItemHorzAlignment = DevExpress.XtraEditors.RadioItemHorzAlignment.Center;
            this.repositoryItemRadioGroup1.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("ATO", "ATO"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("DILE ATO", "DILE ATO"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("DUHA_DUHA", "DUHA DUHA"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("INC", "INC")});
            this.repositoryItemRadioGroup1.ItemsLayout = DevExpress.XtraEditors.RadioGroupItemsLayout.Flow;
            this.repositoryItemRadioGroup1.Name = "repositoryItemRadioGroup1";
            this.repositoryItemRadioGroup1.SelectedIndexChanged += new System.EventHandler(this.repositoryItemRadioGroup1_SelectedIndexChanged);
            // 
            // columnVice
            // 
            this.columnVice.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.columnVice.AppearanceHeader.Options.UseFont = true;
            this.columnVice.AppearanceHeader.Options.UseTextOptions = true;
            this.columnVice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.columnVice.Caption = "(VICE-MAYOR) Myra Fostanes-Colis";
            this.columnVice.ColumnEdit = this.repositoryItemRadioGroup1;
            this.columnVice.FieldName = "Vice";
            this.columnVice.MinWidth = 300;
            this.columnVice.Name = "columnVice";
            this.columnVice.Visible = true;
            this.columnVice.VisibleIndex = 2;
            this.columnVice.Width = 300;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(924, 30);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(118, 74);
            this.simpleButton2.TabIndex = 7;
            this.simpleButton2.Text = "Include Voter";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // VotersByLeadersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 685);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "VotersByLeadersForm";
            this.Text = "Voters By Leaders";
            this.Load += new System.EventHandler(this.VotersByLeadersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxBarangay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxPurok.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxCluster.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barangayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purokBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clusterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ComboBoxEdit comboBoxBarangay;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxPurok;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxCluster;
        private System.Windows.Forms.BindingSource barangayBindingSource;
        private System.Windows.Forms.BindingSource clusterBindingSource;
        private System.Windows.Forms.BindingSource purokBindingSource;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn bandedGridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn columnMayor;
        private DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup repositoryItemRadioGroup1;
        private DevExpress.XtraGrid.Columns.GridColumn columnVice;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}