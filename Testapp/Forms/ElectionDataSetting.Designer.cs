namespace gregg.Forms
{
    partial class ElectionDataSetting
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bindingSourceMayors = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFullname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colParty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.bindingSourceViceMayors = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFullname1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colParty1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton6 = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl3 = new DevExpress.XtraGrid.GridControl();
            this.bindingSourceCouncilors = new System.Windows.Forms.BindingSource(this.components);
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFullname2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colParty2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton7 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton8 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton9 = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl6 = new DevExpress.XtraEditors.GroupControl();
            this.gridControlParty = new DevExpress.XtraGrid.GridControl();
            this.bindingSourceParty = new System.Windows.Forms.BindingSource(this.components);
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPartyName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton10 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton11 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton12 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMayors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceViceMayors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCouncilors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
            this.groupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).BeginInit();
            this.groupControl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlParty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceParty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControl1);
            this.groupControl1.Controls.Add(this.simpleButton3);
            this.groupControl1.Controls.Add(this.simpleButton2);
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Location = new System.Drawing.Point(5, 23);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(296, 247);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Mayor Candidates";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bindingSourceMayors;
            this.gridControl1.Location = new System.Drawing.Point(5, 23);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(286, 180);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bindingSourceMayors
            // 
            this.bindingSourceMayors.DataSource = typeof(Testapp.Models.Candidate);
            this.bindingSourceMayors.Filter = "Position = \"MAYOR\"";
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFullname,
            this.colParty});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colFullname
            // 
            this.colFullname.FieldName = "Fullname";
            this.colFullname.Name = "colFullname";
            this.colFullname.Visible = true;
            this.colFullname.VisibleIndex = 0;
            // 
            // colParty
            // 
            this.colParty.FieldName = "Party";
            this.colParty.Name = "colParty";
            this.colParty.Visible = true;
            this.colParty.VisibleIndex = 1;
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(167, 209);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(75, 23);
            this.simpleButton3.TabIndex = 3;
            this.simpleButton3.Text = "Delete";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(86, 209);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 2;
            this.simpleButton2.Text = "Edit";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(5, 209);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Add";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControl2);
            this.groupControl2.Controls.Add(this.simpleButton4);
            this.groupControl2.Controls.Add(this.simpleButton5);
            this.groupControl2.Controls.Add(this.simpleButton6);
            this.groupControl2.Location = new System.Drawing.Point(307, 23);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(296, 247);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Vice-Mayor Candidates";
            // 
            // gridControl2
            // 
            this.gridControl2.DataSource = this.bindingSourceViceMayors;
            this.gridControl2.Location = new System.Drawing.Point(5, 23);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(286, 180);
            this.gridControl2.TabIndex = 5;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // bindingSourceViceMayors
            // 
            this.bindingSourceViceMayors.DataSource = typeof(Testapp.Models.Candidate);
            this.bindingSourceViceMayors.Filter = "Position = \"VICE-MAYOR\"";
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFullname1,
            this.colParty1});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colFullname1
            // 
            this.colFullname1.FieldName = "Fullname";
            this.colFullname1.Name = "colFullname1";
            this.colFullname1.Visible = true;
            this.colFullname1.VisibleIndex = 0;
            // 
            // colParty1
            // 
            this.colParty1.FieldName = "Party";
            this.colParty1.Name = "colParty1";
            this.colParty1.Visible = true;
            this.colParty1.VisibleIndex = 1;
            // 
            // simpleButton4
            // 
            this.simpleButton4.Location = new System.Drawing.Point(167, 209);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(75, 23);
            this.simpleButton4.TabIndex = 3;
            this.simpleButton4.Text = "Delete";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // simpleButton5
            // 
            this.simpleButton5.Location = new System.Drawing.Point(86, 209);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(75, 23);
            this.simpleButton5.TabIndex = 2;
            this.simpleButton5.Text = "Edit";
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // simpleButton6
            // 
            this.simpleButton6.Location = new System.Drawing.Point(5, 209);
            this.simpleButton6.Name = "simpleButton6";
            this.simpleButton6.Size = new System.Drawing.Size(75, 23);
            this.simpleButton6.TabIndex = 1;
            this.simpleButton6.Text = "Add";
            this.simpleButton6.Click += new System.EventHandler(this.simpleButton6_Click);
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.gridControl3);
            this.groupControl3.Controls.Add(this.simpleButton7);
            this.groupControl3.Controls.Add(this.simpleButton8);
            this.groupControl3.Controls.Add(this.simpleButton9);
            this.groupControl3.Location = new System.Drawing.Point(5, 276);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(296, 247);
            this.groupControl3.TabIndex = 2;
            this.groupControl3.Text = "Councilor Candidates";
            // 
            // gridControl3
            // 
            this.gridControl3.DataSource = this.bindingSourceCouncilors;
            this.gridControl3.Location = new System.Drawing.Point(5, 23);
            this.gridControl3.MainView = this.gridView3;
            this.gridControl3.Name = "gridControl3";
            this.gridControl3.Size = new System.Drawing.Size(286, 180);
            this.gridControl3.TabIndex = 5;
            this.gridControl3.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // bindingSourceCouncilors
            // 
            this.bindingSourceCouncilors.DataSource = typeof(Testapp.Models.Candidate);
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFullname2,
            this.colParty2});
            this.gridView3.GridControl = this.gridControl3;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // colFullname2
            // 
            this.colFullname2.FieldName = "Fullname";
            this.colFullname2.Name = "colFullname2";
            this.colFullname2.Visible = true;
            this.colFullname2.VisibleIndex = 0;
            // 
            // colParty2
            // 
            this.colParty2.FieldName = "Party";
            this.colParty2.Name = "colParty2";
            this.colParty2.Visible = true;
            this.colParty2.VisibleIndex = 1;
            // 
            // simpleButton7
            // 
            this.simpleButton7.Location = new System.Drawing.Point(167, 209);
            this.simpleButton7.Name = "simpleButton7";
            this.simpleButton7.Size = new System.Drawing.Size(75, 23);
            this.simpleButton7.TabIndex = 3;
            this.simpleButton7.Text = "Delete";
            this.simpleButton7.Click += new System.EventHandler(this.simpleButton7_Click);
            // 
            // simpleButton8
            // 
            this.simpleButton8.Location = new System.Drawing.Point(86, 209);
            this.simpleButton8.Name = "simpleButton8";
            this.simpleButton8.Size = new System.Drawing.Size(75, 23);
            this.simpleButton8.TabIndex = 2;
            this.simpleButton8.Text = "Edit";
            this.simpleButton8.Click += new System.EventHandler(this.simpleButton8_Click);
            // 
            // simpleButton9
            // 
            this.simpleButton9.Location = new System.Drawing.Point(5, 209);
            this.simpleButton9.Name = "simpleButton9";
            this.simpleButton9.Size = new System.Drawing.Size(75, 23);
            this.simpleButton9.TabIndex = 1;
            this.simpleButton9.Text = "Add";
            this.simpleButton9.Click += new System.EventHandler(this.simpleButton9_Click);
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.groupControl2);
            this.groupControl4.Controls.Add(this.groupControl3);
            this.groupControl4.Controls.Add(this.groupControl1);
            this.groupControl4.Location = new System.Drawing.Point(12, 12);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(612, 528);
            this.groupControl4.TabIndex = 3;
            this.groupControl4.Text = "Candidates";
            // 
            // groupControl5
            // 
            this.groupControl5.Controls.Add(this.groupControl6);
            this.groupControl5.Location = new System.Drawing.Point(630, 12);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.Size = new System.Drawing.Size(614, 528);
            this.groupControl5.TabIndex = 4;
            this.groupControl5.Text = "Party/Group Settings";
            // 
            // groupControl6
            // 
            this.groupControl6.Controls.Add(this.gridControlParty);
            this.groupControl6.Controls.Add(this.simpleButton10);
            this.groupControl6.Controls.Add(this.simpleButton11);
            this.groupControl6.Controls.Add(this.simpleButton12);
            this.groupControl6.Location = new System.Drawing.Point(5, 23);
            this.groupControl6.Name = "groupControl6";
            this.groupControl6.Size = new System.Drawing.Size(296, 247);
            this.groupControl6.TabIndex = 1;
            this.groupControl6.Text = "Party Groups";
            // 
            // gridControlParty
            // 
            this.gridControlParty.DataSource = this.bindingSourceParty;
            this.gridControlParty.Location = new System.Drawing.Point(5, 23);
            this.gridControlParty.MainView = this.gridView4;
            this.gridControlParty.Name = "gridControlParty";
            this.gridControlParty.Size = new System.Drawing.Size(286, 180);
            this.gridControlParty.TabIndex = 4;
            this.gridControlParty.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4});
            // 
            // bindingSourceParty
            // 
            this.bindingSourceParty.DataSource = typeof(Testapp.Models.Party);
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPartyName});
            this.gridView4.GridControl = this.gridControlParty;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // colPartyName
            // 
            this.colPartyName.FieldName = "PartyName";
            this.colPartyName.Name = "colPartyName";
            this.colPartyName.Visible = true;
            this.colPartyName.VisibleIndex = 0;
            // 
            // simpleButton10
            // 
            this.simpleButton10.Location = new System.Drawing.Point(167, 209);
            this.simpleButton10.Name = "simpleButton10";
            this.simpleButton10.Size = new System.Drawing.Size(75, 23);
            this.simpleButton10.TabIndex = 3;
            this.simpleButton10.Text = "Delete";
            this.simpleButton10.Click += new System.EventHandler(this.simpleButton10_Click);
            // 
            // simpleButton11
            // 
            this.simpleButton11.Location = new System.Drawing.Point(86, 209);
            this.simpleButton11.Name = "simpleButton11";
            this.simpleButton11.Size = new System.Drawing.Size(75, 23);
            this.simpleButton11.TabIndex = 2;
            this.simpleButton11.Text = "Edit";
            this.simpleButton11.Click += new System.EventHandler(this.simpleButton11_Click);
            // 
            // simpleButton12
            // 
            this.simpleButton12.Location = new System.Drawing.Point(5, 209);
            this.simpleButton12.Name = "simpleButton12";
            this.simpleButton12.Size = new System.Drawing.Size(75, 23);
            this.simpleButton12.TabIndex = 1;
            this.simpleButton12.Text = "Add";
            this.simpleButton12.Click += new System.EventHandler(this.simpleButton12_Click);
            // 
            // ElectionDataSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 782);
            this.Controls.Add(this.groupControl5);
            this.Controls.Add(this.groupControl4);
            this.Name = "ElectionDataSetting";
            this.Text = "ElectionDataSetting";
            this.Load += new System.EventHandler(this.ElectionDataSetting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMayors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceViceMayors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCouncilors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).EndInit();
            this.groupControl6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlParty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceParty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.SimpleButton simpleButton6;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.SimpleButton simpleButton7;
        private DevExpress.XtraEditors.SimpleButton simpleButton8;
        private DevExpress.XtraEditors.SimpleButton simpleButton9;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.GridControl gridControl3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.GroupControl groupControl5;
        private DevExpress.XtraEditors.GroupControl groupControl6;
        private DevExpress.XtraGrid.GridControl gridControlParty;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraEditors.SimpleButton simpleButton10;
        private DevExpress.XtraEditors.SimpleButton simpleButton11;
        private DevExpress.XtraEditors.SimpleButton simpleButton12;
        private System.Windows.Forms.BindingSource bindingSourceMayors;
        private DevExpress.XtraGrid.Columns.GridColumn colFullname;
        private DevExpress.XtraGrid.Columns.GridColumn colParty;
        private System.Windows.Forms.BindingSource bindingSourceViceMayors;
        private DevExpress.XtraGrid.Columns.GridColumn colFullname1;
        private DevExpress.XtraGrid.Columns.GridColumn colParty1;
        private System.Windows.Forms.BindingSource bindingSourceCouncilors;
        private DevExpress.XtraGrid.Columns.GridColumn colFullname2;
        private DevExpress.XtraGrid.Columns.GridColumn colParty2;
        private System.Windows.Forms.BindingSource bindingSourceParty;
        private DevExpress.XtraGrid.Columns.GridColumn colPartyName;
    }
}