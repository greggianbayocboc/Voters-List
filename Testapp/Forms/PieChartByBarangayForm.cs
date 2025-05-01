using DevExpress.XtraBars.Navigation;
using DevExpress.XtraCharts;
using DevExpress.XtraReports.UI;
using gregg.DTOs;
using gregg.Helpers;
using gregg.Reports;
using gregg.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Testapp;
using Testapp.Helpers;
using Testapp.Models;
using Testapp.Repository;

namespace gregg.Forms
{
    public partial class PieChartByBarangayForm : Form
    {
        public string position = null;
        public string candidate = null;
        PieChartDataRepository pieChartDataRepository = new PieChartDataRepository();
        BarangayRepository barangayRepository = new BarangayRepository();
        ChartControl pieChart = new ChartControl();

        public PieChartByBarangayForm()
        {
            InitializeComponent();
            
        }

        private void PieChartByBarangayForm_Load(object sender, EventArgs e)
        {
            List<PieChartData> pieChartDataList = pieChartDataRepository.generateData(position);
            if (this.Text == "MAYOR")
            {

                Series seriesAto = new Series("ONGIE-BERNALES-LIM", ViewType.StackedBar);
                Series seriesDile = new Series("JUN JAYOMA", ViewType.StackedBar);
                //Series seriesInc = new Series("HELEN JAYOMA", ViewType.StackedBar);
                Series seriesDuha = new Series("DUHA-DUHA", ViewType.StackedBar);
                Series seriesUnassigned = new Series("UNASSIGNED", ViewType.StackedBar);
                int ato_total = 0;
                int dile_ato_total = 0;
                int inc_total = 0;
                int duha_total = 0;
                int unassigned_total = 0;
                
                foreach (PieChartData data in pieChartDataList)
                {
                    int total = 0;
                    seriesAto.Points.Add(new SeriesPoint(data.BarangayName, data.Ato));
                    seriesDile.Points.Add(new SeriesPoint(data.BarangayName, data.DileAto));
                    //seriesInc.Points.Add(new SeriesPoint(data.BarangayName, data.INC));
                    seriesDuha.Points.Add(new SeriesPoint(data.BarangayName, data.DuhaDuha));
                    seriesUnassigned.Points.Add(new SeriesPoint(data.BarangayName, data.Unassigned));

                    ato_total += data.Ato;
                    dile_ato_total += data.DileAto;
                    inc_total += data.INC;
                    duha_total += data.DuhaDuha;
                    unassigned_total += data.Unassigned;

                    List<DataPoint> dps = new List<DataPoint> 
                    {
                        new DataPoint { Argument = "ONGIE-BERNALES-LIM",    Value = data.Ato},
                        new DataPoint { Argument = "JUN JAYOMA",    Value = data.DileAto},
                        //new DataPoint { Argument = "HELEN JAYOMA",    Value = data.INC},
                        new DataPoint { Argument = "DUHA-DUHA",   Value = data.DuhaDuha},
                        new DataPoint { Argument = "UNASSIGNED",   Value = data.Unassigned}
                    };
                    foreach (DataPoint dp in dps)
                    {
                        total += (int)dp.Value;
                    }
                    add(data.BarangayName, dps, total);
                }
                //add2(seriesAto, seriesDile, seriesDuha, seriesInc, seriesUnassigned);
                add2(seriesAto, seriesDile, seriesDuha, seriesUnassigned);

                int totalz = 0;
                List<DataPoint> dpz = new List<DataPoint> 
                    {
                        new DataPoint { Argument = "ONGIE-BERNALES-LIM",    Value = ato_total},
                        new DataPoint { Argument = "JUN JAYOMA",    Value = dile_ato_total},
                        //new DataPoint { Argument = "HELEN JAYOMA",    Value = inc_total},
                        new DataPoint { Argument = "DUHA-DUHA",   Value = duha_total},
                        new DataPoint { Argument = "UNASSIGNED",   Value = unassigned_total}
                    };
                foreach (DataPoint dp in dpz)
                {
                    totalz += (int)dp.Value;
                }
                add("MABINI BOHOL", dpz, totalz);

            }
            else
            {
                Series seriesAto = new Series("MYRA FOSTANES- COLIS", ViewType.StackedBar);
                Series seriesDile = new Series("HELEN JAYOMA", ViewType.StackedBar);
                Series seriesDuha = new Series("DUHA-DUHA", ViewType.StackedBar);
                Series seriesUnassigned = new Series("UNASSIGNED", ViewType.StackedBar);

                int ato_total = 0;
                int dile_ato_total = 0;
                int inc_total = 0;
                int duha_total = 0;
                int unassigned_total = 0;

                foreach (PieChartData data in pieChartDataList)
                {
                    int total = 0;
                    seriesAto.Points.Add(new SeriesPoint(data.BarangayName, data.Ato));
                    seriesDile.Points.Add(new SeriesPoint(data.BarangayName, data.DileAto));
                    seriesDuha.Points.Add(new SeriesPoint(data.BarangayName, data.DuhaDuha));
                    seriesUnassigned.Points.Add(new SeriesPoint(data.BarangayName, data.Unassigned));

                    ato_total += data.Ato;
                    dile_ato_total += data.DileAto;
                    inc_total += data.INC;
                    duha_total += data.DuhaDuha;
                    unassigned_total += data.Unassigned;

                    List<DataPoint> dps = new List<DataPoint> 
                    {
                        new DataPoint { Argument = "MYRA FOSTANES- COLIS",    Value = data.Ato},
                        new DataPoint { Argument = "HELEN JAYOMA",    Value = data.DileAto},
                        new DataPoint { Argument = "DUHA-DUHA",   Value = data.DuhaDuha},
                        new DataPoint { Argument = "UNASSIGNED",   Value = data.Unassigned}
                    };
                    foreach (DataPoint dp in dps)
                    {
                        total += (int)dp.Value;
                    }
                    add(data.BarangayName, dps, total);
                }
                add2(seriesAto, seriesDile, seriesDuha, seriesUnassigned);

                int totalz = 0;
                List<DataPoint> dpz = new List<DataPoint> 
                    {
                        new DataPoint { Argument = "MYRA FOSTANES- COLIS",    Value = ato_total},
                        new DataPoint { Argument = "HELEN JAYOMA",    Value = dile_ato_total},
                        new DataPoint { Argument = "DUHA-DUHA",   Value = duha_total},
                        new DataPoint { Argument = "UNASSIGNED",   Value = unassigned_total}
                    };
                foreach (DataPoint dp in dpz)
                {
                    totalz += (int)dp.Value;
                }
                add("MABINI BOHOL", dpz, totalz);

            }

           
        }
        
