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
    public partial class ElectionDataSetting : Form
    {
        public CandidateRepository candidateRepository = new CandidateRepository();
        public PartyRepository partyRepository = new PartyRepository();
        public ElectionDataSetting()
        {
            InitializeComponent();
        }

        private void ElectionDataSetting_Load(object sender, EventArgs e)
        {
            reloadData();
        }

        void reloadData() {
            bindingSourceParty.DataSource = partyRepository.getAll();
            bindingSourceMayors.DataSource = candidateRepository.getAll(" WHERE Position_ = 'MAYOR '");
            bindingSourceViceMayors.DataSource = candidateRepository.getAll(" WHERE Position_ = 'VICE-MAYOR '");
            bindingSourceCouncilors.DataSource = candidateRepository.getAll(" WHERE Position_ = 'COUNCILOR '");
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            CandidateForm pf = new CandidateForm();
            pf.textEdit2.Text = "MAYOR";
            pf.ShowDialog();
            reloadData();

        }

        private void simpleButton12_Click(object sender, EventArgs e)
        {
            PartyForm pf = new PartyForm();
            pf.ShowDialog();
            reloadData();
        }

        private void simpleButton11_Click(object sender, EventArgs e)
        {
            if (gridView4.GetFocusedRow() != null)
            {
                PartyForm pf = new PartyForm();
                pf.party = (Party)gridView4.GetFocusedRow();
                pf.ShowDialog();
                reloadData();
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (gridView1.GetFocusedRow() != null)
            {
                CandidateForm pf = new CandidateForm();
                pf.textEdit2.Text = "MAYOR";
                pf.candidate = (Candidate)gridView1.GetFocusedRow();
                pf.ShowDialog();
                reloadData();
            }
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            CandidateForm pf = new CandidateForm();
            pf.textEdit2.Text = "VICE-MAYOR";
            pf.ShowDialog();
            reloadData();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            if (gridView2.GetFocusedRow() != null)
            {
                CandidateForm pf = new CandidateForm();
                pf.textEdit2.Text = "VICE-MAYOR";
                pf.candidate = (Candidate)gridView1.GetFocusedRow();
                pf.ShowDialog();
                reloadData();
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (gridView1.GetFocusedRow() != null)
            {
                Candidate candi = (Candidate)gridView1.GetFocusedRow();
                candidateRepository.Delete(candi);
                reloadData();
            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            if (gridView2.GetFocusedRow() != null)
            {
                Candidate candi = (Candidate)gridView1.GetFocusedRow();
                candidateRepository.Delete(candi);
                reloadData();
            }
        }

        private void simpleButton10_Click(object sender, EventArgs e)
        {
            if (gridView4.GetFocusedRow() != null)
            {
                Party party = (Party)gridView1.GetFocusedRow();
                partyRepository.Delete(party);
                reloadData();
            }
        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {
            CandidateForm pf = new CandidateForm();
            pf.textEdit2.Text = "COUNCILOR";
            pf.ShowDialog();
            reloadData();
            
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            if (gridView3.GetFocusedRow() != null)
            {
                CandidateForm pf = new CandidateForm();
                pf.textEdit2.Text = "COUNCILOR";
                pf.candidate = (Candidate)gridView1.GetFocusedRow();
                pf.ShowDialog();
                reloadData();
            }
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            if (gridView3.GetFocusedRow() != null)
            {
                Candidate candi = (Candidate)gridView1.GetFocusedRow();
                candidateRepository.Delete(candi);
                reloadData();
            }
        }
    }
}
