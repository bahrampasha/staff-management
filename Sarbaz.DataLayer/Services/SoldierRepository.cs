using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sarbaz.DataLayer.Repositories;
using System.Data.Entity;

namespace Sarbaz.DataLayer.Services
{
    public class SoldierRepository : ISarbazRepository
    { 
        private SoldierEntities1 db;
        public SoldierRepository(SoldierEntities1 context)
        {
            db = context;
        }
        public bool DeleteSoldier(int ID)
        {
            try
            {
                var properties = GetSoldierbyID(ID);
                DeleteSoldier(properties);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteSoldier(properties properties)
        {
            try
            {
                db.Entry(properties).State = EntityState.Deleted;
                return true;
            }
            catch
            {
                return false;
            }
        }
        
        public List<SoldiersFilter> GetAllSoldiers()
        {
            var list1 = from p in db.properties
                        join u in db.Unit on p.Unit equals u.UnitID
                        select new SoldiersFilter()
                        {
                            ID = p.ID,
                            Name = p.Name,
                            Familyname = p.FamilyName,
                            Fathername = p.FatherName,
                            Nationalcode = (long)p.NationalCode,
                            PersonnelID = (long)p.PersonnelID,
                            FileNumber = (long)p.FileNumber,
                            Unit = u.Unit1,
                            UnitID = u.UnitID
                        };
            return list1.ToList();

        }

        public properties GetSoldierbyID(int soldierID)
        {

            return db.properties.Find(soldierID);
        }
        public bool SearchByNationalCode(long nationalcode)
        {
            if (db.properties.SingleOrDefault(c => c.NationalCode == nationalcode) != null)
                return true;
            else
                return false;
        }

        public bool InsertSoldier(properties properties)
        {
            try
            {
                db.properties.Add(properties);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateSoldier(properties properties)
        {
            try
            {
                db.Entry(properties).State = EntityState.Modified;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<SoldiersFilter> GetSoldiersByFilter(string txtname, string txtfamilyname, string txtfathername,
            string txtnationalcode, string txtpersonnelid, string txtfilenumber, string cbunit)
        {

            var list1 = from p in db.properties
                        join u in db.Unit on p.Unit equals u.UnitID
                        select new SoldiersFilter()
                        {
                            ID = p.ID,
                            Name = p.Name,
                            Familyname = p.FamilyName,
                            Fathername = p.FatherName,
                            Nationalcode = (long)p.NationalCode,
                            PersonnelID = (long)p.PersonnelID,
                            FileNumber = (long)p.FileNumber,
                            UnitID = u.UnitID,
                            Unit = u.Unit1
                        };
            var list2 = new List<SoldiersFilter>();
            if (txtname == "" && txtfamilyname == "" && txtfathername == "" && txtfilenumber == "" && txtnationalcode == "" && txtpersonnelid == "" && cbunit == "0")
            {
                list2 = list1.ToList();
            }
            else if (cbunit == "0")
            {
                list2 = list1.Where(c => c.Name.Contains(txtname) &&
                c.Familyname.Contains(txtfamilyname) &&
                c.Fathername.Contains(txtfathername) &&
                c.Nationalcode.ToString().Contains(txtnationalcode) &&
                c.PersonnelID.ToString().Contains(txtpersonnelid) &&
                c.FileNumber.ToString().Contains(txtfilenumber)).ToList();
            }
            else if (cbunit != "0")
            {
                list2 = list1.Where(c => c.Name.Contains(txtname) &&
                c.Familyname.Contains(txtfamilyname) &&
                c.Fathername.Contains(txtfathername) &&
                c.Nationalcode.ToString().Contains(txtnationalcode) &&
                c.PersonnelID.ToString().Contains(txtpersonnelid) &&
                c.FileNumber.ToString().Contains(txtfilenumber) &&
                c.UnitID.ToString().Contains(cbunit)).ToList();
            }
            return list2;

        }

        public bool InsertLeaving(Leavings leaving)
        {
            try
            {
                db.Leavings.Add(leaving);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateLeaving(Leavings leaving)
        {
            throw new NotImplementedException();
        }


        //---------------------------Deleting--------------------------
        public Leavings GetLeavingByID(int ID)
        {
            return db.Leavings.Find(ID);
        }
        public bool DeleteLeavingHistory(int ID)
        {
            try
            {
                Leavings history = GetLeavingByID(ID);
                DeleteLeavingHistory(history);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteLeavingHistory(Leavings history1)
        {
            try
            {
                db.Entry(history1).State = EntityState.Deleted;
                return true;
            }
            catch
            {
                return false;
            }
        }

        //---------------------------GetInformation--------------------------
        public List<LeavingHistory> GetLeavingHistoryByID(int soldierID)
        {
            var result = from L in db.Leavings
                         where L.SoldierID == soldierID
                         select new LeavingHistory()
                         {
                             ID = (int)L.ID,
                             soldierid = L.SoldierID,
                             exit = L.ExitDate,
                             enterance = L.EnteranceDate,
                             duration = (int)L.Duration,
                             user = L.User,
                             estehghaghi = (int)L.Estehghaghi,
                             tashvighi = (int)L.Tashvighi,
                             esterahat = (int)L.Esterahat,
                             saati = (int)L.Saati,
                             estelaji = (int)L.Estelaji,
                             toorahi = (int)L.Toorahi
                         };
            return result.ToList();
        }

        public List<SoldierInfo> GetSoldiersInfobyID(int soldierID)
        {
            var result2 = (from L in db.properties
                           join U in db.Unit on L.Unit equals U.UnitID
                           join R in db.Raste on L.Raste equals R.ID
                           join G in db.Grade on L.Grade equals G.ID
                           join E in db.Education on L.Education equals E.EducationID
                           where L.ID == soldierID
                           select new SoldierInfo
                           {
                               Name = L.Name,
                               FamilyName = L.FamilyName,
                               NationalCode = L.NationalCode,
                               FatherName = L.FatherName,
                               StartDate = L.StartDate,
                               FinishDate = L.FinishDate,
                               BirthDate = L.BirthDate,
                               DutyStatus = L.DutyStatus,
                               KasriMonth = L.KasriMonth,
                               KasriDay = L.KasriDay,
                               TypeOfDuty = L.TypeOfDuty
                               
                           });
            return result2.ToList();
        }

        public List<SoldierInfo> GetAllSoldiersInfo()
        {
            var result2 = (from L in db.properties
                           join U in db.Unit on L.Unit equals U.UnitID
                           join R in db.Raste on L.Raste equals R.ID
                           join G in db.Grade on L.Grade equals G.ID
                           join E in db.Education on L.Education equals E.EducationID
                           select new SoldierInfo
                           {
                               Name = L.Name,
                               FamilyName = L.FamilyName,
                               NationalCode = L.NationalCode,
                               FatherName = L.FatherName,
                               StartDate = L.StartDate,
                               FinishDate = L.FinishDate,
                               BirthDate = L.BirthDate,
                               DutyStatus = L.DutyStatus,
                               KasriMonth = L.KasriMonth,
                               KasriDay = L.KasriDay,
                               TypeOfDuty = L.TypeOfDuty

                           });
            return result2.ToList();
        }
    }
}
