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
    public partial class MultipleVoterSelect : Form
    {
        public delegate void reloadListDelegate();

        public PersonRepository personRepository = new PersonRepository();
        public BarangayRepository barangayRepository = new BarangayRepository();
        public PurokRepository purokRepository = new PurokRepository();
        public ClusterRepository clusterRepository = new ClusterRepository();
        public List<Person> persons = new List<Person>();

        //List<Barangay> barangays = new List<Barangay>();
        //List<Purok> puroks = new List<Purok>();
        //List<Cluster> clusters = new List<Cluster>();
        public int barangayId = -1;
        public int purokId = -1;
        public int clusterId = -1;
        public MultipleVoterSelect()
        {
            InitializeComponent();
        }

        public reloadListDelegate reloadListCallback;

        private void MultipleVoterSelect_Load(object sender, EventArgs e)
        {
            
            persons = personRepository.getAll();
            gridControl1.DataSource = persons;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            search();
        }
        

        private void textEdit1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                search();
            }
        }

        private void search()
        {
            persons = personRepository.search(textEdit1.Text.ToUpper());
            gridControl1.DataSource = persons;
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            foreach (int x in gridView1.GetSelectedRows())
            {
                Person person = persons[x];
                if (person.Purok > 0 || person.Cluster > 0)
                {
                    Barangay brgy = barangayRepository.getOne(person.Barangay);
                    Purok purok = purokRepository.getOne(person.Purok);
                    Cluster cluster = clusterRepository.getOne(person.Cluster);
                    DialogResult result = MessageBox.Show( "Voter " + person.Fullname + " is already assigned to " + cluster.Leader + ", " + purok.Leader + " - " + brgy.BarangayName, "Voter Already Assigned!", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.OK)
                    {
                        person.Barangay = barangayId;
                        person.Purok = purokId;
                        person.Cluster = clusterId;
                        personRepository.SaveAsTransaction(person);
                    }
                    else if (result == DialogResult.Cancel)
                    {

                    }
                }
                else
                {
                    person.Barangay = barangayId;
                    person.Purok = purokId;
                    person.Cluster = clusterId;
                    personRepository.SaveAsTransaction(person);
                }
                
            }
            personRepository.CommitTransaction();
            reloadListCallback();
            gridView1.ClearSelection();
            //this.Close();
        }
    }
}
