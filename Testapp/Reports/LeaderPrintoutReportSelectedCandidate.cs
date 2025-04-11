using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace gregg.Reports
{
    public partial class LeaderPrintoutReportSelectedCandidate : DevExpress.XtraReports.UI.XtraReport
    {
        int counter = 0;
        public LeaderPrintoutReportSelectedCandidate()
        {
            InitializeComponent();
        }

        private void xrLabel11_BeforePrint(object sender, CancelEventArgs e)
        {
           
        }
    }
}
