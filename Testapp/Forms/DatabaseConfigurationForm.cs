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
    public partial class DatabaseConfigurationForm : Form
    {
        public DatabaseConfigurationForm()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textEdit1.Text = openFileDialog1.FileName;

                string qstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\""+ openFileDialog1.FileName+ "\"";
                memoEdit1.Text = qstring;
                Properties.Settings.Default.ConnectionString = qstring;
                Properties.Settings.Default.Save();
            }
        }

        private void DatabaseConfigurationForm_Load(object sender, EventArgs e)
        {
            memoEdit1.Text = Properties.Settings.Default.ConnectionString;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ConnectionString = "";
            memoEdit1.Text = "";
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void DatabaseConfigurationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Properties.Settings.Default.ConnectionString == string.Empty)
            {
                MessageBox.Show("Cannot continue without Database Configuration!");
            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
