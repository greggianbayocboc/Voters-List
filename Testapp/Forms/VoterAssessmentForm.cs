using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars;
using Testapp.Repository;
using Testapp.Models;
using gregg.Helpers;

namespace gregg.Forms
{
    public partial class VoterAssessmentForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        PersonRepository personRepository = new PersonRepository();
        VoterAssessmentRepository voterAssessmentRepository = new VoterAssessmentRepository();
        public VoterAssessmentForm()
        {
            InitializeComponent();

           
        }
        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
        }

        private void bandedGridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            Console.WriteLine(e.CellValue);
        }

        private void bbiRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            List<Person> voters = personRepository.getAll();
            foreach (Person voter in voters)
            {
                VoterAssessment vt = new VoterAssessment();
                vt.Voter = voter.ID;
                vt.VoterName = voter.Fullname;
                vt.Mayor = AssessmentOption.ATO;
                vt.Vice = AssessmentOption.DILE_ATO;

                voterAssessmentRepository.SaveAsTransaction(vt);
            }
            voterAssessmentRepository.CommitTransaction();

        }
    }
}