        private void add(string barangayName, List<DataPoint> dataPoints, int total)
        {


            pieChart = new ChartControl();
            pieChart.RuntimeHitTesting = true;
            pieChart.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chartControl1_MouseClick);
            Palette palette = new Palette("Custom Palette");
            palette.Add(Color.Purple);
            palette.Add(Color.Blue);
            palette.Add(Color.Orange);
            palette.Add(Color.Yellow);
            palette.Add(Color.Red);
            // Register the palette.
            pieChart.PaletteRepository.RegisterPalette(palette);
            // Assign the palette to the chart.
            pieChart.PaletteName = "Custom Palette";

            //pieChart.Height = tabPane1.Size.Height - 50;
            pieChart.Titles.Add(new ChartTitle() { Text = barangayName + " (" + total + " voters)" });
            pieChart.Titles.Add(new ChartTitle() { Text = barangayName });

            // Create a pie series.
            Series series1 = new Series(barangayName, ViewType.Pie);

            // Bind the series to data.
            series1.DataSource = dataPoints;
            series1.ArgumentDataMember = "Argument";
            series1.ValueDataMembers.AddRange(new string[] { "Value" });

            // Add the series to the chart.
            pieChart.Series.Add(series1);

            // Format the the series labels.
            series1.Label.TextPattern = "({V:.##} Voters {A}) {VP:p0}";

