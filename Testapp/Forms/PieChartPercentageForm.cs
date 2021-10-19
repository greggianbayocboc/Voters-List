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
using DevExpress.XtraCharts;
using gregg.DTOs;
using Testapp.Models;
using Testapp.Repository;

namespace gregg.Forms
{
    public partial class PieChartPercentageForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        BarangayRepository barangayRepository = new BarangayRepository();
        public PieChartPercentageForm()
        {
            InitializeComponent();
        }
        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
           
        }

        private void bbiNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            List<Barangay> barangays = barangayRepository.getAll();
            add();
        }
        private void add() {
            ChartControl pieChart = new ChartControl();

            pieChart.Titles.Add(new ChartTitle() { Text = "By Barangay" });

            // Create a pie series.
            Series series1 = new Series("Land Area by Country", ViewType.Pie);

            // Bind the series to data.
            series1.DataSource = DataPoint.GetDataPoints();
            series1.ArgumentDataMember = "Argument";
            series1.ValueDataMembers.AddRange(new string[] { "Value" });

            // Add the series to the chart.
            pieChart.Series.Add(series1);

            // Format the the series labels.
            series1.Label.TextPattern = "{VP:p0} ({V:.##}M km²)";

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

        private void removeAll() {
            xtraScrollableControl1.Controls.Clear();
        }

        private void bbiRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            removeAll();
        }
    }
}