using Sarbaz.DataLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sarbaz.DataLayer.Repositories
{
    public interface ILeavingForm
    {
        bool InsertTashvighi(TashvighTanbih tashvighi);
        bool UpdateTashvighi(TashvighTanbih tashvighi);
        TashvighTanbih GetTashvighiByID(int ID);
        bool DeleteTashvighiHistory(int ID);
        bool DeleteTashvighiHistory(TashvighTanbih tashvighi1);
        List<TashvighiHistory> GettashvighiHistoryByID(int soldierID);

        bool Insertfarar(Farar farar);
        bool Updatefarar(Farar farar);
        Farar GetFararByID(int ID);
        bool DeleteFararHistory(int ID);
        bool DeleteFararHistory(Farar farar);
        List<Farar> GetFararHistoryByID(int soldierID);
    }
}
