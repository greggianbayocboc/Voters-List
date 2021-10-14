namespace Testapp
{
    partial class Voters_List
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
            DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::gregg.Forms.SplashScreen1), true, true);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Voters_List));
            this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precinctDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barangayDataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.buttonColumnPurok = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clusterDataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.updateColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.changeBarangayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePurokToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.changeClusterLeaderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingSourcePerson = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceCluster = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceBarangay = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourcePurok = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceFilterBarangay = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceFilterPurok = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceFilterCluster = new System.Windows.Forms.BindingSource(this.components);
            this.btnAddVoter = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFullname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecinct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBarangay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPurok = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCluster = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBrgy = new System.Windows.Forms.ComboBox();
            this.comboCluster = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboPurok = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.totalVotersValue = new System.Windows.Forms.ToolStripStatusLabel();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCluster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBarangay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePurok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceFilterBarangay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceFilterPurok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceFilterCluster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splashScreenManager1
            // 
            splashScreenManager1.ClosingDelay = 500;
            // 
            // repositoryItemGridLookUpEdit1
            // 
            this.repositoryItemGridLookUpEdit1.AutoHeight = false;
            this.repositoryItemGridLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit1.DisplayMember = "BarangayName";
            this.repositoryItemGridLookUpEdit1.KeyMember = "ID";
            this.repositoryItemGridLookUpEdit1.Name = "repositoryItemGridLookUpEdit1";
            this.repositoryItemGridLookUpEdit1.NullText = "[Not Assigned]";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.precinctDataGridViewTextBoxColumn,
            this.Fullname,
            this.barangayDataGridViewComboBoxColumn,
            this.buttonColumnPurok,
            this.clusterDataGridViewComboBoxColumn,
            this.updateColumn});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.DataSource = this.bindingSourcePerson;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(6, 199);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(855, 123);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView1_CellValidating);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            this.dataGridView1.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowLeave);
            this.dataGridView1.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView1_RowsRemoved);
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precinctDataGridViewTextBoxColumn
            // 
            this.precinctDataGridViewTextBoxColumn.DataPropertyName = "Precinct";
            this.precinctDataGridViewTextBoxColumn.HeaderText = "Precinct";
            this.precinctDataGridViewTextBoxColumn.Name = "precinctDataGridViewTextBoxColumn";
            // 
            // Fullname
            // 
            this.Fullname.DataPropertyName = "Fullname";
            this.Fullname.HeaderText = "Fullname";
            this.Fullname.Name = "Fullname";
            // 
            // barangayDataGridViewComboBoxColumn
            // 
            this.barangayDataGridViewComboBoxColumn.DataPropertyName = "Barangay";
            this.barangayDataGridViewComboBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.barangayDataGridViewComboBoxColumn.HeaderText = "Barangay";
            this.barangayDataGridViewComboBoxColumn.Name = "barangayDataGridViewComboBoxColumn";
            this.barangayDataGridViewComboBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.barangayDataGridViewComboBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // buttonColumnPurok
            // 
            this.buttonColumnPurok.DataPropertyName = "Purok";
            this.buttonColumnPurok.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonColumnPurok.HeaderText = "Purok";
            this.buttonColumnPurok.Name = "buttonColumnPurok";
            // 
            // clusterDataGridViewComboBoxColumn
            // 
            this.clusterDataGridViewComboBoxColumn.DataPropertyName = "Cluster";
            this.clusterDataGridViewComboBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clusterDataGridViewComboBoxColumn.HeaderText = "Cluster";
            this.clusterDataGridViewComboBoxColumn.Name = "clusterDataGridViewComboBoxColumn";
            this.clusterDataGridViewComboBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clusterDataGridViewComboBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // updateColumn
            // 
            this.updateColumn.DataPropertyName = "ID";
            this.updateColumn.HeaderText = "Update";
            this.updateColumn.Name = "updateColumn";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeBarangayToolStripMenuItem,
            this.changePurokToolStripMenu,
            this.changeClusterLeaderToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(194, 70);
            // 
            // changeBarangayToolStripMenuItem
            // 
            this.changeBarangayToolStripMenuItem.Name = "changeBarangayToolStripMenuItem";
            this.changeBarangayToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.changeBarangayToolStripMenuItem.Text = "Change Barangay";
            this.changeBarangayToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.changeBarangayToolStripMenuItem_DropDownItemClicked);
            // 
            // changePurokToolStripMenu
            // 
            this.changePurokToolStripMenu.Name = "changePurokToolStripMenu";
            this.changePurokToolStripMenu.Size = new System.Drawing.Size(193, 22);
            this.changePurokToolStripMenu.Text = "Change Purok";
            this.changePurokToolStripMenu.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.changePurokToolStripMenu_DropDownItemClicked);
            // 
            // changeClusterLeaderToolStripMenuItem
            // 
            this.changeClusterLeaderToolStripMenuItem.Name = "changeClusterLeaderToolStripMenuItem";
            this.changeClusterLeaderToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.changeClusterLeaderToolStripMenuItem.Text = "Change Cluster Leader";
            this.changeClusterLeaderToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.changeClusterLeaderToolStripMenuItem_DropDownItemClicked);
            // 
            // bindingSourcePerson
            // 
            this.bindingSourcePerson.DataSource = typeof(Testapp.Models.Person);
            // 
            // bindingSourceCluster
            // 
            this.bindingSourceCluster.DataSource = typeof(Testapp.Models.Cluster);
            // 
            // bindingSourceBarangay
            // 
            this.bindingSourceBarangay.DataSource = typeof(Testapp.Models.Barangay);
            this.bindingSourceBarangay.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.bindingSourceBarangay_ListChanged);
            // 
            // bindingSourcePurok
            // 
            this.bindingSourcePurok.DataSource = typeof(Testapp.Models.Purok);
            // 
            // bindingSourceFilterBarangay
            // 
            this.bindingSourceFilterBarangay.DataSource = typeof(Testapp.Models.Barangay);
            // 
            // bindingSourceFilterPurok
            // 
            this.bindingSourceFilterPurok.DataSource = typeof(Testapp.Models.Purok);
            // 
            // bindingSourceFilterCluster
            // 
            this.bindingSourceFilterCluster.DataSource = typeof(Testapp.Models.Cluster);
            // 
            // btnAddVoter
            // 
            this.btnAddVoter.Location = new System.Drawing.Point(6, 541);
            this.btnAddVoter.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddVoter.Name = "btnAddVoter";
            this.btnAddVoter.Size = new System.Drawing.Size(79, 20);
            this.btnAddVoter.TabIndex = 8;
            this.btnAddVoter.Text = "Add Voter";
            this.btnAddVoter.UseVisualStyleBackColor = true;
            this.btnAddVoter.Click += new System.EventHandler(this.btnAddVoter_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(89, 541);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 20);
            this.button2.TabIndex = 10;
            this.button2.Text = "Remove";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colFullname,
            this.colAddress,
            this.colPrecinct,
            this.colBarangay,
            this.colPurok,
            this.colCluster});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Barangay", null, "(Barangay: Count={0})")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gridView1_CustomColumnDisplayText);
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            this.colID.Width = 41;
            // 
            // colFullname
            // 
            this.colFullname.FieldName = "Fullname";
            this.colFullname.Name = "colFullname";
            this.colFullname.Visible = true;
            this.colFullname.VisibleIndex = 1;
            this.colFullname.Width = 130;
            // 
            // colAddress
            // 
            this.colAddress.FieldName = "Address";
            this.colAddress.Name = "colAddress";
            this.colAddress.Width = 130;
            // 
            // colPrecinct
            // 
            this.colPrecinct.FieldName = "Precinct";
            this.colPrecinct.Name = "colPrecinct";
            this.colPrecinct.Visible = true;
            this.colPrecinct.VisibleIndex = 5;
            this.colPrecinct.Width = 137;
            // 
            // colBarangay
            // 
            this.colBarangay.ColumnEdit = this.repositoryItemGridLookUpEdit1;
            this.colBarangay.FieldName = "Barangay";
            this.colBarangay.Name = "colBarangay";
            this.colBarangay.Visible = true;
            this.colBarangay.VisibleIndex = 2;
            this.colBarangay.Width = 130;
            // 
            // colPurok
            // 
            this.colPurok.FieldName = "Purok";
            this.colPurok.Name = "colPurok";
            this.colPurok.OptionsColumn.AllowEdit = false;
            this.colPurok.Visible = true;
            this.colPurok.VisibleIndex = 3;
            this.colPurok.Width = 130;
            // 
            // colCluster
            // 
            this.colCluster.Caption = "Cluster Leader";
            this.colCluster.FieldName = "Cluster";
            this.colCluster.Name = "colCluster";
            this.colCluster.OptionsColumn.AllowEdit = false;
            this.colCluster.Visible = true;
            this.colCluster.VisibleIndex = 4;
            this.colCluster.Width = 130;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.ContextMenuStrip = this.contextMenuStrip1;
            this.gridControl1.DataSource = this.bindingSourcePerson;
            this.gridControl1.Location = new System.Drawing.Point(6, 50);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(855, 487);
            this.gridControl1.TabIndex = 11;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(491, 24);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 20);
            this.button1.TabIndex = 7;
            this.button1.Text = "Filter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Barangay";
            // 
            // comboBrgy
            // 
            this.comboBrgy.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.comboBrgy.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBrgy.DataSource = this.bindingSourceFilterBarangay;
            this.comboBrgy.DisplayMember = "BarangayName";
            this.comboBrgy.FormattingEnabled = true;
            this.comboBrgy.Location = new System.Drawing.Point(5, 24);
            this.comboBrgy.Margin = new System.Windows.Forms.Padding(2);
            this.comboBrgy.Name = "comboBrgy";
            this.comboBrgy.Size = new System.Drawing.Size(146, 21);
            this.comboBrgy.TabIndex = 2;
            this.comboBrgy.ValueMember = "ID";
            this.comboBrgy.SelectedIndexChanged += new System.EventHandler(this.comboBrgy_SelectedIndexChanged);
            this.comboBrgy.SelectedValueChanged += new System.EventHandler(this.comboBrgy_SelectedIndexChanged);
            // 
            // comboCluster
            // 
            this.comboCluster.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.comboCluster.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboCluster.DataSource = this.bindingSourceFilterCluster;
            this.comboCluster.DisplayMember = "Leader";
            this.comboCluster.FormattingEnabled = true;
            this.comboCluster.Location = new System.Drawing.Point(341, 24);
            this.comboCluster.Margin = new System.Windows.Forms.Padding(2);
            this.comboCluster.Name = "comboCluster";
            this.comboCluster.Size = new System.Drawing.Size(146, 21);
            this.comboCluster.TabIndex = 6;
            this.comboCluster.ValueMember = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Purok";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(338, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cluster";
            // 
            // comboPurok
            // 
            this.comboPurok.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.comboPurok.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboPurok.DataSource = this.bindingSourceFilterPurok;
            this.comboPurok.DisplayMember = "PurokName";
            this.comboPurok.FormattingEnabled = true;
            this.comboPurok.Location = new System.Drawing.Point(179, 24);
            this.comboPurok.Margin = new System.Windows.Forms.Padding(2);
            this.comboPurok.Name = "comboPurok";
            this.comboPurok.Size = new System.Drawing.Size(146, 21);
            this.comboPurok.TabIndex = 4;
            this.comboPurok.ValueMember = "ID";
            this.comboPurok.SelectedIndexChanged += new System.EventHandler(this.comboPurok_SelectedIndexChanged);
            this.comboPurok.SelectedValueChanged += new System.EventHandler(this.comboPurok_SelectedIndexChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.totalVotersValue});
            this.statusStrip1.Location = new System.Drawing.Point(0, 563);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(873, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(76, 17);
            this.toolStripStatusLabel1.Text = "Total Voters : ";
            // 
            // totalVotersValue
            // 
            this.totalVotersValue.Name = "totalVotersValue";
            this.totalVotersValue.Size = new System.Drawing.Size(16, 17);
            this.totalVotersValue.Text = "...";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(567, 24);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 20);
            this.button3.TabIndex = 13;
            this.button3.Text = "Test Print Mayor";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(669, 24);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(123, 20);
            this.button4.TabIndex = 14;
            this.button4.Text = "Test Print Vice Mayor";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Voters_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 585);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.comboBrgy);
            this.Controls.Add(this.comboCluster);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboPurok);
            this.Controls.Add(this.btnAddVoter);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Voters_List";
            this.Text = "Voters";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.Voters_List_Activated);
            this.Load += new System.EventHandler(this.Voters_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCluster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceBarangay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePurok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceFilterBarangay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceFilterPurok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceFilterCluster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSourcePerson;
        private System.Windows.Forms.BindingSource bindingSourceBarangay;
        private System.Windows.Forms.BindingSource bindingSourcePurok;
        private System.Windows.Forms.BindingSource bindingSourceCluster;
        private System.Windows.Forms.BindingSource bindingSourceFilterPurok;
        private System.Windows.Forms.BindingSource bindingSourceFilterCluster;
        private System.Windows.Forms.Button btnAddVoter;
        private System.Windows.Forms.BindingSource bindingSourceFilterBarangay;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precinctDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fullname;
        private System.Windows.Forms.DataGridViewButtonColumn barangayDataGridViewComboBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn buttonColumnPurok;
        private System.Windows.Forms.DataGridViewButtonColumn clusterDataGridViewComboBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn updateColumn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem changeBarangayToolStripMenuItem;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colFullname;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecinct;
        private DevExpress.XtraGrid.Columns.GridColumn colBarangay;
        private DevExpress.XtraGrid.Columns.GridColumn colPurok;
        private DevExpress.XtraGrid.Columns.GridColumn colCluster;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.ToolStripMenuItem changeClusterLeaderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePurokToolStripMenu;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBrgy;
        private System.Windows.Forms.ComboBox comboCluster;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboPurok;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel totalVotersValue;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}