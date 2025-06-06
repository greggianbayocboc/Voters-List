﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Testapp.Models;
using Testapp.Repository;
using Excel = Microsoft.Office.Interop.Excel;

namespace gregg.Forms
{
    public partial class ImportVotersForm : DevExpress.XtraEditors.XtraForm
    {
        public BarangayRepository barangayRepository = new BarangayRepository();
        public PurokRepository purokRepository = new PurokRepository();
        public PersonRepository personRepository = new PersonRepository();
        public List<string> allNamesFromExcel = new List<string>();
        List<string> notFoundInDBNames = new List<string>();
        List<string> notFoundInExcelNames = new List<string>();

        public ImportVotersForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            textBox1.Text = @"D:\Documents\Work\Voters\consolidatedv2.xlsx";
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           // List<Purok> puroks = purokRepository.getAll();
            toolStripProgressBar1.Visible = true;
            toolStripProgressBar1.Value = 0;
            
            Excel.Application excelApp = new Excel.Application();
            if (excelApp != null && openFileDialog1.FileName!=string.Empty)
            {
                Excel.Workbook excelWorkbook = excelApp.Workbooks.Open(textBox1.Text, 0, true, 5, "", "", true, Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 1);
                Excel.Worksheet excelWorksheet = (Excel.Worksheet)excelWorkbook.Sheets[1];

                Excel.Range excelRange = excelWorksheet.UsedRange;
                int rowCount = excelRange.Rows.Count;
                int colCount = excelRange.Columns.Count;
                DataTable dt = new DataTable();
                dt.Clear();


                for (int i = 1; i <= rowCount; i++)
                {
                    
                    DataRow row = dt.NewRow();

                   
                    for (int j = 1; j <= colCount; j++)
                    {
                        Excel.Range range = (excelWorksheet.Cells[i, j] as Excel.Range);
                        if (range.Value == null)
                            continue;
                        string cellValue = range.Value.ToString();
                        toolStripCell.Text = "" + i + GetExcelColumnName(j);

                        if (i == 1)
                        {
                            dt.Columns.Add(cellValue);
                        }
                        else
                        {
                            try
                            {
                                row[j - 1] = cellValue;
                            }
                            catch (Exception ex)
                            { 
                            } 
                        }
                    }
                    if (i > 1)
                        dt.Rows.Add(row);
                    toolStripProgressBar1.Value = (int)((double)i / (double)rowCount * 100);
                }


                toolStripProgressBar1.Value = 0;
                dataGridView1.DataSource = dt;


                int brgy = -1;
                //// this.testAsync(dt, brgy);
                String brgyname = "";
                foreach (DataRow dtrow in dt.Rows)
                {
                    if (dtrow["name"].ToString().Trim() == "")
                    {
                        if (dtrow["brgy"].ToString().Trim().StartsWith("BARANGAY"))
                        {
                            brgyname = dtrow["brgy"].ToString().Split(':')[1].Trim();
                            brgy = barangayRepository.getIdByName(brgyname);
                           
                            toolStripStatusLabel3.Text = brgyname;
                            
                        }
                    }
                    else
                    {
                        Purok purok = null;

                        Person person = new Person();

                        person.Fullname = dtrow["name"].ToString();

                        string[] names = person.Fullname.Split(',');
                        person.Lastname = names[0];
                        person.Firstname = names[1];
                        toolStripCell.Text = person.Fullname;
                       // toolStripCell.Text = person.Fullname;
                        person.Barangay = brgy;
                        ////person.Address = dtrow["VOTER'S ADDRESS"].ToString().Trim();
                        person.Precinct = dtrow["precinct"].ToString();

                        personRepository.SaveAsTransaction(person);
                    }
                   
                }
                personRepository.CommitTransaction();
                toolStripProgressBar1.Value = 100;
                toolStripProgressBar1.Visible = false;
                
                excelWorkbook.Close();
                excelApp.Quit();
            }
            else
            {
                MessageBox.Show("Error", "Excel is not installed!");
            }
        }

