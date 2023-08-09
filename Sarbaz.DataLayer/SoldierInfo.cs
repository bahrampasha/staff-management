using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sarbaz.DataLayer
{
    public class SoldierInfo
    {
        public int ID { get; set; }
        public Nullable<long> FileNumber { get; set; }
        public Nullable<long> PersonnelID { get; set; }
        public string Name { get; set; }
        public string FamilyName { get; set; }
        public string FatherName { get; set; }
        public Nullable<long> NationalCode { get; set; }
        public string BirthDate { get; set; }
        public Nullable<byte> Education { get; set; }
        public string majority { get; set; }
        public Nullable<long> HomePhoneNumber { get; set; }
        public Nullable<long> Mobile { get; set; }
        public string Email { get; set; }
        public Nullable<long> PostalCode { get; set; }
        public string Bbirthplace { get; set; }
        public Nullable<byte> Province { get; set; }
        public Nullable<int> City { get; set; }
        public Nullable<int> Distance { get; set; }
        public Nullable<bool> Married { get; set; }
        public Nullable<byte> Child { get; set; }
        public Nullable<byte> Adoption { get; set; }
        public string Adress { get; set; }
        public Nullable<byte> Unit { get; set; }
        public byte[] image { get; set; }
        public Nullable<int> Raste { get; set; }
        public Nullable<int> Grade { get; set; }
        public string Garrison { get; set; }
        public string StartDate { get; set; }
        public string FinishDate { get; set; }
        public Nullable<int> DutyDurationMonth { get; set; }
        public Nullable<int> DutyDurationDay { get; set; }
        public string EndOfTraining { get; set; }
        public string MilitarySchool { get; set; }
        public string RegisteringPlace { get; set; }
        public string TypeOfDuty { get; set; }
        public Nullable<int> TypeOfEnterance { get; set; }
        public Nullable<int> DutyRemaning { get; set; }
        public Nullable<int> EyeColor { get; set; }
        public Nullable<int> HairColor { get; set; }
        public Nullable<int> SkinColor { get; set; }
        public Nullable<int> BloodType { get; set; }
        public Nullable<byte> Weight { get; set; }
        public Nullable<byte> Height { get; set; }
        public Nullable<bool> Glasses { get; set; }
        public string SpecialSign { get; set; }
        public Nullable<byte> PhysicalHealth { get; set; }
        public Nullable<byte> MentalHealth { get; set; }
        public string DutyStatus { get; set; }
        public string IdentityPlaque { get; set; }
        public string Description { get; set; }
        public Nullable<int> KasriMonth { get; set; }
        public Nullable<int> KasriDay { get; set; }
    }
}
