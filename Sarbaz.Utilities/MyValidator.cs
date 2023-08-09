using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sarbaz.Utilities
{
    public class MyValidator
    {
       public string ValidateNationalCode (string tbNational)
        {
            string result = null;
            if (tbNational.Length < 12)
            {
                result =  "کد ملی 10 رقم می باشد";
            }
            else if (tbNational[0] == '0')
            {
                return  "اولین رقم کد ملی نمی تواند صفر باشد";
            }
            else if (tbNational.Contains(' '))
            {

                return "کد ملی نمی تواند شامل کاراکتر فاصله باشد";
            }
            else
            {
                result = null;
            }

            return result;
        }

        public string DateValidator(string tbDate)
        {
            string result = null;
            DateTime date;
            if( !DateTime.TryParseExact(tbDate, "yyyy/MM/dd", CultureInfo.GetCultureInfo("fa-Ir"),DateTimeStyles.None,out date))
            {
                result = "تاریخ وارد شده صحیح نمی باشد";
            }
            return result;
        }
        public string PhoneNumberValidator (string tbphone)
        {
            string result = null;
            if (tbphone[1]!='0'||tbphone.Length<15)
            {
                result = "(0xxx)xxx-xxxx";
            }

            return result;
        }

        public string PostalCodeValidator(string tbPostal)
        {
            string result = null;
            if (tbPostal.Length < 11)
            {
                result = "کد پستی 10 رقم می باشد";
            }
            else if (tbPostal[0] == '0')
            {
                return "اولین رقم کد پستی نمی تواند صفر باشد";
            }
            else if (tbPostal.Contains(' '))
            {

                return "کد پستی نمی تواند شامل کاراکتر فاصله باشد";
            }
            else
            {
                result = null;
            }

            return result;
        }
        public string ComboBoxValidator(int value)
        {
            string result = null;
            if (value == 0)
            { result = "یک مورد را انتخاب کنید"; }
            return result;
        }
        public string NumericValidator(int value)
        {
            if (value == 0)
            { return "این فیلد نمیتواند صفر باشد"; }
            else
            { return null; }
            
        }
        public string TbEmptyValidator(string text)
        {
            if(text==null)
            {
                return "این فیلد نمی تواند خالی باشد";
            }
            else
            { return null; }
        }
    }
}