        public DataTable ReadExcel(string fileName, string fileExt)
        {
            string conn = string.Empty;
            DataTable dtexcel = new DataTable();
            if (fileExt.CompareTo(".xls") == 0)
                conn = @"provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + fileName + ";Extended Properties='Excel 8.0;HRD=Yes;IMEX=1';"; //for below excel 2007  
            else
                conn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + fileName + ";Extended Properties='Excel 12.0;HDR=NO';"; //for above excel 2007  
            using (OleDbConnection con = new OleDbConnection(conn))
            {
                try
                {
                    OleDbDataAdapter oleAdpt = new OleDbDataAdapter("select * from [Sheet1$]", con); //here we read data from sheet1  
                    oleAdpt.Fill(dtexcel); //fill excel data into dataTable  
                }
                catch { }
            }
            return dtexcel;
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }


        private string GetExcelColumnName(int columnNumber)
        {
            string columnName = "";

            while (columnNumber > 0)
            {
                int modulo = (columnNumber - 1) % 26;
                columnName = Convert.ToChar('A' + modulo) + columnName;
                columnNumber = (columnNumber - modulo) / 26;
            }

            return columnName;
        }

        private void ImportVotersForm_Load(object sender, EventArgs e)
        {
            bindingSourceBarangay.DataSource = barangayRepository.getAll();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            toolStripProgressBar1.Visible = true;
            toolStripProgressBar1.Value = 0;
            List<Person> persons = personRepository.getAll();
            int i = 1;
            int rowCount = persons.Count;
            foreach(Person person in persons)
            {
                if (!allNamesFromExcel.Contains(person.Fullname))
                    notFoundInExcelNames.Add(person.Fullname);
                toolStripProgressBar1.Value = (int)((double)i / (double)rowCount * 100);
            }
            toolStripProgressBar1.Value = 100;
            MessageBox.Show("Done");
        }

