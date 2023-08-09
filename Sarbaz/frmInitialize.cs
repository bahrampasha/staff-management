using Sarbaz.DataLayer.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sarbaz
{
    public partial class frmInitialize : Form
    {
        public frmInitialize()
        {
            InitializeComponent();
        }

        private void frmInitialize_Load(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                tbtype.Text = db.GarrosonRepository.GetGarrisonInfo(1).GarrisonForce.ToString();
                tbgarrison.Text = db.GarrosonRepository.GetGarrisonInfo(1).Garrison1.ToString();
                tbcommander.Text = db.GarrosonRepository.GetGarrisonInfo(1).Commander.ToString();
                tbcommandergrade.Text = db.GarrosonRepository.GetGarrisonInfo(1).CommanderGrade.ToString();
                tbStaffCommander.Text = db.GarrosonRepository.GetGarrisonInfo(1).StaffCommander.ToString();
                tbStaffGrade.Text = db.GarrosonRepository.GetGarrisonInfo(1).StaffCommanderGrade.ToString();
                tbSoldiersCommander.Text = db.GarrosonRepository.GetGarrisonInfo(1).SoldiersCommander.ToString();
                tbSolComGrade.Text = db.GarrosonRepository.GetGarrisonInfo(1).SoldiersCommanderGrade.ToString();
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            UnitOfWork db = new UnitOfWork();
            var edit = db.GarrosonRepository.GetGarrisonInfo(1);
            edit.Garrison1 = tbgarrison.Text;
            edit.GarrisonForce = tbtype.Text;
            edit.Commander = tbcommander.Text;
            edit.CommanderGrade = tbcommandergrade.Text;
            edit.StaffCommander = tbStaffCommander.Text;
            edit.StaffCommanderGrade = tbStaffGrade.Text;
            edit.SoldiersCommander = tbSoldiersCommander.Text;
            edit.SoldiersCommanderGrade = tbSolComGrade.Text;

            if (db.GarrosonRepository.UpdateGarrisonInfo(edit))
            {
                db.Save();
                MessageBox.Show("تغییرات با موفقیت اعمال شد", "موفق", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("خطا", "ناموفق", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
