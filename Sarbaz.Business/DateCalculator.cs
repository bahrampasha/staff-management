using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sarbaz.Business
{
    public class DateCalculator
    {
         public string FinishDate(string start, int monthDuration, int dayDuration)
        {
            DateTime.TryParseExact(start, "yyyy/MM/dd", CultureInfo.GetCultureInfo("fa-Ir"), DateTimeStyles.None, out DateTime date2);
            PersianCalendar pr = new PersianCalendar();
            int year = monthDuration / 12;
            int month = monthDuration % 12;
            return pr.GetYear(date2) + year + ((pr.GetMonth(date2) + month) / 12) + "/" + (pr.GetMonth(date2) + month) % 12 + "/" + (pr.GetDayOfMonth(date2) + dayDuration);
        }
    }
}
