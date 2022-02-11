using DevExpress.XtraEditors;
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
    public partial class VotersByLeadersForm : Form
    {
        public PersonRepository personRepository = new PersonRepository();
        public TownRepository townRepository = new TownRepository();
        public BarangayRepository barangayRepository = new BarangayRepository();
        public PurokRepository purokRepository = new PurokRepository();
        public ClusterRepository clusterRepository = new ClusterRepository();
        public VotersByLeadersForm()
        {
            InitializeComponent();
        }

        private void VotersByLeadersForm_Load(object sender, EventArgs e)
        {
            initializeData();
        }

        void initializeData()
        {
            List<Barangay> barangays = barangayRepository.getAll();
            comboBoxBarangay.Properties.Items.AddRange(barangays);
        }

        void clearSelection()
        {
            comboBoxPurok.Properties.Items.Clear();
            comboBoxPurok.Text = "";
            comboBoxCluster.Properties.Items.Clear();
            comboBoxCluster.Text = "";
        }

        private void comboBoxEdit1_Properties_SelectedValueChanged(object sender, EventArgs e)
        {
            clearSelection();
            Barangay selected = (Barangay)comboBoxBarangay.SelectedItem;
            List<Purok> puroks = purokRepository.listPurokByBarangay(selected.ID);
            comboBoxPurok.Properties.Items.AddRange(puroks);
        }

        private void comboBoxEdit2_Properties_SelectedValueChanged(object sender, EventArgs e)
        {
            comboBoxCluster.Properties.Items.Clear();
            Purok selected = (Purok)comboBoxPurok.SelectedItem;
            List<Cluster> clusters = clusterRepository.listClusterByPurok(selected.ID);
            comboBoxCluster.Properties.Items.AddRange(clusters);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (comboBoxCluster.SelectedItem != null && comboBoxBarangay.SelectedItem != null && comboBoxPurok.SelectedItem != null)
            {
                int barangayId = ((Barangay)comboBoxBarangay.SelectedItem).ID;
                int purokId = ((Purok)comboBoxPurok.SelectedItem).ID;
                int clusterId = ((Cluster)comboBoxCluster.SelectedItem).ID;
                gridControl1.DataSource = personRepository.listPersonByBarangayPurokCluster(barangayId, purokId, clusterId);
            }
            else
            {
                MessageBox.Show("Please select Barangay, Purok and Cluster Leader!");
            }
        }

        private void repositoryItemRadioGroup1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                RadioGroup rg = ((RadioGroup)sender);
                string selected = rg.EditValue.ToString();
                Person va = (Person)gridView1.GetFocusedRow();
                switch (gridView1.FocusedColumn.FieldName)
                {
                    case "Mayor":
                        va.Mayor = selected;
                        break;
                    case "Vice":
                        va.Vice = selected;
                        break;
                    case "Councilor1":
                        va.Councilor1 = selected;
                        break;
                    case "Councilor2":
                        va.Councilor3 = selected;
                        break;
                    case "Councilor3":
                        va.Councilor4 = selected;
                        break;
                    case "Councilor4":
                        va.Councilor4 = selected;
                        break;
                    case "Councilor5":
                        va.Councilor5 = selected;
                        break;
                    case "Councilor6":
                        va.Councilor6 = selected;
                        break;
                    case "Councilor7":
                        va.Councilor7 = selected;
                        break;
                    case "Councilor8":
                        va.Councilor8 = selected;
                        break;
                    default:
                        break;
                }
                personRepository.Save(va);
            }
            catch (Exception ex)
            { }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (comboBoxCluster.SelectedItem != null && comboBoxBarangay.SelectedItem != null && comboBoxPurok.SelectedItem != null)
            {
                int barangayId = ((Barangay)comboBoxBarangay.SelectedItem).ID;
                int purokId = ((Purok)comboBoxPurok.SelectedItem).ID;
                int clusterId = ((Cluster)comboBoxCluster.SelectedItem).ID;
                gridControl1.DataSource = personRepository.listPersonByBarangayPurokCluster(barangayId, purokId, clusterId);
            }
            else
            {
                MessageBox.Show("Please select Barangay, Purok and Cluster Leader!");
            }
        }
    }
}
