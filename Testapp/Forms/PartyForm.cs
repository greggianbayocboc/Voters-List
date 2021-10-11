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
using System.ComponentModel.DataAnnotations;
using System.IO;
using DevExpress.XtraLayout.Helpers;
using DevExpress.XtraLayout;
using Testapp.Repository;
using Testapp.Models;

namespace gregg.Forms
{
    public partial class PartyForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        PartyRepository partyRepository = new PartyRepository();
        public Party party = null;
        public PartyForm()
        {
            InitializeComponent();

        }

        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.save();
            //this.Close();
        }

        private void PartyForm_Load(object sender, EventArgs e)
        {
            if (this.party != null)
            {
                textEdit1.Text = this.party.PartyName;
            }
        }

        bool save()
        {
            if (textEdit1.Text != string.Empty)
            {
                if (this.party != null)
                {
                    this.party.PartyName = textEdit1.Text;
                    partyRepository.Save(this.party);
                }
                else
                {
                    Party _party = new Party();
                    _party.PartyName = textEdit1.Text;
                    partyRepository.Save(_party);
                    this.party = _party;
                };
                return true;
            }
            else
                return false;
        }

        void saveAndClose()
        {
            if (save()) {
                this.Close();
            }
        }

        private void bbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void bbiSaveAndClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.saveAndClose();
        }

        private void textEdit1_Validating(object sender, CancelEventArgs e)
        {
            
        }
    }
}
