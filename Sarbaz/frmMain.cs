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
using Sarbaz.DataLayer.Services;
using Sarbaz.DataLayer.Context;

namespace Sarbaz
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void دربارهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            PersianCalendar shamsi = new PersianCalendar();
            lblDateTime.Text ="   تاریخ جاری :  " + shamsi.GetYear(DateTime.Now).ToString()+"/"+ shamsi.GetMonth(DateTime.Now).ToString()+"/"+ shamsi.GetDayOfMonth(DateTime.Now).ToString();
            lblTime.Text = "   ساعت:  " + DateTime.Now.ToString("HH:mm:ss");
            UpdateStatistics();
        }

        private void UpdateStatistics()
        {
            UnitOfWork db = new UnitOfWork();
            lblAll.Text = db.StaticticsRepository.CountAllSoldiers().ToString();
            lblOfficer.Text = db.StaticticsRepository.CountOfficers().ToString();
            lblNonCommitioned.Text = db.StaticticsRepository.CountNoncommissionedOfficer().ToString();
            lblSoldiers.Text = db.StaticticsRepository.Soldiers().ToString();
            lblPhd.Text = db.StaticticsRepository.PhdAndAbove().ToString();
            lblMSc.Text = db.StaticticsRepository.MasterDegree().ToString();
            lblBSc.Text = db.StaticticsRepository.BScDegree().ToString();
            lblAssociated.Text = db.StaticticsRepository.AssociateDegree().ToString();
            lblDiploma.Text = db.StaticticsRepository.DiplomaAndBelow().ToString();
            lblMarried.Text = db.StaticticsRepository.Married().ToString();
            lblSingle.Text = db.StaticticsRepository.Single().ToString();
            lblNative.Text = db.StaticticsRepository.Native().ToString();
            lblNonNative.Text = db.StaticticsRepository.NonNative().ToString();
        }

        private void تنظیماتاولیهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInitialize frmInitialize = new frmInitialize();
            frmInitialize.ShowDialog();
        }

        private void btnMainInfo_Click(object sender, EventArgs e)
        {
            frmInfo frminfo = new frmInfo();
            frminfo.ShowDialog();
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = FarsiMessageBox.MessageBox.Show("خروج", "آیا خارج می شوید؟", FarsiMessageBox.MessageBox.Buttons.YesNo, FarsiMessageBox.MessageBox.Icons.Warning);
            if (result == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else
            {
               
            }
            
        }

        private void btnPersonalInfo_Click(object sender, EventArgs e)
        {
            frmInfo frminfo = new frmInfo();
            frminfo.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = "   ساعت:  " + DateTime.Now.ToString("HH:mm:ss");
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmReports frmreports = new frmReports();
            frmreports.Show();
        }
    }
}
