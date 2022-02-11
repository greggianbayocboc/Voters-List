using DevExpress.XtraBars.Navigation;
using DevExpress.XtraCharts;
using gregg.DTOs;
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
        public PieChartByBarangayForm()
        {
            InitializeComponent();
            
        }

        private void PieChartByBarangayForm_Load(object sender, EventArgs e)
        {
            List<PieChartData> pieChartDataList = pieChartDataRepository.generateData(position);

            Series seriesAto = new Series("ATO", ViewType.StackedBar);
            Series seriesDile = new Series("DILE ATO", ViewType.StackedBar);
            Series seriesDuha = new Series("DUHA_DUHA", ViewType.StackedBar);
            Series seriesInc = new Series("INC", ViewType.StackedBar);
            foreach (PieChartData data in pieChartDataList)
            {
                seriesAto.Points.Add(new SeriesPoint(data.BarangayName, data.Ato));
                seriesDile.Points.Add(new SeriesPoint(data.BarangayName, data.DileAto));
                seriesDuha.Points.Add(new SeriesPoint(data.BarangayName, data.DuhaDuha));
                seriesInc.Points.Add(new SeriesPoint(data.BarangayName, data.INC));

                List<DataPoint> dps = new List<DataPoint> {
                    new DataPoint { Argument = "ATO",    Value = data.Ato},
                    new DataPoint { Argument = "DILE ATO",    Value = data.DileAto},
                    new DataPoint { Argument = "DUHA_DUHA",       Value = data.DuhaDuha},
                    new DataPoint { Argument = "INC",     Value = data.INC}
                };
                add(data.BarangayName, dps);
            }
            add2(seriesAto, seriesDile, seriesDuha, seriesInc);
        }
        
        private void add(string barangayName, List<DataPoint> dataPoints)
        {
            ChartControl pieChart = new ChartControl();
            //pieChart.Height = tabPane1.Size.Height - 50;
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
            

            pieChart.Dock = DockStyle.Fill;
            TabNavigationPage tb = new TabNavigationPage();
            tb.PageText = barangayName;
            tb.Controls.Add(pieChart);
            
            navigationPane1.Pages.Add(tb);
        }

        private void add2(Series seriesAto, Series seriesDile, Series seriesDuha, Series seriesInc)
        {
            ChartControl stackedBarChart = new ChartControl();

            // Create two stacked bar series.
            

            // Add both series to the chart.
            stackedBarChart.Series.AddRange(new Series[] { seriesAto, seriesDile, seriesDuha, seriesInc });

            // Access the view-type-specific options of the series.
           // ((StackedBarSeriesView)series1.View).BarWidth = 0.8;

            // Access the type-specific options of the diagram.
            ((XYDiagram)stackedBarChart.Diagram).EnableAxisXZooming = true;

            // Hide the legend (if necessary).
            stackedBarChart.Legend.Visible = false;

            // Add a title to the chart (if necessary).
            stackedBarChart.Titles.Add(new ChartTitle());
            stackedBarChart.Titles[0].Text = "Overall Assessment Overview";

            // Add the chart to the form.
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
    }
}
