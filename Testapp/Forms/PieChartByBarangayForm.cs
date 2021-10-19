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
            foreach (PieChartData data in pieChartDataList)
            {
                List<DataPoint> dps = new List<DataPoint> {
                    new DataPoint { Argument = "ATO",    Value = data.Ato},
                    new DataPoint { Argument = "DILE ATO",    Value = data.DileAto},
                    new DataPoint { Argument = "DUHA-DUHA",       Value = data.DuhaDuha},
                    new DataPoint { Argument = "INC",     Value = data.INC}
                };
                add(data.BarangayName, dps);
            }
        }

        private void add(string barangayName, List<DataPoint> dataPoints)
        {
            ChartControl pieChart = new ChartControl();
            pieChart.Height = 200;
            pieChart.Titles.Add(new ChartTitle() { Text = barangayName });

            // Create a pie series.
            Series series1 = new Series("Land Area by Country", ViewType.Pie);

            // Bind the series to data.
            series1.DataSource = dataPoints;
            series1.ArgumentDataMember = "Argument";
            series1.ValueDataMembers.AddRange(new string[] { "Value" });

            // Add the series to the chart.
            pieChart.Series.Add(series1);

            // Format the the series labels.
            series1.Label.TextPattern = "{VP:p0} ({V:.##} Voters)";

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
            myView.RuntimeExploding = true;

            // Customize the legend.
            pieChart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;

            // Add the chart to the form.
            pieChart.Dock = DockStyle.Top;
            xtraScrollableControl1.Controls.Add(pieChart);
        }
    }
}
