using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Testapp.Models;
using Testapp.Repository;

namespace Testapp
{
    public partial class BarangayForm : Form
    {

        public Barangay barangay = new Barangay();
        public BarangayRepository barangayRepository = new BarangayRepository();

        public BarangayForm()
        {
            InitializeComponent();
        }

        private void BarangayForm_Load(object sender, EventArgs e)
        {
            textBoxBarangayName.Text = barangay.BarangayName;
            textBoxCoordinator.Text = barangay.Coordinator;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            barangayRepository.Save(barangay);
            this.Close();
        }

        private void textBoxBarangayName_TextChanged(object sender, EventArgs e)
        {
            barangay.BarangayName = textBoxBarangayName.Text;
        }

        private void textBoxCoordinator_TextChanged(object sender, EventArgs e)
        {
            barangay.Coordinator = textBoxCoordinator.Text;
        }
    }
}
