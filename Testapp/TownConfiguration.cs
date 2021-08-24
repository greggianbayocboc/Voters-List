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
    public partial class TownConfiguration : Form
    {
        public TownRepository townRepository = new TownRepository();
        public BarangayRepository barangayRepository = new BarangayRepository(); 
        public TownConfiguration()
        {
            InitializeComponent();
        }

        private void TownConfiguration_Load(object sender, EventArgs e)
        {

            initializeData();

        }


        void initializeData()
        {
            //Load Town Name
            Town town = townRepository.getFirst();

            textBoxTown.Text = town.TownName;

            //Load Barangays
            List<Barangay> barangays = barangayRepository.getAll();
            
            listBoxBarangay.DataSource = barangays;
        }

        private void btnAddBarangay_Click(object sender, EventArgs e)
        {
            BarangayForm frm = new BarangayForm();
            frm.Text = "New Barangay";
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BarangayForm frm = new BarangayForm();
            frm.barangay = listBoxBarangay.SelectedItem as Barangay;
            frm.Text = "Edit Barangay";
            frm.ShowDialog();
        }
    }
}
