using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sarbaz.DataLayer.Context;
using Sarbaz.DataLayer.Services;
using Sarbaz.Utilities;

namespace Sarbaz
{
    public partial class frmSearch : Form
    {
        public int soldierid;
        public frmSearch()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmSearch_Load(object sender, EventArgs e)
        {

            ComboBoxChange cbchange = new ComboBoxChange();
            cbSearchUnit.DataSource = cbchange.Unit();
            cbSearchUnit.ValueMember = "UnitID";
            cbSearchUnit.DisplayMember = "Unit";
            BindGrid();
        }

        void BindGrid()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgvSoldier.AutoGenerateColumns = false;
                dgvSoldier.DataSource = db.SoldierRepository.GetAllSoldiers();
            }
        }

        private void filter()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgvSoldier.AutoGenerateColumns = false;
                dgvSoldier.DataSource = db.SoldierRepository.GetSoldiersByFilter(tbSearchName.Text,
                    tbSearchLast.Text,
                    tbSearchFather.Text,
                    tbSearchNationalCode.Text,
                    tbSearchPersonnelId.Text,
                    tbSearchFileNumber.Text,
                    cbSearchUnit.SelectedValue.ToString());
            }

        }
        private void tbSearchName_TextChanged(object sender, EventArgs e)
        {
            filter();
           
        }

        private void tbSearchLast_TextChanged(object sender, EventArgs e)
        {
            filter();

        }

        private void tbSearchFather_TextChanged(object sender, EventArgs e)
        {
            filter();
        }

        private void tbSearchNationalCode_TextChanged(object sender, EventArgs e)
        {
            filter();
        }

        private void tbSearchFileNumber_TextChanged(object sender, EventArgs e)
        {
            filter();
        }

        private void tbSearchPersonnelId_TextChanged(object sender, EventArgs e)
        {
            filter();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            filter();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (dgvSoldier.CurrentRow != null)
            {
                string name = dgvSoldier.CurrentRow.Cells[2].Value.ToString() + " " + dgvSoldier.CurrentRow.Cells[3].Value.ToString();
                DialogResult result = FarsiMessageBox.MessageBox.Show("اخطار", $"آیا از حذف {name} مطمئنید؟", FarsiMessageBox.MessageBox.Buttons.YesNo, FarsiMessageBox.MessageBox.Icons.Warning);
                if (result == DialogResult.Yes)
                {
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        int SoldierID = int.Parse(dgvSoldier.CurrentRow.Cells[0].Value.ToString());
                        db.Save();
                        BindGrid();
                        if (db.SoldierRepository.DeleteSoldier(SoldierID) == true)
                        {
                            MessageBox.Show("با موفقیت انجام شد");
                        }

                    }

                }
                else
                {

                }

            }
            else
            {
                MessageBox.Show("موردی انتخاب نشده است!");
            }
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            if (dgvSoldier.CurrentRow != null)
            {
                soldierid = int.Parse(dgvSoldier.CurrentRow.Cells[0].Value.ToString());
                this.Close();
            }
            else
            {
                MessageBox.Show("موردی انتخاب نشده است!");
            }
        }

        private void dgvSoldier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            using (UnitOfWork db2 = new UnitOfWork())
            {
                if (dgvSoldier.CurrentRow != null)
                {

                    var moshakhasat2 = db2.SoldierRepository.GetSoldierbyID((int)dgvSoldier.CurrentRow.Cells[0].Value);
                    ImageRepository img = new ImageRepository();
                    picSearchPersonnel.Image = img.ConvertBinaryToImage(moshakhasat2.image);

                }
            }
        }
    }
}
