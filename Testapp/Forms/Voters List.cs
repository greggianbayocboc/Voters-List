using DevExpress.XtraReports.UI;
using gregg.PopupControl;
using gregg.Reports;
using gregg.Repository;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Testapp.Helpers;
using Testapp.Models;
using Testapp.Repository;

namespace Testapp
{
    public partial class Voters_List : DevExpress.XtraEditors.XtraForm
    {

        public PersonRepository personRepository = new PersonRepository();
        public BarangayRepository barangayRepository = new BarangayRepository();
        public PurokRepository purokRepository = new PurokRepository();
        public ClusterRepository clusterRepository = new ClusterRepository();

        List<Barangay> dictionaryBarangay = new List<Barangay>();
        List<Purok> dictionaryPurok = new List<Purok>();
        List<Cluster> dictionaryCluster = new List<Cluster>();

        public Voters_List()
        {
            InitializeComponent();
        }

        private void Voters_List_Load(object sender, EventArgs e)
        {
            List<Barangay> barangays = barangayRepository.getAll();
            List<Cluster> clusters = clusterRepository.getAll();
            List<Purok> puroks = purokRepository.getAll();

            var listBinding = new BindingList<Person>(personRepository.getAll());
            totalVotersValue.Text = listBinding.Count.ToString();
            bindingSourcePerson.DataSource = listBinding;
            bindingSourceBarangay.DataSource = barangays;
            bindingSourceBarangay.Insert(0,new Barangay(false));
            dictionaryBarangay = (List<Barangay>)bindingSourceBarangay.DataSource;

            bindingSourceFilterBarangay.DataSource = barangays;
            bindingSourcePurok.DataSource = puroks;
            bindingSourcePurok.Insert(0,new Purok(false));
            dictionaryPurok = (List<Purok>)bindingSourcePurok.DataSource;

            bindingSourceCluster.DataSource = clusters;
            bindingSourceCluster.Insert(0,new Cluster(false));
            dictionaryCluster = (List<Cluster>)bindingSourceCluster.DataSource;

            foreach (Barangay brgy in barangays)
            {
                //repositoryItemComboBox2.Items.Add(brgy);
                changeBarangayToolStripMenuItem.DropDownItems.Add(brgy.BarangayName);
            }

            foreach (Purok purok in puroks)
            {
                changePurokToolStripMenu.DropDownItems.Add(purok.PurokName);
            }

            foreach (Cluster cluster in clusters)
            {
                changeClusterLeaderToolStripMenuItem.DropDownItems.Add(cluster.Leader);
            }
        }

       

        private void comboBrgy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBrgy.SelectedItem != null)
            {
                bindingSourceFilterPurok.DataSource = purokRepository.listPurokByBarangay((int)comboBrgy.SelectedValue);
                bindingSourceFilterPurok.Insert(0, new Purok(false));
            }
                
