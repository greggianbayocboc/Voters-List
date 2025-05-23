﻿using System;
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
    public partial class ClusterForm : Form
    {
        public Barangay barangay = new Barangay();
        public Purok purok = new Purok();
        public Cluster cluster = new Cluster();
        ClusterRepository clusterRepository = new ClusterRepository();
        public ClusterForm()
        {
            InitializeComponent();
        }

        private void BarangayForm_Load(object sender, EventArgs e)
        {
            textBoxBarangayName.Text = barangay.BarangayName;
            textBoxPurokName.Text = purok.PurokName;
            textBoxPurokLeader.Text = purok.Leader;
            textBoxClusterLeader.Text = cluster.Leader;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxClusterLeader.Text.Trim() != "")
            {
                cluster.Purok = purok.ID;
                clusterRepository.Save(cluster);
                this.Close();
            }
            
        }

        private void textBoxPurokName_TextChanged(object sender, EventArgs e)
        {
            purok.PurokName = textBoxPurokName.Text.Trim();
        }

        private void textBoxPurokLeader_TextChanged(object sender, EventArgs e)
        {
            purok.Leader = textBoxPurokLeader.Text.Trim();
        }

        private void textBoxClusterLeader_TextChanged(object sender, EventArgs e)
        {
            cluster.Leader = textBoxClusterLeader.Text.Trim();
        }
    }
}
