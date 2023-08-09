using Sarbaz.DataLayer;
using Sarbaz.DataLayer.Context;
using Sarbaz.Utilities;
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
    public partial class frmLeave : Form
    {
        public int soldierid = 0;
        public frmLeave(int soldierid)
        {
            InitializeComponent();
            this.soldierid = soldierid;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        void BindGrid()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgvLeavingHistory.AutoGenerateColumns = false;
                dgvTashvighTanbih.AutoGenerateColumns = false;
                dgvFarar.AutoGenerateColumns = false;
                var result = db.SoldierRepository.GetLeavingHistoryByID(soldierid);
                var result2 = db.TashvighiRepository.GettashvighiHistoryByID(soldierid);
                var result3 = db.TashvighiRepository.GetFararHistoryByID(soldierid);
                dgvLeavingHistory.DataSource = result;
                dgvTashvighTanbih.DataSource = result2;
                dgvFarar.DataSource = result3;
                lblEstehghsghi.Text = result.Select(c => c.estehghaghi).Sum().ToString();
                lblEstelaji.Text = result.Select(c => c.estelaji).Sum().ToString();
                lblEsterahat.Text = result.Select(c => c.esterahat).Sum().ToString();
                lblTashvighi.Text = result.Select(c => c.tashvighi).Sum().ToString();
                lblToorahi.Text = result.Select(c => c.toorahi).Sum().ToString();
                lblSaati.Text = result.Select(c => c.saati).Sum().ToString();
                lblTashvighiKol.Text= result2.Where(c => c.type.Equals("تشویقی")).Select(c=> c.duration).Sum().ToString();
                lblEstehghaghiKol.Text = result2.Where(c => c.type.Equals("استحقاقی")).Select(c => c.duration).Sum().ToString();
                lblEstelagiKol.Text = result2.Where(c => c.type.Equals("استعلاجی")).Select(c => c.duration).Sum().ToString();
                lblEsterahatKol.Text = result2.Where(c => c.type.Equals("استراحت")).Select(c => c.duration).Sum().ToString();
                lblToorahiKol.Text = result2.Where(c => c.type.Equals("بین راهی")).Select(c => c.duration).Sum().ToString();
                
            }
        }

        private void frmLeave_Load(object sender, EventArgs e)
        {
            BindGrid();
            maskedDate.Text = DateTime.Now.ToShamsi();
            maskedLeaveDate.Text = DateTime.Now.ToShamsi();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (tabLeave.SelectedTab == tabSabtMorkhasi)
            {
                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        Leavings leaving = new Leavings()
                        {
                            SoldierID = soldierid,
                            EnteranceDate = tbEndDate.Text,
                            ExitDate = tbStartDate.Text,
                            Duration = (int)numDuration.Value,
                            Estehghaghi = (int)numEstehghaghi.Value,
                            Tashvighi = (int)numTashvighi.Value,
                            Estelaji = (int)numEstelaji.Value,
                            Esterahat = (int)numEsterahat.Value,
                            Toorahi = (int)numToorahi.Value,
                            Saati = (int)numSaati.Value,
                            User = lblUser.Text
                        };
                        db.SoldierRepository.InsertLeaving(leaving);
                        db.Save();
                        BindGrid();
                    }
                }
            }
            else if (tabLeave.SelectedTab == tabTashvighi)
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    TashvighTanbih tashvigh = new TashvighTanbih()
                    {
                        SoldierID = soldierid,
                        Date = maskedDate.Text,
                        Description = tbDescription.Text,
                        User = lblUser.Text,
                        Commander = tbCommander.Text,
                        Duration = (int)numTashvighDuration.Value,
                        Type = cbType.SelectedItem.ToString(),
                    };
                    if (rbUsed.Checked == true) { tashvigh.Used = "بله"; }
                    else { tashvigh.Used = "خیر"; }
                    db.TashvighiRepository.InsertTashvighi(tashvigh);
                    db.Save();
                    BindGrid();
                }
            }
            else
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    Farar farar = new Farar()
                    {
                        SoldierID = soldierid,
                        EnterDate = maskedFararEnter.Text,
                        ExitDate = maskedFararExit.Text,
                        Date = maskedFararDate.Text,
                        Description = tbFararDescription.Text,
                        type = cbFararType.SelectedItem.ToString(),
                    };
                    db.TashvighiRepository.Insertfarar(farar);
                    db.Save();
                    BindGrid();
                }
            }
        }

        private void numDuration_Validating(object sender, CancelEventArgs e)
        {
            MyValidator validator = new MyValidator();
            string result = validator.NumericValidator((int)numDuration.Value);
            if (result == null)
            {
                e.Cancel = false;
                errorLeaving.SetError(numDuration, result);
            }

            else
            {
                e.Cancel = true;
                errorLeaving.SetError(numDuration, result);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbStartDate_Validating(object sender, CancelEventArgs e)
        {
            MyValidator validator = new MyValidator();
            string result = validator.DateValidator(tbStartDate.Text);
            if (result == null)
            {
                e.Cancel = false;
                errorLeaving.SetError(tbStartDate, result);
            }

            else
            {
                e.Cancel = true;
                errorLeaving.SetError(tbStartDate, result);
            }
        }

        private void tbEndDate_Validating(object sender, CancelEventArgs e)
        {
            MyValidator validator = new MyValidator();
            string result = validator.DateValidator(tbEndDate.Text);
            if (result == null)
            {
                e.Cancel = false;
                errorLeaving.SetError(tbEndDate, result);
            }

            else
            {
                e.Cancel = true;
                errorLeaving.SetError(tbEndDate, result);
            }
        }
        private void Total()
        {
            numDuration.Value = numEstehghaghi.Value + numEstelaji.Value + numEsterahat.Value + numTashvighi.Value + numToorahi.Value;
        }

        private void numEstehghaghi_ValueChanged(object sender, EventArgs e)
        {
            Total();
        }

        private void numTashvighi_ValueChanged(object sender, EventArgs e)
        {
            Total();
        }

        private void numEstelaji_ValueChanged(object sender, EventArgs e)
        {
            Total();
        }

        private void numEsterahat_ValueChanged(object sender, EventArgs e)
        {
            Total();
        }

        private void numToorahi_ValueChanged(object sender, EventArgs e)
        {
            Total();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (tabLeave.SelectedTab == tabSabtMorkhasi)
            {
                if (dgvLeavingHistory.CurrentRow != null)
                {
                    DialogResult result = FarsiMessageBox.MessageBox.Show("اخطار", "آیا از حذف مورد انتخابی مطمئنید؟", FarsiMessageBox.MessageBox.Buttons.YesNo, FarsiMessageBox.MessageBox.Icons.Warning);
                    if (result == DialogResult.Yes)
                    {
                        using (UnitOfWork db = new UnitOfWork())
                        {

                            int ID = (int)dgvLeavingHistory.CurrentRow.Cells[0].Value;
                            if (db.SoldierRepository.DeleteLeavingHistory(ID) == true)
                            {
                                db.Save();
                                BindGrid();
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
            else if (tabLeave.SelectedTab == tabTashvighi)
            {
                if (dgvTashvighTanbih.CurrentRow != null)
                {
                    DialogResult result = FarsiMessageBox.MessageBox.Show("اخطار", "آیا از حذف مورد انتخابی مطمئنید؟", FarsiMessageBox.MessageBox.Buttons.YesNo, FarsiMessageBox.MessageBox.Icons.Warning);
                    if (result == DialogResult.Yes)
                    {
                        using (UnitOfWork db = new UnitOfWork())
                        {

                            int ID = (int)dgvTashvighTanbih.CurrentRow.Cells[0].Value;
                            if (db.TashvighiRepository.DeleteTashvighiHistory(ID) == true)
                            {
                                db.Save();
                                BindGrid();
                                MessageBox.Show("با موفقیت انجام شد");
                            }

                        }

                    }
                    else
                    {
                    }

                }
            }
            else if (tabLeave.SelectedTab == tabFarar)
            {
                if (dgvFarar.CurrentRow != null)
                {
                    DialogResult result = FarsiMessageBox.MessageBox.Show("اخطار", "آیا از حذف مورد انتخابی مطمئنید؟", FarsiMessageBox.MessageBox.Buttons.YesNo, FarsiMessageBox.MessageBox.Icons.Warning);
                    if (result == DialogResult.Yes)
                    {
                        using (UnitOfWork db = new UnitOfWork())
                        {

                            int ID = (int)dgvFarar.CurrentRow.Cells[0].Value;
                            if (db.TashvighiRepository.DeleteFararHistory(ID) == true)
                            {
                                db.Save();
                                BindGrid();
                                MessageBox.Show("با موفقیت انجام شد");
                            }

                        }

                    }
                    else
                    {
                    }

                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                var result = db.TashvighiRepository.GetTashvighiByID(int.Parse(dgvTashvighTanbih.CurrentRow.Cells[0].Value.ToString()));
                if (rbUsed.Checked == true) { result.Used = "بله"; }
                else { result.Used = "خیر"; }
                if (db.TashvighiRepository.UpdateTashvighi(result) == true)
                {
                    db.Save();
                    BindGrid();
                    MessageBox.Show("با موفقیت انجام شد");
                }
            }
            
        }

        private void dgvFarar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            maskedFararDate.Text = dgvFarar.CurrentRow.Cells[4].Value.ToString();
            maskedFararEnter.Text = dgvFarar.CurrentRow.Cells[3].Value.ToString();
            maskedFararExit.Text = dgvFarar.CurrentRow.Cells[2].Value.ToString();
            tbFararDescription.Text = dgvFarar.CurrentRow.Cells[5].Value.ToString();
            cbFararType.SelectedItem = dgvFarar.CurrentRow.Cells[1].Value.ToString();
        }

        private void dgvTashvighTanbih_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            maskedDate.Text = dgvTashvighTanbih.CurrentRow.Cells[4].Value.ToString();
            tbDescription.Text = dgvTashvighTanbih.CurrentRow.Cells[3].Value.ToString();
            if (dgvTashvighTanbih.CurrentRow.Cells[7].Value.ToString() == "بله") { rbUsed.Checked = true; }
            else { rbNotUsed.Checked = true; }
            tbCommander.Text = dgvTashvighTanbih.CurrentRow.Cells[6].Value.ToString();
            numTashvighDuration.Value = int.Parse(dgvTashvighTanbih.CurrentRow.Cells[2].Value.ToString());
            cbType.SelectedItem = dgvTashvighTanbih.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
