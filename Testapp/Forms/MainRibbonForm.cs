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
    }
}