            // Format the series legend items.
            series1.LegendTextPattern = "{A}";

            // Adjust the position of series labels. 
            ((PieSeriesLabel)series1.Label).Position = PieSeriesLabelPosition.TwoColumns;

            // Detect overlapping of series labels.
            ((PieSeriesLabel)series1.Label).ResolveOverlappingMode = ResolveOverlappingMode.Default;

            // Access the view-type-specific options of the series.
            PieSeriesView myView = (PieSeriesView)series1.View;

            // Specify a data filter to explode points.
            myView.ExplodedPointsFilters.Add(new SeriesPointFilter(SeriesPointKey.Value_1,
                DataFilterCondition.GreaterThanOrEqual, 9));
            myView.ExplodedPointsFilters.Add(new SeriesPointFilter(SeriesPointKey.Argument,
                DataFilterCondition.NotEqual, "Others"));
            myView.ExplodeMode = PieExplodeMode.UseFilters;
            myView.ExplodedDistancePercentage = 30;
            

            // Customize the legend.
            pieChart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;

            pieChart.Width = 850;
            pieChart.Height = 600;
            pieChart.Anchor = navigationPane1.Anchor;
            TabNavigationPage tb = new TabNavigationPage();
            tb.PageText = barangayName + " (" + total + " voters)";
            tb.Controls.Add(pieChart);
            if (barangayName == "MABINI BOHOL")
                navigationPane1.Pages.Insert(1, tb);
            else
                navigationPane1.Pages.Add(tb);
        }

        private void add2(Series seriesAto, Series seriesDile, Series seriesDuha, Series seriesUnassigned)
        {
            ChartControl stackedBarChart = new ChartControl();

            // Create two stacked bar series.

            stackedBarChart.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chartControl1_MouseClick);
            Palette palette = new Palette("Custom Palette2");
            palette.Add(Color.Purple);
            palette.Add(Color.Blue);
            palette.Add(Color.Orange);
            palette.Add(Color.Yellow);
            palette.Add(Color.Red);
            // Register the palette.
            stackedBarChart.PaletteRepository.RegisterPalette(palette);
            // Assign the palette to the chart.
            stackedBarChart.PaletteName = "Custom Palette2";

            // Add both series to the chart.
            stackedBarChart.Series.AddRange(new Series[] { seriesAto, seriesDile, seriesDuha, seriesUnassigned });

            // Access the view-type-specific options of the series.
           // ((StackedBarSeriesView)series1.View).BarWidth = 0.8;

            // Access the type-specific options of the diagram.
            ((XYDiagram)stackedBarChart.Diagram).EnableAxisXZooming = true;

            // Hide the legend (if necessary).
            stackedBarChart.Legend.Visible = false;

            // Add a title to the chart (if necessary).
            stackedBarChart.Titles.Add(new ChartTitle());
            stackedBarChart.Titles[0].Text = "Overall Assessment Overview";

            // Add the chart to the form
            stackedBarChart.Dock = DockStyle.Fill;
            TabNavigationPage tb = new TabNavigationPage();
            tb.PageText = "OVERALL";
            tb.Controls.Add(stackedBarChart);

