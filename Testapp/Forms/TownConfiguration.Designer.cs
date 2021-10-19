namespace Testapp
{
    partial class TownConfiguration
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTown = new System.Windows.Forms.TextBox();
            this.listBoxBarangay = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxPurok = new System.Windows.Forms.ListBox();
            this.labelSelectedBarangay = new System.Windows.Forms.Label();
            this.labelSelectedPurok = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listBoxCluster = new System.Windows.Forms.ListBox();
            this.btnAddBarangay = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnEditPurok = new System.Windows.Forms.Button();
            this.btnAddPurok = new System.Windows.Forms.Button();
            this.btnAddCluster = new System.Windows.Forms.Button();
            this.btnEditCluster = new System.Windows.Forms.Button();
            this.btnRemoveBarangay = new System.Windows.Forms.Button();
            this.btnRemovePurok = new System.Windows.Forms.Button();
            this.btnRemoveCluster = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "City/Town Name : ";
            // 
            // textBoxTown
            // 
            this.textBoxTown.Enabled = false;
            this.textBoxTown.Location = new System.Drawing.Point(16, 27);
            this.textBoxTown.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTown.Name = "textBoxTown";
            this.textBoxTown.Size = new System.Drawing.Size(178, 21);
            this.textBoxTown.TabIndex = 1;
            // 
            // listBoxBarangay
            // 
            this.listBoxBarangay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxBarangay.DisplayMember = "barangay_name";
            this.listBoxBarangay.FormattingEnabled = true;
            this.listBoxBarangay.Location = new System.Drawing.Point(16, 81);
            this.listBoxBarangay.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxBarangay.Name = "listBoxBarangay";
            this.listBoxBarangay.Size = new System.Drawing.Size(285, 615);
            this.listBoxBarangay.TabIndex = 2;
            this.listBoxBarangay.SelectedIndexChanged += new System.EventHandler(this.listBoxBarangay_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "List of Barangays";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(319, 65);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "List of Purok in Barangay";
            // 
            // listBoxPurok
            // 
            this.listBoxPurok.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxPurok.FormattingEnabled = true;
            this.listBoxPurok.Location = new System.Drawing.Point(321, 81);
            this.listBoxPurok.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxPurok.Name = "listBoxPurok";
            this.listBoxPurok.Size = new System.Drawing.Size(285, 615);
            this.listBoxPurok.TabIndex = 4;
            this.listBoxPurok.SelectedIndexChanged += new System.EventHandler(this.listBoxPurok_SelectedIndexChanged);
            // 
            // labelSelectedBarangay
            // 
            this.labelSelectedBarangay.AutoSize = true;
            this.labelSelectedBarangay.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectedBarangay.Location = new System.Drawing.Point(449, 65);
            this.labelSelectedBarangay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSelectedBarangay.Name = "labelSelectedBarangay";
            this.labelSelectedBarangay.Size = new System.Drawing.Size(108, 13);
            this.labelSelectedBarangay.TabIndex = 6;
            this.labelSelectedBarangay.Text = "[Select Barangay]";
            // 
            // labelSelectedPurok
            // 
            this.labelSelectedPurok.AutoSize = true;
            this.labelSelectedPurok.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectedPurok.Location = new System.Drawing.Point(737, 65);
            this.labelSelectedPurok.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSelectedPurok.Name = "labelSelectedPurok";
            this.labelSelectedPurok.Size = new System.Drawing.Size(88, 13);
            this.labelSelectedPurok.TabIndex = 9;
            this.labelSelectedPurok.Text = "[Select Purok]";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(619, 65);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "List of Cluster in Purok";
            // 
            // listBoxCluster
            // 
            this.listBoxCluster.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxCluster.FormattingEnabled = true;
            this.listBoxCluster.Location = new System.Drawing.Point(622, 81);
            this.listBoxCluster.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxCluster.Name = "listBoxCluster";
            this.listBoxCluster.Size = new System.Drawing.Size(285, 615);
            this.listBoxCluster.TabIndex = 7;
            this.listBoxCluster.SelectedIndexChanged += new System.EventHandler(this.listBoxCluster_SelectedIndexChanged);
            // 
            // btnAddBarangay
            // 
            this.btnAddBarangay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddBarangay.Location = new System.Drawing.Point(16, 702);
            this.btnAddBarangay.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddBarangay.Name = "btnAddBarangay";
            this.btnAddBarangay.Size = new System.Drawing.Size(86, 23);
            this.btnAddBarangay.TabIndex = 10;
            this.btnAddBarangay.Text = "Add Barangay";
            this.btnAddBarangay.UseVisualStyleBackColor = true;
            this.btnAddBarangay.Click += new System.EventHandler(this.btnAddBarangay_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(106, 702);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Edit Barangay";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEditPurok
            // 
            this.btnEditPurok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditPurok.Location = new System.Drawing.Point(412, 703);
            this.btnEditPurok.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditPurok.Name = "btnEditPurok";
            this.btnEditPurok.Size = new System.Drawing.Size(86, 23);
            this.btnEditPurok.TabIndex = 13;
            this.btnEditPurok.Text = "Edit Purok";
            this.btnEditPurok.UseVisualStyleBackColor = true;
            this.btnEditPurok.Click += new System.EventHandler(this.btnEditPurok_Click);
            // 
            // btnAddPurok
            // 
            this.btnAddPurok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddPurok.Location = new System.Drawing.Point(321, 703);
            this.btnAddPurok.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddPurok.Name = "btnAddPurok";
            this.btnAddPurok.Size = new System.Drawing.Size(86, 23);
            this.btnAddPurok.TabIndex = 12;
            this.btnAddPurok.Text = "Add Purok";
            this.btnAddPurok.UseVisualStyleBackColor = true;
            this.btnAddPurok.Click += new System.EventHandler(this.btnAddPurok_Click);
            // 
            // btnAddCluster
            // 
            this.btnAddCluster.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddCluster.Location = new System.Drawing.Point(622, 702);
            this.btnAddCluster.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddCluster.Name = "btnAddCluster";
            this.btnAddCluster.Size = new System.Drawing.Size(86, 23);
            this.btnAddCluster.TabIndex = 14;
            this.btnAddCluster.Text = "Add Cluster";
            this.btnAddCluster.UseVisualStyleBackColor = true;
            this.btnAddCluster.Click += new System.EventHandler(this.btnAddCluster_Click);
            // 
            // btnEditCluster
            // 
            this.btnEditCluster.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditCluster.Location = new System.Drawing.Point(713, 702);
            this.btnEditCluster.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditCluster.Name = "btnEditCluster";
            this.btnEditCluster.Size = new System.Drawing.Size(86, 23);
            this.btnEditCluster.TabIndex = 15;
            this.btnEditCluster.Text = "Edit Cluster";
            this.btnEditCluster.UseVisualStyleBackColor = true;
            this.btnEditCluster.Click += new System.EventHandler(this.btnEditCluster_Click);
            // 
            // btnRemoveBarangay
            // 
            this.btnRemoveBarangay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemoveBarangay.Enabled = false;
            this.btnRemoveBarangay.Location = new System.Drawing.Point(197, 702);
            this.btnRemoveBarangay.Name = "btnRemoveBarangay";
            this.btnRemoveBarangay.Size = new System.Drawing.Size(80, 23);
            this.btnRemoveBarangay.TabIndex = 16;
            this.btnRemoveBarangay.Text = "Remove";
            this.btnRemoveBarangay.UseVisualStyleBackColor = true;
            this.btnRemoveBarangay.Click += new System.EventHandler(this.btnRemoveBarangay_Click);
            // 
            // btnRemovePurok
            // 
            this.btnRemovePurok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemovePurok.Enabled = false;
            this.btnRemovePurok.Location = new System.Drawing.Point(503, 702);
            this.btnRemovePurok.Name = "btnRemovePurok";
            this.btnRemovePurok.Size = new System.Drawing.Size(80, 23);
            this.btnRemovePurok.TabIndex = 17;
            this.btnRemovePurok.Text = "Remove";
            this.btnRemovePurok.UseVisualStyleBackColor = true;
            this.btnRemovePurok.Click += new System.EventHandler(this.btnRemovePurok_Click);
            // 
            // btnRemoveCluster
            // 
            this.btnRemoveCluster.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemoveCluster.Enabled = false;
            this.btnRemoveCluster.Location = new System.Drawing.Point(804, 702);
            this.btnRemoveCluster.Name = "btnRemoveCluster";
            this.btnRemoveCluster.Size = new System.Drawing.Size(80, 23);
            this.btnRemoveCluster.TabIndex = 18;
            this.btnRemoveCluster.Text = "Remove";
            this.btnRemoveCluster.UseVisualStyleBackColor = true;
            this.btnRemoveCluster.Click += new System.EventHandler(this.btnRemoveCluster_Click);
            // 
            // TownConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 750);
            this.Controls.Add(this.btnRemoveCluster);
            this.Controls.Add(this.btnRemovePurok);
            this.Controls.Add(this.btnRemoveBarangay);
            this.Controls.Add(this.btnEditCluster);
            this.Controls.Add(this.btnAddCluster);
            this.Controls.Add(this.btnEditPurok);
            this.Controls.Add(this.btnAddPurok);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAddBarangay);
            this.Controls.Add(this.labelSelectedPurok);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listBoxCluster);
            this.Controls.Add(this.labelSelectedBarangay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxPurok);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxBarangay);
            this.Controls.Add(this.textBoxTown);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TownConfiguration";
            this.Text = "Town Configuration";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TownConfiguration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTown;
        private System.Windows.Forms.ListBox listBoxBarangay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxPurok;
        private System.Windows.Forms.Label labelSelectedBarangay;
        private System.Windows.Forms.Label labelSelectedPurok;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBoxCluster;
        private System.Windows.Forms.Button btnAddBarangay;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEditPurok;
        private System.Windows.Forms.Button btnAddPurok;
        private System.Windows.Forms.Button btnAddCluster;
        private System.Windows.Forms.Button btnEditCluster;
        private System.Windows.Forms.Button btnRemoveBarangay;
        private System.Windows.Forms.Button btnRemovePurok;
        private System.Windows.Forms.Button btnRemoveCluster;
    }
}