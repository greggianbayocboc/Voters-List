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

namespace gregg.Forms
{
    public partial class BarangayPurokClusterSelect : DevExpress.XtraEditors.XtraForm
    {
        public int Barangay = -1;
        public int Purok = -1;
        public int Cluster = -1;
        public BarangayRepository barangayRepository = new BarangayRepository();
        public PurokRepository purokRepository = new PurokRepository();
        public ClusterRepository clusterRepository = new ClusterRepository();
        public BarangayPurokClusterSelect()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (comboBoxEditBarangay.SelectedItem != null)
            {
                Barangay barangay = barangayRepository.getByName((string)comboBoxEditBarangay.SelectedItem);
                this.Barangay = barangay.ID;

                if (comboBoxEditPurok.SelectedItem != null)
                {
                    int barangayId = barangay.ID;
                    Purok purok = purokRepository.getPurokByBarangayIdAndPurokName(barangayId, (string)comboBoxEditPurok.SelectedItem);
                    this.Purok = purok.ID;

                    if (comboBoxEditCluster.SelectedItem != null)
                    {
                        Cluster cluster = clusterRepository.getClusterByPurokIdAndClusterName(purok.ID, (string)comboBoxEditCluster.SelectedItem);
                        this.Cluster = cluster.ID;
                    }
                }
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
           
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BarangayPurokClusterSelect_Load(object sender, EventArgs e)
        {
            List<Barangay> barangays = barangayRepository.getAll();
            List<Cluster> clusters = clusterRepository.getAll();
            List<Purok> puroks = purokRepository.getAll();
            comboBoxEditBarangay.Properties.Items.Insert(0, "");
            foreach (Barangay brgy in barangays)
            {
                //repositoryItemComboBox2.Items.Add(brgy);
                comboBoxEditBarangay.Properties.Items.Add(brgy.BarangayName);
            }

          
        }

        private void comboBoxEditBarangay_SelectedValueChanged(object sender, EventArgs e)
        {
            comboBoxEditPurok.Properties.Items.Clear();
            if (comboBoxEditBarangay.SelectedText != string.Empty)
            {
                Barangay barangay = barangayRepository.getByName((string)comboBoxEditBarangay.SelectedItem);
                List<Purok> puroks = purokRepository.listPurokByBarangay(barangay.ID);
               // puroks.Insert(0, new Purok(false));
                foreach (Purok purok in puroks)
                {
                    comboBoxEditPurok.Properties.Items.Add(purok.PurokName);
                }
                comboBoxEditPurok.Properties.Items.Insert(0, "");
            }
            else
            {
                comboBoxEditPurok.Properties.Items.Clear();
            }
        }

        private void comboBoxEditPurok_SelectedValueChanged(object sender, EventArgs e)
        {
            comboBoxEditCluster.Properties.Items.Clear();
            if (comboBoxEditPurok.SelectedText != string.Empty)
            {
                int barangayId = barangayRepository.getIdByName((string)comboBoxEditBarangay.SelectedItem);
                Purok purok = purokRepository.getPurokByBarangayIdAndPurokName(barangayId, (string)comboBoxEditPurok.SelectedItem);
                // puroks.Insert(0, new Purok(false));
                List<Cluster> clusters = clusterRepository.listClusterByPurok(purok.ID);
                foreach (Cluster cluster in clusters)
                {
                    comboBoxEditCluster.Properties.Items.Add(cluster.Leader);
                }
                comboBoxEditCluster.Properties.Items.Insert(0, "");
            }
            else
            {
                comboBoxEditCluster.Properties.Items.Clear();
            }
        }

        private void comboBoxEditBarangay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
