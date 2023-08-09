using Sarbaz.DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sarbaz.DataLayer.Services
{
    class TashvighiRepository : ILeavingForm
    {
        private SoldierEntities1 db;
        public TashvighiRepository(SoldierEntities1 context)
        {
            db = context;
        }

        public bool DeleteFararHistory(int ID)
        {
            try
            {
                Farar farar = GetFararByID(ID);
                DeleteFararHistory(farar);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteFararHistory(Farar farar)
        {
            try
            {
                db.Entry(farar).State = EntityState.Deleted;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteTashvighiHistory(int ID)
        {
            try
            {
                TashvighTanbih history = GetTashvighiByID(ID);
                DeleteTashvighiHistory(history);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteTashvighiHistory(TashvighTanbih tashvighi1)
        {
            try
            {
                db.Entry(tashvighi1).State = EntityState.Deleted;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Farar GetFararByID(int ID)
        {
            return db.Farar.Find(ID);
        }

        public List<Farar> GetFararHistoryByID(int soldierID)
        {
            var result = db.Farar;
            return result.Where(c => c.SoldierID == soldierID).ToList();
                //from L in db.Farar
                //         where L.SoldierID == soldierID
                //         select new Farar
                //         {
                //             ID = L.ID,
                //             SoldierID = (int)L.SoldierID,
                //             type = L.type,
                //             Description = L.Description,
                //             EnterDate = L.EnterDate,
                //             ExitDate = L.ExitDate,
                //         };
            //return result.ToList();
        }

        public TashvighTanbih GetTashvighiByID(int ID)
        {
            return db.TashvighTanbih.Find(ID);
        }

        public List<TashvighiHistory> GettashvighiHistoryByID(int soldierID)
        {
            var result = from L in db.TashvighTanbih
                         where L.SoldierID == soldierID
                         select new TashvighiHistory
                         {
                             ID = L.ID,
                             soldierid = (int)L.SoldierID,
                             type = L.Type,
                             duration = (int)L.Duration,
                             description = L.Description,
                             user = L.User,
                             date = L.Date,
                             commander = L.Commander,
                             used = L.Used
                         };
            return result.ToList();
        }

        public bool Insertfarar(Farar farar)
        {
            try
            {
                db.Farar.Add(farar);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool InsertTashvighi(TashvighTanbih tashvighi)
        {
            try
            {
                db.TashvighTanbih.Add(tashvighi);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Updatefarar(Farar farar)
        {
            try
            {
                db.Entry(farar).State = EntityState.Modified;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateTashvighi(TashvighTanbih tashvighi)
        {
            try
            {
                db.Entry(tashvighi).State = EntityState.Modified;
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
