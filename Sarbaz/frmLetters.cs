using Sarbaz.DataLayer;
using Sarbaz.DataLayer.Context;
using Sarbaz.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sarbaz
{
    public partial class frmLetters : Form
    {
        public int soldierid;
        public string lettertype = null;
        public string source = null;
        DataTable dtprint = null;
        public frmLetters(int soldierid)
        {
            this.soldierid = soldierid;
            InitializeComponent();
            Stimulsoft.Base.StiLicense.Key = "6vJhGtLLLz2GNviWmUTrhSqnOItdDwjBylQzQcAOiHl2AD0gPVknKsaW0un+3PuM6TTcPMUAWEURKXNso0e5OFPaZYasFtsxNoDemsFOXbvf7SIcnyAkFX/4u37NTfx7g+0IqLXw6QIPolr1PvCSZz8Z5wjBNakeCVozGGOiuCOQDy60XNqfbgrOjxgQ5y/u54K4g7R/xuWmpdx5OMAbUbcy3WbhPCbJJYTI5Hg8C/gsbHSnC2EeOCuyA9ImrNyjsUHkLEh9y4WoRw7lRIc1x+dli8jSJxt9C+NYVUIqK7MEeCmmVyFEGN8mNnqZp4vTe98kxAr4dWSmhcQahHGuFBhKQLlVOdlJ/OT+WPX1zS2UmnkTrxun+FWpCC5bLDlwhlslxtyaN9pV3sRLO6KXM88ZkefRrH21DdR+4j79HA7VLTAsebI79t9nMgmXJ5hB1JKcJMUAgWpxT7C7JUGcWCPIG10NuCd9XQ7H4ykQ4Ve6J2LuNo9SbvP6jPwdfQJB6fJBnKg4mtNuLMlQ4pnXDc+wJmqgw25NfHpFmrZYACZOtLEJoPtMWxxwDzZEYYfT";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

            if (cbLetters.SelectedIndex != 0 && tbLetterText != null && tbfrom != null && tbTo != null && tbSender != null)
            {
                stiPrint.Load(Application.StartupPath + lettertype);
                stiPrint.RegData(source, dtprint);
                stiPrint.Show();
            }
            else
            {
                //lettermaker.make
                FarsiMessageBox.MessageBox.Show("خطا", "لطفا گیرنده،فرستنده و متن نامه را وارد کنید", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Error);

            }



        }

        private void cbLetters_SelectedIndexChanged(object sender, EventArgs e)
        {
            LetterMaker letter = new LetterMaker();
            if (cbLetters.SelectedIndex != 0)
            {
                cbLetterClass.Enabled = false;
                cbLetterPriority.Enabled = false;
                tbLetterText.Enabled = false;
                tbfrom.Enabled = false;
                tbsubject.Enabled = false;
            }
            else
            {
                cbLetterClass.Enabled = true;
                cbLetterClass.SelectedIndex = 0;
                cbLetterPriority.Enabled = true;
                cbLetterPriority.SelectedIndex = 0;
                tbLetterText.Enabled = true;
                tbLetterText.Clear();
                tbfrom.Enabled = true;
                tbfrom.Clear();
                tbsubject.Enabled = true;
                tbsubject.Clear();
            }
            switch (cbLetters.SelectedIndex)
            {
                case 1:
                    tbfrom.Text = "تیپ تکاور انصار الحجه(عج) - قسمت نیروی انسانی - کارگزینی وظیفه";
                    tbAttachment.Text = "صلوات";
                    tbLetterText.Text = "متن";
                    cbLetterClass.SelectedIndex = 1;
                    cbLetterPriority.SelectedIndex = 2;
                    tbsubject.Text = cbLetters.SelectedItem.ToString();
                    dtprint = letter.Ozviat(soldierid, tbNumber.Text, tbDate.Text, tbAttachment.Text, tbTo.Text, tbComments.Text, tbSender.Text);
                    lettertype = "/ozviat.mrt";
                    source = "DTsource";
                    break;
                case 2:
                    tbfrom.Text = "فرماندهی تیپ تکاور انصار الحجه (عج) - نزسا";
                    tbAttachment.Text = "صلوات";
                    cbLetterClass.SelectedIndex = 1;
                    cbLetterPriority.SelectedIndex = 2;
                    tbsubject.Text = cbLetters.SelectedItem.ToString();
                    dtprint = letter.khedmat(soldierid, tbNumber.Text, tbDate.Text, tbAttachment.Text, tbTo.Text, tbComments.Text, tbSender.Text);
                    tbLetterText.Text = dtprint.Rows[0][10].ToString();
                    //tbLetterText.Text = dtprint.Rows[0][10].ToSring();
                    lettertype = "/khedmat.mrt";
                    source = "DT";
                    break;
                default:

                    break;
            }
        }

        private void frmLetters_Load(object sender, EventArgs e)
        {
            tbDate.Text = DateConvertor.ToShamsi(DateTime.Now);
            cbLetterPriority.SelectedIndex = 0;
            cbLetterClass.SelectedIndex = 0;
            cbLetters.SelectedIndex = 0;
        }
    }
}
