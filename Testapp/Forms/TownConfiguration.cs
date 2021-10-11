using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Testapp.Helpers;
using Testapp.Models;
using Testapp.Repository;

namespace Testapp
{
    public partial class TownConfiguration : DevExpress.XtraEditors.XtraForm
    {
        public TownRepository townRepository = new TownRepository();
        public BarangayRepository barangayRepository = new BarangayRepository();
        public PurokRepository purokRepository = new PurokRepository();
        public ClusterRepository clusterRepository = new ClusterRepository();
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

        void updatePurokList()
        {
            List<Purok> puroks = purokRepository.listPurokByBarangay((listBoxBarangay.SelectedValue as Barangay).ID);
            listBoxPurok.DataSource = puroks;
            if (puroks.Count == 0)
            {
                labelSelectedPurok.Text = "[Select Purok]";
            }
            updateClusterList();
        }

        void updateClusterList()
        {
            if (listBoxPurok.SelectedValue != null)
            {
                List<Cluster> clusters = clusterRepository.listClusterByPurok((listBoxPurok.SelectedValue as Purok).ID);
                listBoxCluster.DataSource = clusters;
                if (clusters.Count == 0)
                {

                }
            }
            else
            {
                listBoxCluster.DataSource = new List<string>();
            }
        }


        private void btnAddBarangay_Click(object sender, EventArgs e)
        {
            BarangayForm frm = new BarangayForm();
            frm.Text = "New Barangay";
            frm.barangay = new Barangay();
            frm.barangay.isNew = true;
            frm.ShowDialog();
            initializeData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BarangayForm frm = new BarangayForm();
            frm.barangay = listBoxBarangay.SelectedItem as Barangay;
            frm.Text = "Edit Barangay";
            frm.ShowDialog();
            int selectedIndex = listBoxBarangay.SelectedIndex;
            initializeData();
            listBoxBarangay.SetSelected(selectedIndex, true);
        }

        private void listBoxBarangay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxBarangay.SelectedItem != null)
            {
                labelSelectedBarangay.Text = (listBoxBarangay.SelectedItem as Barangay).BarangayName;
                updatePurokList();
                btnRemoveBarangay.Enabled = true;
                btnRemovePurok.Enabled = listBoxPurok.Items.Count > 0;
                btnRemoveCluster.Enabled = listBoxCluster.Items.Count > 0;
            }
            else
            {
                labelSelectedBarangay.Text = "[Select Barangay]";
                labelSelectedPurok.Text = "[Select Purok]";
                btnRemoveBarangay.Enabled = false;
                btnRemovePurok.Enabled = false;
                btnRemoveCluster.Enabled = false;
            }
        }

        private void testLabel_Click(object sender, EventArgs e)
        {

        }

        private void btnAddPurok_Click(object sender, EventArgs e)
        {
            if (listBoxBarangay.SelectedItem != null)
            {
                PurokForm frm = new PurokForm();
                frm.barangay = listBoxBarangay.SelectedItem as Barangay;
                frm.purok = new Purok();
                frm.purok.isNew = true;
                frm.purok.Barangay = frm.barangay.ID;
                frm.Text = "Add Purok";
                frm.ShowDialog();
                updatePurokList();
            }
        }

        private void listBoxPurok_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxBarangay.SelectedItem != null)
            {
                labelSelectedPurok.Text = (listBoxPurok.SelectedItem as Purok).PurokName;
                updateClusterList();
                btnRemovePurok.Enabled = true;

                btnRemoveCluster.Enabled = listBoxPurok.Items.Count > 0;
            }
            else
            {
                labelSelectedPurok.Text = "[Select Purok]";

                btnRemovePurok.Enabled = false;

                btnRemoveCluster.Enabled = false;
            }
        }

        private void btnEditPurok_Click(object sender, EventArgs e)
        {
            if (listBoxBarangay.SelectedItem != null)
            {
                PurokForm frm = new PurokForm();
                frm.barangay = listBoxBarangay.SelectedItem as Barangay;
                if (listBoxPurok.SelectedItem != null) {
                    frm.purok = listBoxPurok.SelectedItem as Purok;
                    frm.purok.Barangay = frm.barangay.ID;
                    frm.Text = "Add Purok";

                    int selectedIndex = listBoxPurok.SelectedIndex;
                    frm.ShowDialog();
                    updatePurokList();
                    listBoxPurok.SetSelected(selectedIndex, true);
                }
            }
        }

        private void btnAddCluster_Click(object sender, EventArgs e)
        {
            if (listBoxPurok.SelectedItem != null)
            {
                ClusterForm frm = new ClusterForm();
                frm.barangay = listBoxBarangay.SelectedItem as Barangay;
                frm.purok = listBoxPurok.SelectedItem as Purok;
                frm.cluster = new Cluster();
                frm.cluster.isNew = true;
                frm.purok.Barangay = frm.barangay.ID;
                frm.Text = "Add Cluster";
                frm.ShowDialog();
                updateClusterList();
            }
        }

        private void btnEditCluster_Click(object sender, EventArgs e)
        {
            if (listBoxPurok.SelectedItem != null && listBoxCluster.SelectedItem!=null)
            {
                ClusterForm frm = new ClusterForm();
                frm.barangay = listBoxBarangay.SelectedItem as Barangay;
                frm.purok = listBoxPurok.SelectedItem as Purok;
                frm.cluster = listBoxCluster.SelectedItem as Cluster;
                frm.Text = "Edit Cluster";
                frm.ShowDialog();
                updateClusterList();
            }
        }

        private void btnRemoveBarangay_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove "+listBoxBarangay.SelectedItem.ToString()+"?", "Confirm Removal", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                barangayRepository.removeBarangay(DatabaseHelper.getID<Barangay>(listBoxBarangay.SelectedItem));
                MessageBox.Show("Barangay Removed!");
                initializeData();
            }
        }

        private void btnRemovePurok_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove " + listBoxPurok.SelectedItem.ToString() + "?", "Confirm Removal", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                purokRepository.Delete(listBoxPurok.SelectedItem as Purok);
            }
        }

        private void btnRemoveCluster_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove " + listBoxCluster.SelectedItem.ToString() + "?", "Confirm Removal", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                clusterRepository.Delete(listBoxCluster.SelectedItem as Cluster);
                updateClusterList();
            }
        }

        private void listBoxCluster_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxCluster.SelectedItem != null)
            {
                btnRemoveCluster.Enabled = true;
            }
            else
            {
                btnRemoveCluster.Enabled = false;
            }
        }
    }
}