            else
            {
                bindingSourceFilterPurok.DataSource = typeof(Testapp.Models.Purok);
            }
        }

        private void comboBrgy_DataSourceChanged(object sender, EventArgs e)
        {
        }

        private void bindingSourceBarangay_ListChanged(object sender, ListChangedEventArgs e)
        {
        }

        private void comboPurok_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboPurok.SelectedItem != null)
            {
                bindingSourceFilterCluster.DataSource = clusterRepository.listClusterByPurok((int)comboPurok.SelectedValue);
                bindingSourceFilterCluster.Insert(0, new Cluster(false));
            }
            else
                bindingSourceFilterCluster.DataSource = typeof(Testapp.Models.Cluster);
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //this.SaveCurrent();
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string headerText = dataGridView1.Columns[e.ColumnIndex].HeaderText;
                switch (headerText)
                {
                    case "Barangay":
                       // dataGridView1.Rows[e.RowIndex].ErrorText = "Barangay Value Changed, remove purok and cluster data";
                       
                     
                        break;
                    default:
                        break;
                }



            }

            
            // Abort validation if cell is not in the CompanyName column.
           
           
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            string headerText = dataGridView1.Columns[e.ColumnIndex].HeaderText;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                switch (headerText) {
                    case "Barangay":
                        CustomSelect customSelect = new CustomSelect(Cursor.Position.X, Cursor.Position.Y);
                        customSelect.bindingSource1.DataSource = barangayRepository.getAll();
                        customSelect.bindingSource1.Insert(0, new Barangay(false));
                        customSelect.bindingSource1.Position = customSelect.listBox1.FindStringExact(dataGridView1.CurrentCell.FormattedValue.ToString());
                        customSelect.filterColumn = "BarangayName";
                        customSelect.ShowDialog(this);
                        if (customSelect.listBox1.SelectedValue != null)
                        {
                            int selectedBarangay = DatabaseHelper.getID<Barangay>(customSelect.listBox1.SelectedValue);
                            if((int)dataGridView1.CurrentCell.Value==selectedBarangay)
                            {

                            }
                            else
                            {
                                dataGridView1.CurrentCell.Value = selectedBarangay;
                                dataGridView1.CurrentRow.Cells[4].Value = -1;
                                dataGridView1.CurrentRow.Cells[5].Value = -1;
                                this.SaveCurrent();
                            }
                        }
                        else
                        {
                            dataGridView1.CurrentCell.Value = -1;
                            this.SaveCurrent();
                        }
                        break;
                    case "Purok":
                        if (dataGridView1.CurrentRow.Cells[3].Value != null)
                        {
                            int barangay = int.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());
                            CustomSelect custom = new CustomSelect(Cursor.Position.X, Cursor.Position.Y);
                            custom.bindingSource1.DataSource = purokRepository.listPurokByBarangay(barangay);
                            custom.bindingSource1.Insert(0, new Purok(false));
                            custom.bindingSource1.Position = custom.listBox1.FindStringExact(dataGridView1.CurrentCell.FormattedValue.ToString());
                            custom.filterColumn = "PurokName";
                            custom.ShowDialog();
                            if (custom.listBox1.SelectedValue != null)
                            {
                                int selectedPurok = DatabaseHelper.getID<Purok>(custom.listBox1.SelectedValue);
                                if ((int)dataGridView1.CurrentCell.Value == selectedPurok)
                                {

                                }
                                else
                                {
                                    dataGridView1.CurrentCell.Value = selectedPurok;
                                    dataGridView1.CurrentRow.Cells[5].Value = -1;
                                    this.SaveCurrent();
                                }
                            }
                            else
                            {
                                dataGridView1.CurrentCell.Value = -1;
                                this.SaveCurrent();
                            }
                        }
                        break;
                    case "Cluster":
                        CustomSelect customCluster = new CustomSelect(Cursor.Position.X, Cursor.Position.Y);
                        int purok = int.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString());
                        customCluster.bindingSource1.DataSource = clusterRepository.listClusterByPurok(purok);
                        customCluster.bindingSource1.Insert(0, new Cluster(false));
                        customCluster.bindingSource1.Position = customCluster.listBox1.FindStringExact(dataGridView1.CurrentCell.FormattedValue.ToString());
                        customCluster.filterColumn = "Leader";
                        customCluster.ShowDialog();
                        if (customCluster.listBox1.SelectedValue != null)
                        {
                            dataGridView1.CurrentCell.Value = DatabaseHelper.getID<Cluster>(customCluster.listBox1.SelectedValue);
                            this.SaveCurrent();
                        }
                        else
                        {
                            dataGridView1.CurrentCell.Value = -1;
                            this.SaveCurrent();
                        }
                        break;
                    case "Update":
                        this.SaveCurrent();
                        break;
                    default: 
                        break;

                }
                //TODO - Button Clicked - Execute Code Here
            }
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.Value!=null)
            {
                string headerText = dataGridView1.Columns[e.ColumnIndex].HeaderText;
                switch (headerText)
                {
                    case "Purok":
                        List<Purok> selectedPuroks = dictionaryPurok.Where(o => o.ID == int.Parse(e.Value.ToString())).ToList<Purok>();
                        if (selectedPuroks.Count > 0)
                            e.Value = selectedPuroks.First<Purok>().PurokName;
                        break;
                    case "Barangay":
                        List<Barangay> selectedBarangays = dictionaryBarangay.Where(o => o.ID == int.Parse(e.Value.ToString())).ToList<Barangay>();
                        if (selectedBarangays.Count > 0)
                            e.Value = selectedBarangays.First<Barangay>().BarangayName;
                        break;
                    case "Cluster":
                        List<Cluster> selectedClusters = dictionaryCluster.Where(o => o.ID == int.Parse(e.Value.ToString())).ToList<Cluster>();
                        if (selectedClusters.Count > 0)
                            e.Value = selectedClusters.First<Cluster>().Leader;
                        break;
                    case "Update":
                        DataRowView row = dataGridView1.Rows[e.RowIndex].DataBoundItem as DataRowView;

                        e.Value = "SAVE";
                        
                        break;
                    default:
                        break;
                }
            }
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {

        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
           
            foreach(DataGridViewRow row in dataGridView1.SelectedRows)
            {
                Person person = row.DataBoundItem as Person;
                personRepository.Delete(person);
            }
        }

        private void btnAddVoter_Click(object sender, EventArgs e)
        {
            bindingSourcePerson.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to remove this person?", "Confirm Removal", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    personRepository.Delete(dataGridView1.CurrentRow.DataBoundItem);
                }
                catch (Exception ez)
                {
                    throw ez;
                }
                finally
                {
                    int rowIndex = dataGridView1.CurrentCell.RowIndex;
                    dataGridView1.Rows.RemoveAt(rowIndex);
                }
            }
        }

        private void Voters_List_Activated(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                f.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.applyFilter();
        }

        public void applyFilter()
        {
            string filter = string.Empty;
            if (comboBrgy.SelectedValue != null && (int)comboBrgy.SelectedValue != -1)
            {
                filter += "Barangay = " + comboBrgy.SelectedValue;
            }
            if (comboPurok.SelectedValue != null && (int)comboPurok.SelectedValue != -1)
            {
                if (filter != string.Empty)
                {
                    filter += " AND Purok = " + comboPurok.SelectedValue;
                }
                else
                {
                    filter += "Purok = " + comboPurok.SelectedValue;
                }
            }
            if (comboCluster.SelectedValue != null && (int)comboCluster.SelectedValue != -1)
            {
                if (filter != string.Empty)
                {
                    filter += " AND Cluster = " + comboCluster.SelectedValue;
                }
                else
                {
                    filter += "Cluster = " + comboCluster.SelectedValue;
                }
            }
            if (filter != string.Empty)
            {
                bindingSourcePerson.DataSource = personRepository.getAll("WHERE " + filter);
            }
            else {
                bindingSourcePerson.DataSource = personRepository.getAll();
            }
        }
        private void SaveCurrent() {
            int currentIndex = dataGridView1.CurrentCell.RowIndex;
            Person person = dataGridView1.CurrentRow.DataBoundItem as Person;
            personRepository.Save(person);
            bindingSourcePerson.DataSource = personRepository.getAll();
            applyFilter();
            if(dataGridView1.Rows.Count>0)
                dataGridView1.Rows[currentIndex].Selected = true;
            
            notifyIcon1.ShowBalloonTip(3, "Saved", "Save successful!", ToolTipIcon.Info); 
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //for (int i = 0; i < dataGridView1.Rows[e.RowIndex].Cells.Count; i++)
            //{
            //    dataGridView1[i, e.RowIndex].Style.BackColor = Color.Yellow;
            //}
        }

        private void dataGridView1_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            //for (int i = 0; i < dataGridView1.Rows[e.RowIndex].Cells.Count; i++)
            //{
            //    dataGridView1[i, e.RowIndex].Style.BackColor = Color.Empty;
            //}
        }

       

        private void gridView1_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {

            switch (e.Column.FieldName)
            {
                case "Purok":
                    List<Purok> selectedPuroks = dictionaryPurok.Where(o => o.ID == int.Parse(e.Value.ToString())).ToList<Purok>();
                    if (selectedPuroks.Count > 0)
                        e.DisplayText = selectedPuroks.First<Purok>().PurokName;
                    break;
                case "Barangay":
                    List<Barangay> selectedBarangays = dictionaryBarangay.Where(o => o.ID == int.Parse(e.Value.ToString())).ToList<Barangay>();
                    if (selectedBarangays.Count > 0)
                        e.DisplayText = selectedBarangays.First<Barangay>().BarangayName;
                    break;
                case "Cluster":
                    List<Cluster> selectedClusters = dictionaryCluster.Where(o => o.ID == int.Parse(e.Value.ToString())).ToList<Cluster>();
                    if (selectedClusters.Count > 0)
                        e.DisplayText = selectedClusters.First<Cluster>().Leader;
                    break;
                default:
                    break;
            }
           
        }

     

        private void changeBarangayToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to update barangay?", "Confirm Update", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Barangay brgy = barangayRepository.getOneBy("BarangayName", e.ClickedItem.Text);
                ArrayList rows = new ArrayList();

                // Add the selected rows to the list.
                Int32[] selectedRowHandles = gridView1.GetSelectedRows();
                for (int i = 0; i < selectedRowHandles.Length; i++)
                {
                    int selectedRowHandle = selectedRowHandles[i];
                    if (selectedRowHandle >= 0)
                        rows.Add(gridView1.GetRow(selectedRowHandle));
                }

                foreach (Person p in rows)
                {
                    p.Barangay = brgy.ID;
                    personRepository.SaveAsTransaction(p);
                }
                personRepository.CommitTransaction();
                applyFilter();
                gridView1.RefreshData();
            }
            
        }

        private void changeClusterLeaderToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to update cluster leader?", "Confirm Update", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Cluster cluster = clusterRepository.getOneBy("Leader", e.ClickedItem.Text);
                ArrayList rows = new ArrayList();

                // Add the selected rows to the list.
                Int32[] selectedRowHandles = gridView1.GetSelectedRows();
                for (int i = 0; i < selectedRowHandles.Length; i++)
                {
                    int selectedRowHandle = selectedRowHandles[i];
                    if (selectedRowHandle >= 0)
                        rows.Add(gridView1.GetRow(selectedRowHandle));
                }

                foreach (Person p in rows)
                {
                    p.Cluster = cluster.ID;
                    personRepository.SaveAsTransaction(p);
                }
                personRepository.CommitTransaction();
                applyFilter();
                gridView1.RefreshData();
            }      
        }

        private void changePurokToolStripMenu_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to update Purok?", "Confirm Update", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Purok purok = purokRepository.getOneBy("PurokName", e.ClickedItem.Text);
                ArrayList rows = new ArrayList();

                // Add the selected rows to the list.
                Int32[] selectedRowHandles = gridView1.GetSelectedRows();
                for (int i = 0; i < selectedRowHandles.Length; i++)
                {
                    int selectedRowHandle = selectedRowHandles[i];
                    if (selectedRowHandle >= 0)
                        rows.Add(gridView1.GetRow(selectedRowHandle));
                }

                foreach (Person p in rows)
                {
                    p.Purok = purok.ID;
                    personRepository.SaveAsTransaction(p);
                }
                personRepository.CommitTransaction();
                applyFilter();
                gridView1.RefreshData();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LeaderPrintoutDtoRepository leaderPrintoutDtoRepository = new LeaderPrintoutDtoRepository();
            BlankReport initialReport = new BlankReport();
            initialReport.CreateDocument();
            List<LeaderPrintoutDto> dtos = leaderPrintoutDtoRepository.getGroupedReport(generateWhereClauseForLeaders());
            int count = 0;
            foreach (LeaderPrintoutDto dto in dtos)
            {
                LeaderPrintoutReportMayor rpt = new LeaderPrintoutReportMayor();
                rpt.Parameters["barangay"].Value = dto.Barangay;
                rpt.Parameters["barangayCoordinator"].Value = dto.BarangayCoordinator;
                rpt.Parameters["clusterLeader"].Value = dto.ClusterLeader;
                rpt.Parameters["purokLeader"].Value = dto.PurokName+" - "+dto.PurokLeader;
                List<Person> list = leaderPrintoutDtoRepository.getVoters(dto.BarangayID, dto.PurokID, dto.ClusterID);
                rpt.Parameters["count"].Value = list.Count;
                count += list.Count;
                rpt.DataSource = list;
                rpt.CreateDocument();



                initialReport.ModifyDocument(x => {
                    x.AddPages(rpt.Pages);
                });
            }
            ReportPrintTool tool = new ReportPrintTool(initialReport);
            tool.PreviewForm.MdiParent = this.MdiParent;
            tool.ShowPreview();
        }

        string generateWhereClauseForLeaders() {
            string filter = string.Empty;
            if (comboBrgy.SelectedValue != null && (int)comboBrgy.SelectedValue != -1)
            {
                filter += "Barangay.ID = " + comboBrgy.SelectedValue;
            }
            if (comboPurok.SelectedValue != null && (int)comboPurok.SelectedValue != -1)
            {
                if (filter != string.Empty)
                {
                    filter += " AND Purok.ID = " + comboPurok.SelectedValue;
                }
                else
                {
                    filter += "Purok.ID = " + comboPurok.SelectedValue;
                }
            }
            if (comboCluster.SelectedValue != null && (int)comboCluster.SelectedValue != -1)
            {
                if (filter != string.Empty)
                {
                    filter += " AND Cluster.ID = " + comboCluster.SelectedValue;
                }
                else
                {
                    filter += "Cluster.ID = " + comboCluster.SelectedValue;
                }
            }
            if (filter != string.Empty)
            {
                filter = "WHERE " + filter;
            }
            return filter;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LeaderPrintoutDtoRepository leaderPrintoutDtoRepository = new LeaderPrintoutDtoRepository();
            BlankReport initialReport = new BlankReport();
            initialReport.CreateDocument();
            List<LeaderPrintoutDto> dtos = leaderPrintoutDtoRepository.getGroupedReport(generateWhereClauseForLeaders());
            int count = 0;
            foreach (LeaderPrintoutDto dto in dtos)
            {
                LeaderPrintoutReportViceMayor rpt = new LeaderPrintoutReportViceMayor();
                rpt.Parameters["barangay"].Value = dto.Barangay;
                rpt.Parameters["barangayCoordinator"].Value = dto.BarangayCoordinator;
                rpt.Parameters["clusterLeader"].Value = dto.ClusterLeader;
                rpt.Parameters["purokLeader"].Value = dto.PurokName+" - "+dto.PurokLeader;
                List<Person> list = leaderPrintoutDtoRepository.getVoters(dto.BarangayID, dto.PurokID, dto.ClusterID);
                rpt.Parameters["count"].Value = list.Count;
                count += list.Count;
                rpt.DataSource = list;
                rpt.CreateDocument();



                initialReport.ModifyDocument(x => {
                    x.AddPages(rpt.Pages);
                });
            }
            ReportPrintTool tool = new ReportPrintTool(initialReport);
            tool.PreviewForm.MdiParent = this.MdiParent;
            tool.ShowPreview();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            LeaderPrintoutDtoRepository leaderPrintoutDtoRepository = new LeaderPrintoutDtoRepository();
            BlankReport initialReport = new BlankReport();
            initialReport.CreateDocument();
            List<LeaderPrintoutDto> dtos = leaderPrintoutDtoRepository.getGroupedReport(generateWhereClauseForLeaders());
            int count = 0;
            foreach (LeaderPrintoutDto dto in dtos)
            {
                LeaderPrintoutReportCouncilor rpt = new LeaderPrintoutReportCouncilor();
                rpt.Parameters["barangay"].Value = dto.Barangay;
                rpt.Parameters["barangayCoordinator"].Value = dto.BarangayCoordinator;
                rpt.Parameters["clusterLeader"].Value = dto.ClusterLeader;
                rpt.Parameters["purokLeader"].Value = dto.PurokName+" - "+dto.PurokLeader;
                List<Person> list = leaderPrintoutDtoRepository.getVoters(dto.BarangayID, dto.PurokID, dto.ClusterID);
                rpt.Parameters["count"].Value = list.Count;
                count += list.Count;
                rpt.DataSource = list;
                rpt.CreateDocument();



                initialReport.ModifyDocument(x => {
                    x.AddPages(rpt.Pages);
                });
            }
            ReportPrintTool tool = new ReportPrintTool(initialReport);
            tool.PreviewForm.MdiParent = this.MdiParent;
            tool.ShowPreview();
        }
    }
}
