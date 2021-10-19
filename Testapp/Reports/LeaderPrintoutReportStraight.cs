using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace gregg.Reports
{
    public partial class LeaderPrintoutReportStraight : DevExpress.XtraReports.UI.XtraReport
    {
        int counter = 0;
        public LeaderPrintoutReportStraight()
        {
            InitializeComponent();
        }

        private void xrLabel11_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
           
        }
    }
}
