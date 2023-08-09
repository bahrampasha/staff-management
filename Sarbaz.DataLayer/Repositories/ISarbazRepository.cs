using Sarbaz.DataLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Sarbaz.DataLayer.Services.SoldierRepository;

namespace Sarbaz.DataLayer.Repositories
{
    public interface ISarbazRepository
    {
        List<SoldiersFilter> GetAllSoldiers();
        List<SoldiersFilter> GetSoldiersByFilter(string txtname, string txtfamilyname, string txtfathername,
            string txtnationalcode, string personnelcode, string txtfilenumber, string cbunit);
        properties GetSoldierbyID(int soldierID);
        List<SoldierInfo> GetSoldiersInfobyID(int soldierID);
        List<SoldierInfo> GetAllSoldiersInfo();
        bool InsertSoldier(properties properties);
        bool UpdateSoldier(properties properties);
        bool DeleteSoldier(int ID);
        bool DeleteSoldier(properties properties);
        bool InsertLeaving(Leavings leaving);
        bool UpdateLeaving(Leavings leaving);
        Leavings GetLeavingByID(int ID);
        bool DeleteLeavingHistory(int ID);
        bool DeleteLeavingHistory(Leavings history1);
        List<LeavingHistory> GetLeavingHistoryByID(int soldierID);
        bool SearchByNationalCode(long nationalcode);
    }
}
