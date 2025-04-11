using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gregg.Forms
{
    public partial class DatabaseConfigurationPostgresForm : Form
    {
        public DatabaseConfigurationPostgresForm()
        {
            InitializeComponent();
        }

        private void DatabaseConfigurationPostgresForm_Load(object sender, EventArgs e)
        {
            textServer.Text = Properties.Settings.Default.server;
            textPort.Text = Properties.Settings.Default.port.ToString();
            textUsername.Text = Properties.Settings.Default.username;
            textPassword.Text = Properties.Settings.Default.password;
            textDatabase.Text = Properties.Settings.Default.database;
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void textServer_EditValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.server = textServer.Text;
        }

        private void textPort_EditValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.port = int.Parse(textPort.Text);
        }

        private void textUsername_EditValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.username = textUsername.Text;
        }

        private void textPassword_EditValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.password = textPassword.Text;
        }
    }
}
