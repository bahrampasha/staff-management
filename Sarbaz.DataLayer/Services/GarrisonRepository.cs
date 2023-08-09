using Sarbaz.DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sarbaz.DataLayer.Services
{
    public class GarrisonRepository : IGarrison
    {
        private SoldierEntities1 db;
        public GarrisonRepository(SoldierEntities1 context)
        {
            db = context;
        }
        public Garrison GetGarrisonInfo(int ID)
        {
            return db.Garrison.Find(ID);
        }

        public bool UpdateGarrisonInfo(Garrison garrison)
        {
            try
            {
                db.Entry(garrison).State = EntityState.Modified;
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
