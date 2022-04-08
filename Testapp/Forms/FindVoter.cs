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
    public partial class FindVoter : Form
    {
        public delegate void reloadListDelegate();

        public PersonRepository personRepository = new PersonRepository();
        public BarangayRepository barangayRepository = new BarangayRepository();
        public PurokRepository purokRepository = new PurokRepository();
        public ClusterRepository clusterRepository = new ClusterRepository();
        public List<Person> persons = new List<Person>();
        public int barangayId = -1;
        public int purokId = -1;
        public int clusterId = -1;
        public FindVoter()
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
               
            }
            personRepository.CommitTransaction();
            reloadListCallback();
            gridView1.ClearSelection();
            //this.Close();
        }

        private void gridView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
               
            
        }

        private void gridView1_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            Person person = (Person)gridView1.GetFocusedRow();
            Barangay brgy = barangayRepository.getOne(person.Barangay);
            if(person.Purok>0)
            {
                Purok purok = purokRepository.getOne(person.Purok);
                lblPurok.Text = purok.PurokName;
            }
            if (person.Cluster > 0)
            {
                Cluster cluster = clusterRepository.getOne(person.Cluster);
                lblCluster.Text = cluster.Leader;
            }

            lblBrgy.Text = brgy.BarangayName;
            lblFull.Text = person.Fullname;
            lblPrecinct.Text = person.Precinct;
        }
    }
}
