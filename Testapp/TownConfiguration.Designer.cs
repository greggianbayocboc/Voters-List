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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listBoxCluster = new System.Windows.Forms.ListBox();
            this.btnAddBarangay = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            this.listBoxBarangay.DisplayMember = "barangay_name";
            this.listBoxBarangay.FormattingEnabled = true;
            this.listBoxBarangay.ItemHeight = 16;
            this.listBoxBarangay.Location = new System.Drawing.Point(22, 100);
            this.listBoxBarangay.Name = "listBoxBarangay";
            this.listBoxBarangay.Size = new System.Drawing.Size(301, 244);
            this.listBoxBarangay.TabIndex = 2;
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
            this.label3.Location = new System.Drawing.Point(326, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "List of Purok in Barangay";
            // 
            // listBoxPurok
            // 
            this.listBoxPurok.FormattingEnabled = true;
            this.listBoxPurok.ItemHeight = 16;
            this.listBoxPurok.Location = new System.Drawing.Point(329, 100);
            this.listBoxPurok.Name = "listBoxPurok";
            this.listBoxPurok.Size = new System.Drawing.Size(307, 244);
            this.listBoxPurok.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(499, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "[Select Barangay]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(795, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "[Select Purok]";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(639, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "List of Cluster in Purok";
            // 
            // listBoxCluster
            // 
            this.listBoxCluster.FormattingEnabled = true;
            this.listBoxCluster.ItemHeight = 16;
            this.listBoxCluster.Location = new System.Drawing.Point(642, 100);
            this.listBoxCluster.Name = "listBoxCluster";
            this.listBoxCluster.Size = new System.Drawing.Size(307, 244);
            this.listBoxCluster.TabIndex = 7;
            // 
            // btnAddBarangay
            // 
            this.btnAddBarangay.Location = new System.Drawing.Point(22, 350);
            this.btnAddBarangay.Name = "btnAddBarangay";
            this.btnAddBarangay.Size = new System.Drawing.Size(115, 28);
            this.btnAddBarangay.TabIndex = 10;
            this.btnAddBarangay.Text = "Add Barangay";
            this.btnAddBarangay.UseVisualStyleBackColor = true;
            this.btnAddBarangay.Click += new System.EventHandler(this.btnAddBarangay_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(143, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 28);
            this.button1.TabIndex = 11;
            this.button1.Text = "Edit Barangay";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TownConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 540);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAddBarangay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listBoxCluster);
            this.Controls.Add(this.label4);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBoxCluster;
        private System.Windows.Forms.Button btnAddBarangay;
        private System.Windows.Forms.Button button1;
    }
}