            navigationPane1.Pages.Insert(0,tb);
            navigationPane1.SelectPrevPage();
        }

        private void xtraScrollableControl1_Click(object sender, EventArgs e)
        {

        }

        private void chartControl1_MouseClick(object sender, MouseEventArgs e)
        {
            ChartControl pieChart = ((ChartControl)sender);
            // Obtain the object being clicked.
            ChartHitInfo hi = pieChart.CalcHitInfo(e.X, e.Y);
            String barangay = pieChart.Titles[1].Text;


            // Check whether it was a series point, and if so - 
            // obtain its argument, and pass it to the detail series.
            SeriesPoint point = hi.SeriesPoint;

            if (point != null)
            {
                string selectedCandidate = point.Argument.ToString();
                DialogResult result = MessageBox.Show("Group Result", "Do you want to group by Purok?", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                    this.printSelectedCandidateGrouped(barangay, labelPosition.Text.ToLower().Trim().Split('-').First(), selectedCandidate);
                else if (result == DialogResult.No)
                    this.printSelectedCandidate(barangay, labelPosition.Text.ToLower().Trim().Split('-').First(), selectedCandidate);
                else
                    return;
            }
            else 
            {

                pieChart.ShowRibbonPrintPreview();
            }


            // Obtain the title under the test point.
            ChartTitle link = hi.ChartTitle;
            // Check whether the link was clicked, and if so - 
            // restore the main series.
            if (link != null && link.Text.StartsWith("Back"))
            {
               
            }
        }

        void printSelectedCandidateGrouped(String barangay,String selection, String candidate)
        {

           
            int barangayId = barangayRepository.getIdByName(barangay);

            LeaderPrintoutDtoRepository leaderPrintoutDtoRepository = new LeaderPrintoutDtoRepository();
            BlankReport initialReport = new BlankReport();
            initialReport.CreateDocument();
            List<LeaderPrintoutDto> dtos = leaderPrintoutDtoRepository.getGroupedReport(Utils.generateWhereClauseForLeaders(barangayId, -1, -1));
            int count = 0;
            foreach (LeaderPrintoutDto dto in dtos)
            {
                LeaderPrintoutReportSelectedCandidate rpt = new LeaderPrintoutReportSelectedCandidate();
                rpt.selectedCandidateLabel.Text = candidate;
                rpt.Parameters["barangay"].Value = dto.Barangay;
                rpt.Parameters["barangayCoordinator"].Value = dto.BarangayCoordinator;
                rpt.Parameters["clusterLeader"].Value = dto.ClusterLeader;
                rpt.Parameters["purokLeader"].Value = dto.PurokName + " - " + dto.PurokLeader;
                List<Person> list = leaderPrintoutDtoRepository.getVotersWithSelection(dto.BarangayID, dto.PurokID, dto.ClusterID, selection, candidate);
                rpt.Parameters["count"].Value = list.Count;
                count += list.Count;
                rpt.DataSource = list;
                rpt.CreateDocument();


                if (list.Count > 0)
                    initialReport.ModifyDocument(x =>
                    {
                        x.AddPages(rpt.Pages);
                    });
                
            }
            ReportPrintTool tool = new ReportPrintTool(initialReport);
            tool.PreviewForm.MdiParent = this.MdiParent;
            tool.ShowPreview();
        }


        void printSelectedCandidate(String barangay, String selection, String candidate)
        {

            int barangayId = barangayRepository.getIdByName(barangay);

            LeaderPrintoutDtoRepository leaderPrintoutDtoRepository = new LeaderPrintoutDtoRepository();
            BlankReport initialReport = new BlankReport();
            initialReport.CreateDocument();
            List<LeaderPrintoutDto> dtos = leaderPrintoutDtoRepository.getGroupedReport(Utils.generateWhereClauseForLeaders(barangayId, -1, -1));
            List<Person> masterList = new List<Person>();
            int count = 0;
            LeaderPrintoutReportSelectedCandidate rpt = new LeaderPrintoutReportSelectedCandidate();
            foreach (LeaderPrintoutDto dto in dtos)
            {
                
                rpt.selectedCandidateLabel.Text = candidate;
                rpt.Parameters["barangay"].Value = dto.Barangay;
                List<Person> list = leaderPrintoutDtoRepository.getVotersWithSelection(dto.BarangayID, dto.PurokID, dto.ClusterID, selection, candidate);
                
                count += list.Count;
                masterList.AddRange(list);

            }
            masterList.Sort((a, b) => a.Fullname.CompareTo(b.Fullname));
            rpt.Parameters["count"].Value = masterList.Count;
            rpt.DataSource = masterList;
            rpt.CreateDocument();


            if (masterList.Count > 0)
                initialReport.ModifyDocument(x =>
                {
                    x.AddPages(rpt.Pages);
                });
            ReportPrintTool tool = new ReportPrintTool(initialReport);
            tool.PreviewForm.MdiParent = this.MdiParent;
            tool.ShowPreview();
        }
    }
}
