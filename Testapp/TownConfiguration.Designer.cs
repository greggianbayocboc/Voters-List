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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "City/Town Name : ";
            // 
            // textBoxTown
            // 
            this.textBoxTown.Enabled = false;
            this.textBoxTown.Location = new System.Drawing.Point(22, 33);
            this.textBoxTown.Name = "textBoxTown";
            this.textBoxTown.Size = new System.Drawing.Size(236, 22);
            this.textBoxTown.TabIndex = 1;
            // 
            // listBoxBarangay
            // 
            this.listBoxBarangay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxBarangay.DisplayMember = "barangay_name";
            this.listBoxBarangay.FormattingEnabled = true;
            this.listBoxBarangay.ItemHeight = 16;
            this.listBoxBarangay.Location = new System.Drawing.Point(22, 100);
            this.listBoxBarangay.Name = "listBoxBarangay";
            this.listBoxBarangay.Size = new System.Drawing.Size(301, 308);
            this.listBoxBarangay.TabIndex = 2;
            this.listBoxBarangay.SelectedIndexChanged += new System.EventHandler(this.listBoxBarangay_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "List of Barangays";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(357, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "List of Purok in Barangay";
            // 
            // listBoxPurok
            // 
            this.listBoxPurok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.listBoxPurok.FormattingEnabled = true;
            this.listBoxPurok.ItemHeight = 16;
            this.listBoxPurok.Location = new System.Drawing.Point(360, 100);
            this.listBoxPurok.Name = "listBoxPurok";
            this.listBoxPurok.Size = new System.Drawing.Size(307, 308);
            this.listBoxPurok.TabIndex = 4;
            // 
            // labelSelectedBarangay
            // 
            this.labelSelectedBarangay.AutoSize = true;
            this.labelSelectedBarangay.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectedBarangay.Location = new System.Drawing.Point(530, 80);
            this.labelSelectedBarangay.Name = "labelSelectedBarangay";
            this.labelSelectedBarangay.Size = new System.Drawing.Size(137, 17);
            this.labelSelectedBarangay.TabIndex = 6;
            this.labelSelectedBarangay.Text = "[Select Barangay]";
            // 
            // labelSelectedPurok
            // 
            this.labelSelectedPurok.AutoSize = true;
            this.labelSelectedPurok.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectedPurok.Location = new System.Drawing.Point(858, 80);
            this.labelSelectedPurok.Name = "labelSelectedPurok";
            this.labelSelectedPurok.Size = new System.Drawing.Size(110, 17);
            this.labelSelectedPurok.TabIndex = 9;
            this.labelSelectedPurok.Text = "[Select Purok]";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(702, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "List of Cluster in Purok";
            // 
            // listBoxCluster
            // 
            this.listBoxCluster.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxCluster.FormattingEnabled = true;
            this.listBoxCluster.ItemHeight = 16;
            this.listBoxCluster.Location = new System.Drawing.Point(705, 100);
            this.listBoxCluster.Name = "listBoxCluster";
            this.listBoxCluster.Size = new System.Drawing.Size(307, 308);
            this.listBoxCluster.TabIndex = 7;
            // 
            // btnAddBarangay
            // 
            this.btnAddBarangay.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAddBarangay.Location = new System.Drawing.Point(22, 417);
            this.btnAddBarangay.Name = "btnAddBarangay";
            this.btnAddBarangay.Size = new System.Drawing.Size(115, 28);
            this.btnAddBarangay.TabIndex = 10;
            this.btnAddBarangay.Text = "Add Barangay";
            this.btnAddBarangay.UseVisualStyleBackColor = true;
            this.btnAddBarangay.Click += new System.EventHandler(this.btnAddBarangay_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Location = new System.Drawing.Point(143, 417);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 28);
            this.button1.TabIndex = 11;
            this.button1.Text = "Edit Barangay";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEditPurok
            // 
            this.btnEditPurok.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEditPurok.Location = new System.Drawing.Point(481, 417);
            this.btnEditPurok.Name = "btnEditPurok";
            this.btnEditPurok.Size = new System.Drawing.Size(115, 28);
            this.btnEditPurok.TabIndex = 13;
            this.btnEditPurok.Text = "Edit Purok";
            this.btnEditPurok.UseVisualStyleBackColor = true;
            // 
            // btnAddPurok
            // 
            this.btnAddPurok.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAddPurok.Location = new System.Drawing.Point(360, 417);
            this.btnAddPurok.Name = "btnAddPurok";
            this.btnAddPurok.Size = new System.Drawing.Size(115, 28);
            this.btnAddPurok.TabIndex = 12;
            this.btnAddPurok.Text = "Add Purok";
            this.btnAddPurok.UseVisualStyleBackColor = true;
            this.btnAddPurok.Click += new System.EventHandler(this.btnAddPurok_Click);
            // 
            // btnAddCluster
            // 
            this.btnAddCluster.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAddCluster.Location = new System.Drawing.Point(674, 417);
            this.btnAddCluster.Name = "btnAddCluster";
            this.btnAddCluster.Size = new System.Drawing.Size(115, 28);
            this.btnAddCluster.TabIndex = 14;
            this.btnAddCluster.Text = "Add Purok";
            this.btnAddCluster.UseVisualStyleBackColor = true;
            // 
            // btnEditCluster
            // 
            this.btnEditCluster.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEditCluster.Location = new System.Drawing.Point(795, 417);
            this.btnEditCluster.Name = "btnEditCluster";
            this.btnEditCluster.Size = new System.Drawing.Size(115, 28);
            this.btnEditCluster.TabIndex = 15;
            this.btnEditCluster.Text = "Edit Purok";
            this.btnEditCluster.UseVisualStyleBackColor = true;
            // 
            // TownConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 460);
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
            this.Name = "TownConfiguration";
            this.Text = "TownConfiguration";
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
    }
}