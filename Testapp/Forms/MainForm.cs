using gregg.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testapp.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void configurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int count = this.MdiChildren.Where(child => child.GetType() == typeof(TownConfiguration)).Count();

            if (count == 0) {
                TownConfiguration myForm = new TownConfiguration();

                // Set the Parent Form of the Child window.
                myForm.MdiParent = this;
                // Display the new form.
                myForm.Show();
            }
        }

        private void MainForm_MdiChildActivate(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null)
                tabForms.Visible = false; // If no any child form, hide tabControl
            else
            {
                this.ActiveMdiChild.WindowState = FormWindowState.Maximized; // Child form always maximized

                // If child form is new and no has tabPage, create new tabPage
                if (this.ActiveMdiChild.Tag == null)
                {
                    // Add a tabPage to tabControl with child form caption
                    TabPage tp = new TabPage(this.ActiveMdiChild.Text);
                    tp.Tag = this.ActiveMdiChild;
                    tp.Parent = tabForms;
                    tabForms.SelectedTab = tp;

                    this.ActiveMdiChild.Tag = tp;
                    this.ActiveMdiChild.FormClosed += new FormClosedEventHandler(ActiveMdiChild_FormClosed);
                }

                if (!tabForms.Visible) tabForms.Visible = true;
            }
        }

        private void ActiveMdiChild_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((sender as Form).Tag as TabPage).Dispose();
        }

        private void tabForms_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((tabForms.SelectedTab != null) && (tabForms.SelectedTab.Tag != null))
                (tabForms.SelectedTab.Tag as Form).Select();
        }

        private void votersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        private void viewAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int count = this.MdiChildren.Where(child => child.GetType() == typeof(Voters_List)).Count();

            if (count == 0)
            {
                Voters_List myForm = new Voters_List();

                // Set the Parent Form of the Child window.
                myForm.MdiParent = this;
                // Display the new form.
                myForm.Show();
            }
        }

        private void importFromExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int count = this.MdiChildren.Where(child => child.GetType() == typeof(ImportVotersForm)).Count();

            if (count == 0)
            {
                ImportVotersForm myForm = new ImportVotersForm();

                // Set the Parent Form of the Child window.
                myForm.MdiParent = this;
                // Display the new form.
                myForm.Show();
            }
        }
    }
}
