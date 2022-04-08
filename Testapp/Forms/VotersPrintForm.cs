using DevExpress.XtraReports.UI;
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
using Testapp.Models;
using Testapp.Repository;

namespace gregg.Forms
{
    public partial class VotersPrintForm : Form
    {

        public PersonDtoRepository personDtoRepository = new PersonDtoRepository();
        public LeaderPrintoutDtoRepository leaderPrintoutDtoRepository = new LeaderPrintoutDtoRepository();
        public VotersPrintForm()
        {
            InitializeComponent();
        }

        private void VotersPrintForm_Load(object sender, EventArgs e)
        {
           
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            VoterEnvelopeLabelReport rpt = new VoterEnvelopeLabelReport();
            rpt.DataSource = personDtoRepository.getPrintableVotersAll();
            ReportPrintTool tool = new ReportPrintTool(rpt);
            tool.ShowPreviewDialog();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            BlankReport initialReport = new BlankReport();
            initialReport.CreateDocument();
            List<LeaderPrintoutDto> dtos = leaderPrintoutDtoRepository.getGroupedReport();
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
    }
}
