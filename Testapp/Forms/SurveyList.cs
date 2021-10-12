using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars;
using System.ComponentModel.DataAnnotations;
using Testapp.Models;
using Testapp.Repository;

namespace gregg.Forms
{
    public partial class SurveyList : Form
    {
        SurveyRepository surveyRepository = new SurveyRepository();
        SurveyItemRepository surveyItemRepository = new SurveyItemRepository();
        CandidateRepository candidateRepository = new CandidateRepository();
        PersonRepository personRepository = new PersonRepository();
        public SurveyList()
        {
            InitializeComponent();
            
        }
        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
           
        }

        private void SurveyList_Load(object sender, EventArgs e)
        {
            reloadData();

        }

        void reloadData() {
            surveyBindingSource.DataSource = surveyRepository.getAll();
        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
           
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}