        private async Task testAsync(int brgy)
        {
            List<Purok> puroks = purokRepository.getAll();
            foreach (DataGridViewRow dtrow in dataGridView1.Rows)
            {
                Purok purok = null;
                try
                {
                    purok = puroks.Where(item => item.Barangay == brgy && item.PurokName == dtrow.Cells["VOTER'S ADDRESS"].Value.ToString().Trim()).First();
                }
                catch (Exception ex)
                {

                }
                Person person = new Person();
                person.Fullname = dtrow.Cells["VOTER'S NAME"].Value.ToString();
                person.Barangay = brgy;
                if (purok != null)
                    person.Purok = purok.ID;
                person.Address = dtrow.Cells["VOTER'S ADDRESS"].Value.ToString().Trim();
                person.Precinct = dtrow.Cells["PRECINCT#"].Value.ToString();

                personRepository.SaveAsTransaction(person);
                toolStripCell.Text = person.Fullname;
            }
            toolStripProgressBar1.Value = 100;
            toolStripCell.Text = "DONE!";
            personRepository.CommitTransaction();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            toolStripProgressBar1.Visible = true;
            toolStripProgressBar1.Value = 0;

            Excel.Application excelApp = new Excel.Application();
            if (excelApp != null && openFileDialog1.FileName != string.Empty)
            {
                Excel.Workbook excelWorkbook = excelApp.Workbooks.Open(textBox1.Text, 0, true, 5, "", "", true, Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 1);
                Excel.Worksheet excelWorksheet = (Excel.Worksheet)excelWorkbook.Sheets[1];

                Excel.Range excelRange = excelWorksheet.UsedRange;
                int rowCount = excelRange.Rows.Count;
                int colCount = excelRange.Columns.Count;
                DataTable dt = new DataTable();
                dt.Clear();


                for (int i = 1; i <= rowCount; i++)
                {

                    DataRow row = dt.NewRow();


                    for (int j = 1; j <= colCount; j++)
                    {
                        Excel.Range range = (excelWorksheet.Cells[i, j] as Excel.Range);
                        if (range.Value == null)
                            continue;
                        string cellValue = range.Value.ToString();
                        toolStripCell.Text = "" + i + GetExcelColumnName(j);

                        if (i == 1)
                        {
                            dt.Columns.Add(cellValue);
                        }
                        else
                        {
                            try
                            {
                                row[j - 1] = cellValue;
                            }
                            catch (Exception ex)
                            {
                            }
                        }
                    }
                    if (i > 1)
                        dt.Rows.Add(row);
                    toolStripProgressBar1.Value = (int)((double)i / (double)rowCount * 100);
                }


                toolStripProgressBar1.Value = 0;
                dataGridView1.DataSource = dt;


                int brgy = -1;
                //// this.testAsync(dt, brgy);
                String brgyname = "";
                foreach (DataRow dtrow in dt.Rows)
                {
                    string name = dtrow["name"].ToString();
                    allNamesFromExcel.Add(name);
                    bool exist = personRepository.doExist("FULLNAME", name);
                    if (!exist)
                        notFoundInDBNames.Add(name);
                }
                //personRepository.CommitTransaction();
                toolStripProgressBar1.Value = 100;
                toolStripProgressBar1.Visible = false;

                excelWorkbook.Close();
                excelApp.Quit();
                MessageBox.Show("Done!");
            }
            else
            {
                MessageBox.Show("Error", "Excel is not installed!");
            }
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            foreach (string name in notFoundInDBNames)
            {
                textBox2.AppendText("\r\n" + name);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            foreach (string name in notFoundInExcelNames)
            {
                textBox2.AppendText("\r\n" + name);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            toolStripProgressBar1.Visible = true;
            toolStripProgressBar1.Value = 0;

            Excel.Application excelApp = new Excel.Application();
            if (excelApp != null && openFileDialog1.FileName != string.Empty)
            {
                Excel.Workbook excelWorkbook = excelApp.Workbooks.Open(textBox1.Text, 0, true, 5, "", "", true, Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 1);
                Excel.Worksheet excelWorksheet = (Excel.Worksheet)excelWorkbook.Sheets[1];

                Excel.Range excelRange = excelWorksheet.UsedRange;
                int rowCount = excelRange.Rows.Count;
                int colCount = excelRange.Columns.Count;
                DataTable dt = new DataTable();
                dt.Clear();


                for (int i = 1; i <= rowCount; i++)
                {

                    DataRow row = dt.NewRow();


                    for (int j = 1; j <= colCount; j++)
                    {
                        Excel.Range range = (excelWorksheet.Cells[i, j] as Excel.Range);
                        if (range.Value == null)
                            continue;
                        string cellValue = range.Value.ToString();
                        toolStripCell.Text = "" + i + GetExcelColumnName(j);

                        if (i == 1)
                        {
                            dt.Columns.Add(cellValue);
                        }
                        else
                        {
                            try
                            {
                                row[j - 1] = cellValue;
                            }
                            catch (Exception ex)
                            {
                            }
                        }
                    }
                    if (i > 1)
                        dt.Rows.Add(row);
                    toolStripProgressBar1.Value = (int)((double)i / (double)rowCount * 100);
                }


                toolStripProgressBar1.Value = 0;
                dataGridView1.DataSource = dt;


                int brgy = -1;
                //// this.testAsync(dt, brgy);
                String brgyname = "";
                int x = 0;
                int count = dt.Rows.Count;
                foreach (DataRow dtrow in dt.Rows)
                {
                    if (dtrow["name"].ToString().Trim() == "")
                    {
                        if (dtrow["brgy"].ToString().Trim().StartsWith("BARANGAY"))
                        {
                            brgyname = dtrow["brgy"].ToString().Split(':')[1].Trim();
                            brgy = barangayRepository.getIdByName(brgyname);

                            toolStripStatusLabel3.Text = brgyname;

                        }
                    }
                    else
                    {
                        Purok purok = null;

                        Person person = personRepository.getOneBy("FULLNAME", dtrow["name"].ToString());

                        //person.Fullname = dtrow["name"].ToString();

                        //string[] names = person.Fullname.Split(',');
                        //person.Lastname = names[0];
                        //person.Firstname = names[1];
                        toolStripCell.Text = person.Fullname;
                        // toolStripCell.Text = person.Fullname;
                        person.Originalbarangay = brgy;
                        ////person.Address = dtrow["VOTER'S ADDRESS"].ToString().Trim();
                        //person.Precinct = dtrow["precinct"].ToString();
                        personRepository.SaveAsTransaction(person);
                    }
                    toolStripProgressBar1.Value = (int)((double)x / (double)count * 100);
                    x++;
                }
                personRepository.CommitTransaction();
                toolStripProgressBar1.Value = 100;
                toolStripProgressBar1.Visible = false;

                excelWorkbook.Close();
                excelApp.Quit();
            }
            else
            {
                MessageBox.Show("Error", "Excel is not installed!");
            }
        }
    }
}
