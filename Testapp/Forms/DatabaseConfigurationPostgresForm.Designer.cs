namespace gregg.Forms
{
    partial class DatabaseConfigurationPostgresForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseConfigurationPostgresForm));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.textServer = new DevExpress.XtraEditors.TextEdit();
            this.textPort = new DevExpress.XtraEditors.TextEdit();
            this.textUsername = new DevExpress.XtraEditors.TextEdit();
            this.textPassword = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.textServer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPort.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPassword.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(25, 21);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(32, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Server";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(25, 47);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(20, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Port";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(23, 73);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Username";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(23, 99);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(46, 13);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Password";
            // 
            // textServer
            // 
            this.textServer.EditValue = "192.168.1.200";
            this.textServer.Location = new System.Drawing.Point(98, 18);
            this.textServer.Name = "textServer";
            this.textServer.Size = new System.Drawing.Size(238, 20);
            this.textServer.TabIndex = 4;
            this.textServer.EditValueChanged += new System.EventHandler(this.textServer_EditValueChanged);
            // 
            // textPort
            // 
            this.textPort.EditValue = "5432";
            this.textPort.Location = new System.Drawing.Point(98, 44);
            this.textPort.Name = "textPort";
            this.textPort.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.textPort.Size = new System.Drawing.Size(45, 20);
            this.textPort.TabIndex = 5;
            this.textPort.EditValueChanged += new System.EventHandler(this.textPort_EditValueChanged);
            // 
            // textUsername
            // 
            this.textUsername.EditValue = "postgres";
            this.textUsername.Location = new System.Drawing.Point(98, 70);
            this.textUsername.Name = "textUsername";
            this.textUsername.Size = new System.Drawing.Size(238, 20);
            this.textUsername.TabIndex = 6;
            this.textUsername.EditValueChanged += new System.EventHandler(this.textUsername_EditValueChanged);
            // 
            // textPassword
            // 
            this.textPassword.EditValue = "password";
            this.textPassword.Location = new System.Drawing.Point(98, 96);
            this.textPassword.Name = "textPassword";
            this.textPassword.Properties.PasswordChar = '*';
            this.textPassword.Size = new System.Drawing.Size(238, 20);
            this.textPassword.TabIndex = 7;
            this.textPassword.EditValueChanged += new System.EventHandler(this.textPassword_EditValueChanged);
            // 
            // simpleButton4
            // 
            this.simpleButton4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.simpleButton4.ImageOptions.ImageUri.Uri = "Apply";
            this.simpleButton4.Location = new System.Drawing.Point(145, 122);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(93, 38);
            this.simpleButton4.TabIndex = 9;
            this.simpleButton4.Text = "Cancel";
            // 
            // simpleButton3
            // 
            this.simpleButton3.ImageOptions.ImageUri.Uri = "Apply";
            this.simpleButton3.Location = new System.Drawing.Point(244, 122);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(92, 38);
            this.simpleButton3.TabIndex = 8;
            this.simpleButton3.Text = "OK";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // DatabaseConfigurationPostgresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 184);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textUsername);
            this.Controls.Add(this.textPort);
            this.Controls.Add(this.textServer);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "DatabaseConfigurationPostgresForm";
            this.Text = "Database Configuration";
            this.Load += new System.EventHandler(this.DatabaseConfigurationPostgresForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textServer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPort.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPassword.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit textServer;
        private DevExpress.XtraEditors.TextEdit textPort;
        private DevExpress.XtraEditors.TextEdit textUsername;
        private DevExpress.XtraEditors.TextEdit textPassword;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
    }
}