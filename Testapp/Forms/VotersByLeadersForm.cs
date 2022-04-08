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

        private List<Person> persons = new List<Person>();
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
            loadVoters();
        }

        private void loadVoters()
        {
            if (comboBoxCluster.SelectedItem != "" && comboBoxBarangay.SelectedItem != "" && comboBoxPurok.SelectedItem != "")
            {
                int barangayId = ((Barangay)comboBoxBarangay.SelectedItem).ID;
                int purokId = ((Purok)comboBoxPurok.SelectedItem).ID;
                int clusterId = ((Cluster)comboBoxCluster.SelectedItem).ID;
                persons = personRepository.listPersonByBarangayPurokCluster(barangayId, purokId, clusterId);
                gridControl1.DataSource = persons;
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
                persons = personRepository.listPersonByBarangayPurokCluster(barangayId, purokId, clusterId);
                gridControl1.DataSource = persons;
                MultipleVoterSelect msl = new MultipleVoterSelect();
                msl.barangayId = barangayId;
                msl.purokId = purokId;
                msl.clusterId = clusterId;
                msl.reloadListCallback = new MultipleVoterSelect.reloadListDelegate(this.loadVoters);
                msl.labelSelectedLocation.Text = ((Barangay)comboBoxBarangay.SelectedItem).BarangayName +", "+ ((Purok)comboBoxPurok.SelectedItem).PurokName + ", "+ ((Cluster)comboBoxCluster.SelectedItem).Leader; 
                msl.Show();
                loadVoters();
            }
            else
            {
                MessageBox.Show("Please select Barangay, Purok and Cluster Leader!");
            }
        }

       

        private void repositoryItemRadioGroupVice_SelectedIndexChanged(object sender, EventArgs e)
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

        private void btnExclude_Click(object sender, EventArgs e)
        {
            foreach (int x in gridView1.GetSelectedRows())
            {
                Person person = persons[x];
                if (MessageBox.Show("Are you sure to exclude " + person.Fullname + "?", "Exclude Person", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    person.Purok = 0;
                    person.Cluster = 0;
                    personRepository.SaveAsTransaction(person);
                }
            }
            personRepository.CommitTransaction();
            gridView1.ClearSelection();
            loadVoters();
        }

        private void repositoryItemTextEdit1_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                TextEdit rg = ((TextEdit)sender);
                string selected = rg.EditValue.ToString();
                Person va = (Person)gridView1.GetFocusedRow();
                va.Remarks = selected;
                personRepository.Save(va);
            }
            catch (Exception ex)
            { }
        }
    }
}
