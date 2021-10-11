namespace Testapp
{
    partial class ClusterForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPurokName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPurokLeader = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxBarangayName = new System.Windows.Forms.TextBox();
            this.textBoxClusterLeader = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(24, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Barangay Name";
            // 
            // textBoxPurokName
            // 
            this.textBoxPurokName.Enabled = false;
            this.textBoxPurokName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPurokName.Location = new System.Drawing.Point(24, 84);
            this.textBoxPurokName.Name = "textBoxPurokName";
            this.textBoxPurokName.Size = new System.Drawing.Size(339, 26);
            this.textBoxPurokName.TabIndex = 4;
            this.textBoxPurokName.TextChanged += new System.EventHandler(this.textBoxPurokName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Purok Name";
            // 
            // textBoxPurokLeader
            // 
            this.textBoxPurokLeader.Enabled = false;
            this.textBoxPurokLeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPurokLeader.Location = new System.Drawing.Point(24, 137);
            this.textBoxPurokLeader.Name = "textBoxPurokLeader";
            this.textBoxPurokLeader.Size = new System.Drawing.Size(339, 26);
            this.textBoxPurokLeader.TabIndex = 6;
            this.textBoxPurokLeader.TextChanged += new System.EventHandler(this.textBoxPurokLeader_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Purok Leader";
            // 
            // textBoxBarangayName
            // 
            this.textBoxBarangayName.Enabled = false;
            this.textBoxBarangayName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBarangayName.Location = new System.Drawing.Point(24, 32);
            this.textBoxBarangayName.Name = "textBoxBarangayName";
            this.textBoxBarangayName.Size = new System.Drawing.Size(339, 26);
            this.textBoxBarangayName.TabIndex = 2;
            // 
            // textBoxClusterLeader
            // 
            this.textBoxClusterLeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxClusterLeader.Location = new System.Drawing.Point(24, 189);
            this.textBoxClusterLeader.Name = "textBoxClusterLeader";
            this.textBoxClusterLeader.Size = new System.Drawing.Size(339, 26);
            this.textBoxClusterLeader.TabIndex = 10;
            this.textBoxClusterLeader.TextChanged += new System.EventHandler(this.textBoxClusterLeader_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Cluster Leader";
            // 
            // ClusterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 296);
            this.Controls.Add(this.textBoxClusterLeader);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxPurokLeader);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPurokName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxBarangayName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "ClusterForm";
            this.Text = "Cluster Form";
            this.Load += new System.EventHandler(this.BarangayForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPurokName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPurokLeader;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxBarangayName;
        private System.Windows.Forms.TextBox textBoxClusterLeader;
        private System.Windows.Forms.Label label5;
    }
}