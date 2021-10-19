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
        string lastSearchString = "";
        PersonRepository personRepository = new PersonRepository();
        VoterAssessmentRepository voterAssessmentRepository = new VoterAssessmentRepository();
        public VoterAssessmentForm()
        {
            InitializeComponent();
        }
        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl1.ShowPrintPreview();
        }

        private void bandedGridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            Console.WriteLine(e.CellValue);
        }

        private void bbiRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            //List<Person> voters = personRepository.getAll();
            //foreach (Person voter in voters)
            //{
            //    VoterAssessment vt = new VoterAssessment();
            //    vt.Voter = voter.ID;
            //    vt.VoterName = voter.Fullname;
            //    vt.Mayor = "ATO";
            //    vt.Vice = "DILE ATO";
            //    voterAssessmentRepository.SaveAsTransaction(vt);
            //}
            //voterAssessmentRepository.CommitTransaction();
            reloadData(lastSearchString);
        }

        private void barEditItem1_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void repositoryItemCheckedComboBoxEdit1_EditValueChanged(object sender, EventArgs e)
        {
            this.hideAllColumns();
            CheckedComboBoxEdit combo = (CheckedComboBoxEdit)sender;
            List<string> selections = combo.Text.Replace(", ",",").Split(',').ToList<string>();

            if (selections.Contains("COUNCILORS"))
            {

                columnCouncilor8.Visible = true;
                columnCouncilor7.Visible = true;
                columnCouncilor6.Visible = true;
                columnCouncilor5.Visible = true;
                columnCouncilor4.Visible = true;
                columnCouncilor3.Visible = true;
                columnCouncilor2.Visible = true;
                columnCouncilor1.Visible = true;
            }
            else
            {
                columnCouncilor1.Visible = false;
                columnCouncilor2.Visible = false;
                columnCouncilor3.Visible = false;
                columnCouncilor4.Visible = false;
                columnCouncilor5.Visible = false;
                columnCouncilor6.Visible = false;
                columnCouncilor7.Visible = false;
                columnCouncilor8.Visible = false;
            }

            if (selections.Contains("VICE-MAYOR"))
            {
                columnVice.Visible = true;
            }
            else
            {
                columnVice.Visible = false;
            }

            if (selections.Contains("MAYOR"))
            {
                columnMayor.Visible = true;
            }
            else
            {
                columnMayor.Visible = false;
            }
            
            
        }

        void hideAllColumns()
        {
            columnMayor.Visible = false;
            columnVice.Visible = false;
            columnCouncilor1.Visible = false;
            columnCouncilor2.Visible = false;
            columnCouncilor3.Visible = false;
            columnCouncilor4.Visible = false;
            columnCouncilor5.Visible = false;
            columnCouncilor6.Visible = false;
            columnCouncilor7.Visible = false;
            columnCouncilor8.Visible = false;
        }

        void reloadData(string whereclause) {
            if(whereclause==string.Empty)
                gridControl1.DataSource = personRepository.getAll();
            else
                gridControl1.DataSource = personRepository.getAll(whereclause);

            bsiRecordsCount.Caption ="Records : "+ gridView1.RowCount;
        }

        private void VoterAssessmentForm_Load(object sender, EventArgs e)
        {
            hideAllColumns();
            reloadData("");
        }

        void updateAssessment(VoterAssessment va, string value)
        {
            
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

        private void barEditItem2_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void repositoryItemTextEdit1_EditValueChanged(object sender, EventArgs e)
        {

            
           // gridControl1.DataSource = voterAssessmentRepository.getAll();
        }

        private void repositoryItemTextEdit1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TextEdit txtedit = (TextEdit)sender;
                string where = "WHERE Fullname like '%" + txtedit.Text.ToUpper() + "%'";
                lastSearchString = where;
                reloadData(where);
            }
        }

        private void repositoryItemTextEdit1_EditValueChanged_1(object sender, EventArgs e)
        {
            
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            int x = 1;
            List<Person> voters = personRepository.getAll();
            foreach (Person person in voters)
            {
                switch (x) {
                    case 1:
                        person.Councilor1 = "ATO";
                        person.Councilor2 = "ATO";
                        person.Councilor3 = "ATO";
                        person.Councilor4 = "ATO";
                        person.Councilor5 = "ATO";
                        person.Councilor6 = "ATO";
                        person.Councilor7 = "ATO";
                        person.Councilor8 = "ATO";
                        person.Mayor = "ATO";
                        person.Vice = "ATO";
                        break;
                    case 2:
                        person.Councilor1 = "DILE ATO";
                        person.Councilor2 = "ATO";
                        person.Councilor3 = "ATO";
                        person.Councilor4 = "ATO";
                        person.Councilor5 = "ATO";
                        person.Councilor6 = "ATO";
                        person.Councilor7 = "ATO";
                        person.Councilor8 = "ATO";
                        person.Mayor = "ATO";
                        person.Vice = "ATO";
                        break;
                    case 3:
                        person.Councilor1 = "DILE ATO";
                        person.Councilor2 = "DILE ATO";
                        person.Councilor3 = "ATO";
                        person.Councilor4 = "ATO";
                        person.Councilor5 = "ATO";
                        person.Councilor6 = "ATO";
                        person.Councilor7 = "ATO";
                        person.Councilor8 = "ATO";
                        person.Mayor = "ATO";
                        person.Vice = "ATO";
                        break;
                    case 4:
                        person.Councilor1 = "DILE ATO";
                        person.Councilor2 = "DILE ATO";
                        person.Councilor3 = "DILE ATO";
                        person.Councilor4 = "ATO";
                        person.Councilor5 = "ATO";
                        person.Councilor6 = "ATO";
                        person.Councilor7 = "ATO";
                        person.Councilor8 = "ATO";
                        person.Mayor = "ATO";
                        person.Vice = "ATO";
                        break;
                    case 5:
                        person.Councilor1 = "DILE ATO";
                        person.Councilor2 = "DILE ATO";
                        person.Councilor3 = "DILE ATO";
                        person.Councilor4 = "DILE ATO";
                        person.Councilor5 = "ATO";
                        person.Councilor6 = "ATO";
                        person.Councilor7 = "ATO";
                        person.Councilor8 = "ATO";
                        person.Mayor = "ATO";
                        person.Vice = "ATO";
                        break;
                    case 6:
                        person.Councilor1 = "DILE ATO";
                        person.Councilor2 = "DILE ATO";
                        person.Councilor3 = "DILE ATO";
                        person.Councilor4 = "DILE ATO";
                        person.Councilor5 = "DILE ATO";
                        person.Councilor6 = "ATO";
                        person.Councilor7 = "ATO";
                        person.Councilor8 = "ATO";
                        person.Mayor = "ATO";
                        person.Vice = "ATO";
                        break;
                    case 7:
                        person.Councilor1 = "DILE ATO";
                        person.Councilor2 = "DILE ATO";
                        person.Councilor3 = "DILE ATO";
                        person.Councilor4 = "DILE ATO";
                        person.Councilor5 = "DILE ATO";
                        person.Councilor6 = "DILE ATO";
                        person.Councilor7 = "ATO";
                        person.Councilor8 = "ATO";
                        person.Mayor = "ATO";
                        person.Vice = "ATO";
                        break;
                    case 8:
                        person.Councilor1 = "DILE ATO";
                        person.Councilor2 = "DILE ATO";
                        person.Councilor3 = "DILE ATO";
                        person.Councilor4 = "DILE ATO";
                        person.Councilor5 = "DILE ATO";
                        person.Councilor6 = "DILE ATO";
                        person.Councilor7 = "DILE ATO";
                        person.Councilor8 = "ATO";
                        person.Mayor = "ATO";
                        person.Vice = "ATO";
                        break;
                    case 9:
                        person.Councilor1 = "DILE ATO";
                        person.Councilor2 = "DILE ATO";
                        person.Councilor3 = "DILE ATO";
                        person.Councilor4 = "DILE ATO";
                        person.Councilor5 = "DILE ATO";
                        person.Councilor6 = "DILE ATO";
                        person.Councilor7 = "DILE ATO";
                        person.Councilor8 = "DILE ATO";
                        person.Mayor = "ATO";
                        person.Vice = "ATO";
                        break;
                    case 10:
                        person.Councilor1 = "DILE ATO";
                        person.Councilor2 = "DILE ATO";
                        person.Councilor3 = "DILE ATO";
                        person.Councilor4 = "DILE ATO";
                        person.Councilor5 = "DILE ATO";
                        person.Councilor6 = "DILE ATO";
                        person.Councilor7 = "DILE ATO";
                        person.Councilor8 = "DILE ATO";
                        person.Mayor = "DILE ATO";
                        person.Vice = "ATO";
                        break;
                    case 11:
                        person.Councilor1 = "DILE ATO";
                        person.Councilor2 = "DILE ATO";
                        person.Councilor3 = "DILE ATO";
                        person.Councilor4 = "DILE ATO";
                        person.Councilor5 = "DILE ATO";
                        person.Councilor6 = "DILE ATO";
                        person.Councilor7 = "DILE ATO";
                        person.Councilor8 = "DILE ATO";
                        person.Mayor = "DILE ATO";
                        person.Vice = "DILE ATO";
                        break;
                    default:
                        break;

                }
                x = (x < 11) ? x + 1 : 1;
                personRepository.SaveAsTransaction(person);
            }
            personRepository.CommitTransaction();
        }
    }
}