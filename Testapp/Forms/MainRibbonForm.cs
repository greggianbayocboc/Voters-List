using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using Testapp;
using gregg.Reports;
using Testapp.Models;
using gregg.Repository;
using DevExpress.XtraReports.UI;

namespace gregg.Forms
{
    public partial class MainRibbonForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainRibbonForm()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            int i;
            for (i = 0; i < MdiChildren.Length; i++)
            {
                if (MdiChildren[i].GetType().FullName == "Testapp.Voters_List")
                {
                    MdiChildren[i].Activate();
                    MdiChildren[i].Refresh();
                    return;
                }
            }
            Voters_List xf = new Voters_List();
            xf.MdiParent = this;
            xf.Show();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            int i;
            for (i = 0; i < MdiChildren.Length; i++)
            {
                if (MdiChildren[i].GetType().FullName == "Testapp.ImportVotersForm")
                {
                    MdiChildren[i].Activate();
                    MdiChildren[i].Refresh();
                    return;
                }
            }
            ImportVotersForm xf = new ImportVotersForm();
            xf.MdiParent = this;
            xf.Show();
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            int i;
            for (i = 0; i < MdiChildren.Length; i++)
            {
                if (MdiChildren[i].GetType().FullName == "Testapp.TownConfiguration")
                {
                    MdiChildren[i].Activate();
                    MdiChildren[i].Refresh();
                    return;
                }
            }
            TownConfiguration xf = new TownConfiguration();
            xf.MdiParent = this;
            xf.Show();
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            int i;
            for (i = 0; i < MdiChildren.Length; i++)
            {
                if (MdiChildren[i].GetType().FullName == "Testapp.VotersPrintForm")
                {
                    MdiChildren[i].Activate();
                    MdiChildren[i].Refresh();
                    return;
                }
            }
            VotersPrintForm xf = new VotersPrintForm();
            xf.MdiParent = this;
            xf.Show();
        }

        private void MainRibbonForm_Load(object sender, EventArgs e)
        {
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            int i;
            for (i = 0; i < MdiChildren.Length; i++)
            {
                if (MdiChildren[i].GetType().Name == "ElectionDataSetting")
                {
                    MdiChildren[i].Activate();
                    MdiChildren[i].Refresh();
                    return;
                }
            }
            ElectionDataSetting xf = new ElectionDataSetting();
            xf.MdiParent = this;
            xf.Show();
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            int i;
            for (i = 0; i < MdiChildren.Length; i++)
            {
                if (MdiChildren[i].GetType().Name == "VoterAssessmentForm")
                {
                    MdiChildren[i].Activate();
                    MdiChildren[i].Refresh();
                    return;
                }
            }
            VoterAssessmentForm xf = new VoterAssessmentForm();
            xf.MdiParent = this;
            xf.Show();
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            LeaderPrintoutDtoRepository leaderPrintoutDtoRepository = new LeaderPrintoutDtoRepository();
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
                rpt.Parameters["purokLeader"].Value = $"{dto.PurokName} - {dto.PurokLeader}";
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
            tool.PreviewForm.MdiParent = this;
            tool.ShowPreview();
        }
    }
}