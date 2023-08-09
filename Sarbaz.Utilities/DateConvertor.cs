using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sarbaz.Utilities
{
    public static class  DateConvertor
    {
        public static string ToShamsi (this DateTime date)
        {
            PersianCalendar tarikh = new PersianCalendar();
            return tarikh.GetYear(date).ToString() + "/" + tarikh.GetMonth(date).ToString("00") + "/" + tarikh.GetDayOfMonth(date).ToString("00"); 
        }
    }
}
