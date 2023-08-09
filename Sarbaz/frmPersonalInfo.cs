using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sarbaz.DataLayer.Services;
using Sarbaz.DataLayer.Context;
using Sarbaz.Utilities;
using System.Resources;
using System.Reflection;
using System.Globalization;
using Sarbaz.Business;
using Sarbaz.DataLayer;

namespace Sarbaz
{
    public partial class frmInfo : Form
    {
        public int soldierid;
        frmSearch frmsearch = new frmSearch();
        public frmInfo()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmsearch.ShowDialog();
            if (frmsearch.soldierid != 0 && frmsearch != null)
            {
                FillInfo();
            }
        }

        private void btnLeave_Click(object sender, EventArgs e)
        {
            frmLeave frmleave = new frmLeave(soldierid);
            frmleave.ShowDialog();
        }

        private void frmInfo_Load(object sender, EventArgs e)
        {
            cbDutyStatus.SelectedIndex = 0;
            cbDutyType.SelectedIndex = 0;
            cbApply.SelectedIndex = 0;
            cbEyeColor.SelectedIndex = 0;
            cbHairColor.SelectedIndex = 0;
            cbSkinColor.SelectedIndex = 0;
            cbBloodType.SelectedIndex = 0;
            cbPhysicalHealth.SelectedIndex = 0;
            cbMentalHealth.SelectedIndex = 0;

            ComboBoxChange cbchange = new ComboBoxChange();
            cbEducation.DataSource = cbchange.Education();
            cbEducation.ValueMember = "EducationID";
            cbEducation.DisplayMember = "EducationLevel";

            cbGrade.DataSource = cbchange.Grade();
            cbGrade.ValueMember = "ID";
            cbGrade.DisplayMember = "Grade";

            cbUnit.DataSource = cbchange.Unit();
            cbUnit.ValueMember = "UnitID";
            cbUnit.DisplayMember = "Unit";

            cbCategory.DataSource = cbchange.Raste();
            cbCategory.ValueMember = "ID";
            cbCategory.DisplayMember = "Raste";

            cbOstan.DataSource = cbchange.refreshdata();
            cbOstan.ValueMember = "OstanID";
            cbOstan.DisplayMember = "Title";
            int countryid = Convert.ToInt32(cbOstan.SelectedValue.ToString());
        }

        private void cbOstan_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxChange cbchange = new ComboBoxChange();

