using Sarbaz.DataLayer.Context;
using Sarbaz.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sarbaz.DataLayer
{
    public class  LetterMaker
    {
        public DataTable Ozviat(int soldierid,string letternumber,string date,string attachments,string to,string description,string sender)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                var moshakhasat = db.SoldierRepository.GetSoldierbyID(soldierid);

                DataTable dtprint = new DataTable();
                dtprint.Columns.Add("name");
                dtprint.Columns.Add("familyname");
                dtprint.Columns.Add("fathername");
                dtprint.Columns.Add("nationalcode");
                dtprint.Columns.Add("city");
                dtprint.Columns.Add("startdate");
                dtprint.Columns.Add("personnelid");
                dtprint.Columns.Add("sender");
                dtprint.Columns.Add("to");
                dtprint.Columns.Add("from");
                dtprint.Columns.Add("currentdate");
                dtprint.Columns.Add("letternumber");
                dtprint.Columns.Add("attachments");
                dtprint.Columns.Add("category");
                dtprint.Columns.Add("priority");
                dtprint.Columns.Add("subject");
                dtprint.Columns.Add("birthdate");
                dtprint.Columns.Add("dutytype");
                dtprint.Columns.Add("description");

                dtprint.Rows.Add(moshakhasat.Name.ToString(),           //نام
                                 moshakhasat.FamilyName.ToString(),     //نام خانوادگی
                                 moshakhasat.FatherName.ToString(),     //نام پدر
                                 moshakhasat.NationalCode.ToString(),   //کد ملی
                                 moshakhasat.City.ToString(),           //شهر
                                 moshakhasat.StartDate.ToString(),      //شروع خدمت
                                 moshakhasat.PersonnelID.ToString(),    //کد پرسنلی
                                 sender,                                //فرستنده
                                 to,                                    //به
                                 "تیپ تکاور انصار الحجه(عج) - قسمت نیروی انسانی - کارگزینی وظیفه",   //از
                                 date, //تاریخ جاری
                                 letternumber,                   //شماره نامه
                                 attachments,                              //پیوست
                                 "عادی",                            //طبقه بندی
                                 "عادی",                               //ارجحیت
                                 "گواهی عضویت",                       //موضوع
                                 moshakhasat.BirthDate.ToString(),     //تاریخ تولد
                                 moshakhasat.TypeOfDuty.ToString(),    //نوع خدمت
                                 description                             //توضیحات
                                 );
                return dtprint;
            }
            
        }
        public DataTable khedmat(int soldierid, string letternumber, string date, string attachments, string to, string description, string sender)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                
                var moshakhasat = db.SoldierRepository.GetSoldiersInfobyID(soldierid);
                DataTable dtprint = new DataTable();
                dtprint.Columns.Add("sender");
                dtprint.Columns.Add("to");
                dtprint.Columns.Add("from");
                dtprint.Columns.Add("currentdate");
                dtprint.Columns.Add("letternumber");
                dtprint.Columns.Add("attachments");
                dtprint.Columns.Add("category");
                dtprint.Columns.Add("priority");
                dtprint.Columns.Add("subject");
                dtprint.Columns.Add("description");
                dtprint.Columns.Add("text");

                dtprint.Rows.Add(sender,                                //فرستنده
                                 to,                                    //به
                                 "فرماندهی تیپ تکاور انصار الحجه(عج) - نزسا",   //از
                                 date, //تاریخ جاری
                                 letternumber,                   //شماره نامه
                                 attachments,                              //پیوست
                                 "عادی",                            //طبقه بندی
                                 "عادی",                               //ارجحیت
                                 "گواهی خدمت",                       //موضوع
                                 description,                             //توضیحات
                                 $"با صلوات بر محمد و آل محمد با احترام، بدین وسیله گواهی می شود برادر {moshakhasat[0].Name} {moshakhasat[0].FamilyName} فرزند {moshakhasat[0].FatherName} به شماره ملی {moshakhasat[0].NationalCode} متولد {moshakhasat[0].BirthDate} از تاریخ {moshakhasat[0].StartDate} الی {moshakhasat[0].FinishDate} با عضویت {moshakhasat[0].TypeOfDuty} در این یگان مشغول به خدمت بوده است و به دلیل {moshakhasat[0].DutyStatus} از این یگان تسویه حساب نموده و ترخیص گردیده است"
                                 );
                return dtprint;
            }
        }
        public DataTable FararReport(int soldierid, string letternumber, string date, string attachments, string to, string description, string sender)
        {
            using (UnitOfWork db = new UnitOfWork())
            {

                var moshakhasat = db.SoldierRepository.GetSoldiersInfobyID(soldierid);
                DataTable dtprint = new DataTable();
                dtprint.Columns.Add("sender");
                dtprint.Columns.Add("to");
                dtprint.Columns.Add("from");
                dtprint.Columns.Add("currentdate");
                dtprint.Columns.Add("letternumber");
                dtprint.Columns.Add("attachments");
                dtprint.Columns.Add("category");
                dtprint.Columns.Add("priority");
                dtprint.Columns.Add("subject");
                dtprint.Columns.Add("description");
                dtprint.Columns.Add("text");

                dtprint.Rows.Add(sender,                                //فرستنده
                                 to,                                    //به
                                 "فرماندهی تیپ تکاور انصار الحجه(عج) - نزسا",   //از
                                 date, //تاریخ جاری
                                 letternumber,                   //شماره نامه
                                 attachments,                              //پیوست
                                 "عادی",                            //طبقه بندی
                                 "عادی",                               //ارجحیت
                                 "گواهی خدمت",                       //موضوع
                                 description,                             //توضیحات
                                 $"با صلوات بر محمد و آل محمد با احترام، بدین وسیله گواهی می شود برادر {moshakhasat[0].Name} {moshakhasat[0].FamilyName} فرزند {moshakhasat[0].FatherName} به شماره ملی {moshakhasat[0].NationalCode} متولد {moshakhasat[0].BirthDate} از تاریخ {moshakhasat[0].StartDate} الی {moshakhasat[0].FinishDate} با عضویت {moshakhasat[0].TypeOfDuty} در این یگان مشغول به خدمت بوده است و به دلیل {moshakhasat[0].DutyStatus} از این یگان تسویه حساب نموده و ترخیص گردیده است"
                                 );
                return dtprint;
            }
        }
    }
}