            if (cbOstan.SelectedValue.ToString() != "")
            {
                Int32.TryParse(cbOstan.SelectedValue.ToString(), out int countryid);
                cbShahrestan.DataSource = cbchange.refreshstate(countryid);
                cbShahrestan.ValueMember = "ID";
                cbShahrestan.DisplayMember = "Title";
            }
        }

        public void FillInfo()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                this.soldierid = frmsearch.soldierid;
                ImageRepository img = new ImageRepository();
                var moshakhasat = db.SoldierRepository.GetSoldierbyID(soldierid);
                tbname.Text = moshakhasat.Name;
                tbfamilyname.Text = moshakhasat.FamilyName;
                tbfathername.Text = moshakhasat.FatherName;
                tbAdress.Text = moshakhasat.Adress;
                tbBirthDate.Text = moshakhasat.BirthDate;
                tbBirthPlace.Text = moshakhasat.Bbirthplace;
                tbEmail.Text = moshakhasat.Email;
                tbfamilyname.Text = moshakhasat.FamilyName;
                tbfathername.Text = moshakhasat.FatherName;
                tbDistance.Text = moshakhasat.Distance.ToString();
                tbHomePhoneNumber.Text = "0" + moshakhasat.HomePhoneNumber.ToString();
                tbMajority.Text = moshakhasat.majority;
                tbMobile.Text = "0" + moshakhasat.Mobile.ToString();
                tbNationalCode.Text = moshakhasat.NationalCode.ToString();
                cbOstan.SelectedValue = moshakhasat.Province.ToString();
                cbShahrestan.SelectedValue = moshakhasat.City.ToString();
                cbEducation.SelectedValue = moshakhasat.Education;
                tbPostalCode.Text = moshakhasat.PostalCode.ToString();
                tbFileNumber.Text = moshakhasat.FileNumber.ToString();
                if (moshakhasat.Married.Value == true)
                { rbSingle.Checked = false; rbMarried.Checked = true; }
                else
                { rbSingle.Checked = true; rbMarried.Checked = false; }
                numtbAdoption.Value = Convert.ToDecimal(moshakhasat.Adoption);
                numtbChild.Value = Convert.ToDecimal(moshakhasat.Child);
                if (moshakhasat.image != null) { picPersonnel.Image = img.ConvertBinaryToImage(moshakhasat.image); }
                /*---------------------------SecondTab----------------------------------------*/
                ResourceManager rm = new ResourceManager("Sarbaz.Rank", Assembly.GetExecutingAssembly());
                cbGrade.SelectedValue = moshakhasat.Grade;
                picRank.Image = (Bitmap)rm.GetObject($"daraje{moshakhasat.Grade}");
                cbCategory.SelectedValue = moshakhasat.Raste;
                picRaste.Image = (Bitmap)rm.GetObject($"raste{moshakhasat.Raste}");
                tbGarrison.Text = moshakhasat.Garrison;
                cbUnit.SelectedValue = moshakhasat.Unit;
                masktbStartDate.Text = moshakhasat.StartDate;
                masktbEndTraining.Text = moshakhasat.EndOfTraining;
                tbMilitarySchool.Text = moshakhasat.MilitarySchool;
                tbRegPlace.Text = moshakhasat.RegisteringPlace;
                masktbPersonnelID.Text = moshakhasat.PersonnelID.ToString();
                cbDutyType.SelectedItem = moshakhasat.TypeOfDuty;
                cbApply.SelectedItem = moshakhasat.TypeOfEnterance;
                cbDutyStatus.SelectedItem = moshakhasat.DutyStatus;
                tbIdentityPlaque.Text = moshakhasat.IdentityPlaque;
                maskedFinishDate.Text = moshakhasat.FinishDate;
                numDaysKasri.Value = (int)moshakhasat.KasriDay;
                numMonthKasri.Value = (int)moshakhasat.KasriMonth;
                numMonthDutarion.Value = (int)moshakhasat.DutyDurationMonth;
                numDayDuration.Value = (int)moshakhasat.DutyDurationDay;
                /*-------------------------ThirdTab------------------------------------------*/
                cbEyeColor.SelectedIndex = (int)moshakhasat.EyeColor;
                cbHairColor.SelectedIndex = (int)moshakhasat.HairColor;
                cbSkinColor.SelectedIndex = (int)moshakhasat.SkinColor;
                cbBloodType.SelectedIndex = (int)moshakhasat.BloodType;
                if (moshakhasat.Glasses.Value == true)
                { rbGlassesNo.Checked = false; rbGlassesYes.Checked = true; }
                else
                { rbGlassesNo.Checked = true; rbGlassesYes.Checked = false; }
                tbSpecialSign.Text = moshakhasat.SpecialSign.ToString();
                cbPhysicalHealth.SelectedIndex = (int)moshakhasat.PhysicalHealth;
                cbMentalHealth.SelectedIndex = (int)moshakhasat.MentalHealth;
                tbDescription.Text = moshakhasat.Description;
                numWeight.Value = Convert.ToDecimal(moshakhasat.Weight);
                numHeight.Value = Convert.ToDecimal(moshakhasat.Height);
            }
        }

        public void btnOkInfo_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                UnitOfWork db = new UnitOfWork();
                MaskTbToInt masktbtoint = new MaskTbToInt();
                ImageRepository img = new ImageRepository();
                var edit = db.SoldierRepository.GetSoldierbyID(soldierid);
                //---------------------------------------- Tab 1 ---------------------------------
                edit.Name = tbname.Text;
                edit.FamilyName = tbfamilyname.Text;
                edit.FatherName = tbfathername.Text;
                edit.Adress = tbAdress.Text;
                edit.BirthDate = tbBirthDate.Text;
                edit.Bbirthplace = tbBirthPlace.Text;
                edit.Email = tbEmail.Text;
                edit.Distance = int.Parse(tbDistance.Text);
                edit.HomePhoneNumber = masktbtoint.Masktoint(tbHomePhoneNumber.ToString());
                edit.majority = tbMajority.Text;
                edit.Mobile = masktbtoint.Masktoint(tbMobile.ToString());
                edit.NationalCode = masktbtoint.Masktoint(tbNationalCode.ToString());
                edit.Province = byte.Parse(cbOstan.SelectedValue.ToString());
                edit.City = byte.Parse(cbShahrestan.SelectedValue.ToString());
                edit.Education = byte.Parse(cbEducation.SelectedValue.ToString());
                edit.PostalCode = masktbtoint.Masktoint(tbPostalCode.ToString());
                edit.Adoption = byte.Parse(numtbAdoption.Value.ToString());
                edit.Child = byte.Parse(numtbChild.Value.ToString());
                edit.FileNumber = int.Parse(tbFileNumber.Text);
                try { edit.image = img.ConvertImageToBinary(picPersonnel.Image); }
                catch { MessageBox.Show("خطا در دخیره ی عکس", "ناموفق", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                if (rbMarried.Checked == true)
                { edit.Married = true; }
                else
                { edit.Married = false; }
                //---------------------------------------- Tab 2 ---------------------------------
                edit.Garrison = tbGarrison.Text;
                edit.Unit = (byte)cbUnit.SelectedIndex;
                edit.StartDate = masktbStartDate.Text;
                edit.EndOfTraining = masktbEndTraining.Text;
                edit.MilitarySchool = tbMilitarySchool.Text;
                edit.RegisteringPlace = tbRegPlace.Text;
                edit.DutyStatus = cbDutyStatus.SelectedItem.ToString();
                edit.PersonnelID = Int64.Parse(masktbPersonnelID.Text);
                edit.TypeOfDuty = cbDutyType.SelectedItem.ToString();
                edit.TypeOfEnterance = cbApply.SelectedItem.ToString();
                edit.DutyDurationMonth = (byte)numMonthDutarion.Value;
                edit.DutyDurationDay = (byte)numDayDuration.Value;
                edit.Grade = (byte)cbGrade.SelectedIndex;
                edit.Raste = (byte)cbCategory.SelectedIndex;
                edit.IdentityPlaque = tbIdentityPlaque.Text;
                edit.KasriDay = (int)numDaysKasri.Value;
                edit.KasriMonth = (int)numMonthKasri.Value;
                edit.DutyDurationMonth = (int)numMonthDutarion.Value;
                edit.DutyDurationDay = (int)numDayDuration.Value;
                edit.FinishDate = maskedFinishDate.Text;
                ////---------------------------------------- Tab 3 ---------------------------------
                edit.EyeColor = (byte)cbEyeColor.SelectedIndex;
                edit.HairColor = (byte)cbHairColor.SelectedIndex;
                edit.SkinColor = (byte)cbSkinColor.SelectedIndex;
                edit.BloodType = (byte)cbBloodType.SelectedIndex;
                edit.Weight = (byte)numWeight.Value;
                edit.Height = (byte)numHeight.Value;
                if (rbGlassesYes.Checked == true) { edit.Glasses = true; } else { edit.Glasses = false; }
                edit.SpecialSign = tbSpecialSign.Text;
                edit.PhysicalHealth = (byte)cbPhysicalHealth.SelectedIndex;
                edit.MentalHealth = (byte)cbMentalHealth.SelectedIndex;
                edit.Description = tbDescription.Text;

                if (db.SoldierRepository.UpdateSoldier(edit))
                {
                    db.Save();
                    MessageBox.Show("تغییرات با موفقیت اعمال شد", "موفق", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("خطا در ذخیره ی اطلاعات", "ناموفق", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnNewRecord_Click(object sender, EventArgs e)
        {
            UnitOfWork db = new UnitOfWork();
            MaskTbToInt masktbtoint = new MaskTbToInt();
            if (db.SoldierRepository.SearchByNationalCode(masktbtoint.Masktoint(tbNationalCode.Text)))
            {
                MessageBox.Show("اطلاعات تکراری", "ناموفق", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                    ImageRepository img = new ImageRepository();
                    var edit = db.SoldierRepository.GetSoldierbyID(soldierid);
                    //---------------------------------------- Tab 1 ---------------------------------
                    edit.Name = tbname.Text;
                    edit.FamilyName = tbfamilyname.Text;
                    edit.FatherName = tbfathername.Text;
                    edit.Adress = tbAdress.Text;
                    edit.BirthDate = tbBirthDate.Text;
                    edit.Bbirthplace = tbBirthPlace.Text;
                    edit.Email = tbEmail.Text;
                    edit.Distance = int.Parse(tbDistance.Text);
                    edit.HomePhoneNumber = masktbtoint.Masktoint(tbHomePhoneNumber.ToString());
                    edit.majority = tbMajority.Text;
                    edit.Mobile = masktbtoint.Masktoint(tbMobile.ToString());
                    edit.NationalCode = masktbtoint.Masktoint(tbNationalCode.ToString());
                    edit.Province = byte.Parse(cbOstan.SelectedValue.ToString());
                    edit.City = byte.Parse(cbShahrestan.SelectedValue.ToString());
                    edit.Education = byte.Parse(cbEducation.SelectedValue.ToString());
                    edit.PostalCode = masktbtoint.Masktoint(tbPostalCode.ToString());
                    edit.Adoption = byte.Parse(numtbAdoption.Value.ToString());
                    edit.Child = byte.Parse(numtbChild.Value.ToString());
                    edit.FileNumber = int.Parse(tbFileNumber.Text);
                    try { edit.image = img.ConvertImageToBinary(picPersonnel.Image); }
                    catch { MessageBox.Show("خطا در دخیره ی عکس", "ناموفق", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    if (rbMarried.Checked == true)
                    {
                        edit.Married = true;
                    }
                    else
                    {
                        edit.Married = false;
                    }
                    //---------------------------------------- Tab 2 ---------------------------------
                    edit.Garrison = tbGarrison.Text;
                    edit.Unit = (byte)cbUnit.SelectedIndex;
                    edit.StartDate = masktbStartDate.Text;
                    edit.EndOfTraining = masktbEndTraining.Text;
                    edit.MilitarySchool = tbMilitarySchool.Text;
                    edit.RegisteringPlace = tbRegPlace.Text;
                    edit.DutyStatus = cbDutyStatus.SelectedItem.ToString();
                    edit.PersonnelID = Int64.Parse(masktbPersonnelID.Text);
                    edit.TypeOfDuty = cbDutyType.SelectedItem.ToString();
                    edit.TypeOfEnterance = cbApply.SelectedItem.ToString();
                    edit.DutyDurationMonth = (byte)numMonthDutarion.Value;
                    edit.DutyDurationDay = (byte)numDayDuration.Value;
                    edit.Grade = (byte)cbGrade.SelectedIndex;
                    edit.Raste = (byte)cbCategory.SelectedIndex;
                    edit.IdentityPlaque = tbIdentityPlaque.Text;
                    edit.KasriDay = (int)numDaysKasri.Value;
                    edit.KasriMonth = (int)numMonthKasri.Value;
                    edit.DutyDurationMonth = (int)numMonthDutarion.Value;
                    edit.DutyDurationDay = (int)numDayDuration.Value;
                    edit.FinishDate = maskedFinishDate.Text;
                    ////---------------------------------------- Tab 3 ---------------------------------
                    edit.EyeColor = (byte)cbEyeColor.SelectedIndex;
                    edit.HairColor = (byte)cbHairColor.SelectedIndex;
                    edit.SkinColor = (byte)cbSkinColor.SelectedIndex;
                    edit.BloodType = (byte)cbBloodType.SelectedIndex;
                    edit.Weight = (byte)numWeight.Value;
                    edit.Height = (byte)numHeight.Value;
                    if (rbGlassesYes.Checked == true) { edit.Glasses = true; } else { edit.Glasses = false; }
                    edit.SpecialSign = tbSpecialSign.Text;
                    edit.PhysicalHealth = (byte)cbPhysicalHealth.SelectedIndex;
                    edit.MentalHealth = (byte)cbMentalHealth.SelectedIndex;
                    edit.Description = tbDescription.Text;

                    if (db.SoldierRepository.InsertSoldier(edit))
                    {
                        db.Save();
                        MessageBox.Show("تغییرات با موفقیت اعمال شد", "موفق", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("خطا در ذخیره ی اطلاعات", "ناموفق", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }


        private void btnLetters_Click(object sender, EventArgs e)
        {
            frmLetters frmletters = new frmLetters(soldierid);
            frmletters.ShowDialog();
        }

        private void picPersonnel_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ImageRepository img = new ImageRepository();
            picPersonnel.Image = img.GetImage();
        }

        private void cbGrade_SelectedIndexChanged(object sender, EventArgs e)
        {

            ResourceManager rm1 = new ResourceManager("Sarbaz.Rank", Assembly.GetExecutingAssembly());
            picRank.Image = (Bitmap)rm1.GetObject($"daraje{cbGrade.SelectedIndex.ToString()}");
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResourceManager rm2 = new ResourceManager("Sarbaz.Rank", Assembly.GetExecutingAssembly());
            picRaste.Image = (Bitmap)rm2.GetObject($"raste{cbCategory.SelectedIndex.ToString()}");
        }

        private void tbNationalCode_Validating(object sender, CancelEventArgs e)
        {
            MyValidator validator = new MyValidator();
            string result = validator.ValidateNationalCode(tbNationalCode.Text);
            if (result == null)
            {
                e.Cancel = false;
                errorProvider.SetError(tbNationalCode, result);
            }
            else
            {
                e.Cancel = true;
                errorProvider.SetError(tbNationalCode, result);
            }

        }

        private void tbBirthDate_Validating(object sender, CancelEventArgs e)
        {
            MyValidator validator = new MyValidator();
            string result = validator.DateValidator(tbBirthDate.Text);
            if (validator.DateValidator(tbBirthDate.Text) == null)
            {
                e.Cancel = false;
                errorProvider.SetError(tbBirthDate, result);
            }

            else
            {
                e.Cancel = true;
                errorProvider.SetError(tbBirthDate, result);
            }


        }

        private void tbHomePhoneNumber_Validating(object sender, CancelEventArgs e)
        {
            MyValidator validator = new MyValidator();
            string result = validator.PhoneNumberValidator(tbHomePhoneNumber.Text);
            if (validator.PhoneNumberValidator(tbHomePhoneNumber.Text) == null)
            {
                e.Cancel = false;
                errorProvider.SetError(tbHomePhoneNumber, result);
            }

            else
            {
                e.Cancel = true;
                errorProvider.SetError(tbHomePhoneNumber, result);
            }
        }

        private void tbMobile_Validating(object sender, CancelEventArgs e)
        {
            MyValidator validator = new MyValidator();
            string result = validator.PhoneNumberValidator(tbMobile.Text);
            if (validator.PhoneNumberValidator(tbMobile.Text) == null)
            {
                e.Cancel = false;
                errorProvider.SetError(tbMobile, result);
            }

            else
            {
                e.Cancel = true;
                errorProvider.SetError(tbMobile, result);
            }
        }

        private void tbPostalCode_Validating(object sender, CancelEventArgs e)
        {
            MyValidator validator = new MyValidator();
            string result = validator.PostalCodeValidator(tbPostalCode.Text);
            if (result == null)
            {
                e.Cancel = false;
                errorProvider.SetError(tbPostalCode, result);
            }
            else
            {
                e.Cancel = true;
                errorProvider.SetError(tbPostalCode, result);
            }
        }

        private void cbEducation_Validating(object sender, CancelEventArgs e)
        {
            MyValidator validator = new MyValidator();
            string result = validator.ComboBoxValidator(cbEducation.SelectedIndex);
            if (result == null)
            {
                e.Cancel = false;
                errorProvider.SetError(cbEducation, result);
            }
            else
            {
                e.Cancel = true;
                errorProvider.SetError(cbEducation, result);
            }
        }

        private void cbOstan_Validating(object sender, CancelEventArgs e)
        {
            MyValidator validator = new MyValidator();
            string result = validator.ComboBoxValidator(cbOstan.SelectedIndex);
            if (result == null)
            {
                e.Cancel = false;
                errorProvider.SetError(cbOstan, result);
            }
            else
            {
                e.Cancel = true;
                errorProvider.SetError(cbOstan, result);
            }
        }

        private void cbShahrestan_Validating(object sender, CancelEventArgs e)
        {
            MyValidator validator = new MyValidator();
            string result = validator.ComboBoxValidator(cbShahrestan.SelectedIndex);
            if (result == null)
            {
                e.Cancel = false;
                errorProvider.SetError(cbShahrestan, result);
            }
            else
            {
                e.Cancel = true;
                errorProvider.SetError(cbShahrestan, result);
            }
        }

        private void btnFormClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        public void ClearFields()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TabControl)
                {
                    foreach (TabPage tp in c.Controls)
                    {

                        foreach (GroupBox gb in tp.Controls)
                        {
                            foreach (Control _ctrl in gb.Controls)
                            {
                                if (_ctrl is TextBox) { (_ctrl as TextBox).Clear(); }
                                if (_ctrl is ComboBox) { (_ctrl as ComboBox).SelectedIndex = 0; }
                                if (_ctrl is RadioButton) { (_ctrl as RadioButton).Checked = false; }
                                if (_ctrl is MaskedTextBox) { (_ctrl as MaskedTextBox).Clear(); }
                                if (_ctrl is NumericUpDown) { (_ctrl as NumericUpDown).Value = 0; }
                            }
                        }

                    }
                }
            }
            picPersonnel.Image = Properties.Resources.unknown2_01;
            tbGarrison.Text = "تیپ تکاور انصار الحجه(عج)";
            numMonthDutarion.Value = 21;
        }

        private void tbFileNumber_Validating(object sender, CancelEventArgs e)
        {
            MyValidator validator = new MyValidator();
            string result = validator.TbEmptyValidator(tbFileNumber.Text);
            if (result == null)
            {
                e.Cancel = false;
                errorProvider.SetError(tbFileNumber, result);
            }
            else
            {
                e.Cancel = true;
                errorProvider.SetError(tbFileNumber, result);
            }
            
        }
    }
}
