using Sarbaz.DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sarbaz.DataLayer.Services
{
    class StatisticsRepository : IStatistics
    {
        private SoldierEntities1 db;
        public StatisticsRepository(SoldierEntities1 context)
        {
            db = context;
        }
        public int AssociateDegree()
        {
            int count = db.properties.Where(c => c.Education ==4).Count();
            return count;
        }

        public int BScDegree()
        {
            int count = db.properties.Where(c => c.Education == 5).Count();
            return count;
        }

        public int CountAllSoldiers()
        {
            int count = db.properties.Where(c => c.ID > 0).Count();
            return count;
        }

        public int CountNoncommissionedOfficer()
        {
            int count = db.properties.Where(c => c.Grade>=5 && c.Grade<=9).Count();
            return count;
        }

        public int CountOfficers()
        {
            int count = db.properties.Where(c => c.Grade >= 10 && c.Grade <= 13).Count();
            return count;
        }

        public int DiplomaAndBelow()
        {
            int count = db.properties.Where(c => c.Education <=3 ).Count();
            return count;
        }

        public int Married()
        {
            int count = db.properties.Where(c => c.Married == true).Count();
            return count;
        }

        public int MasterDegree()
        {
            int count = db.properties.Where(c => c.Education == 6).Count();
            return count;
        }

        public int Native()
        {
            int count = db.properties.Where(c => c.City == 188).Count();
            return count;
        }

        public int NonNative()
        {
            int count = db.properties.Where(c => c.City != 188).Count();
            return count;
        }

        public int PhdAndAbove()
        {
            int count = db.properties.Where(c => c.Education >= 7).Count();
            return count;
        }

        public int Single()
        {
            int count = db.properties.Where(c => c.Married == false).Count();
            return count;
        }

        public int Soldiers()
        {
            int count = db.properties.Where(c => c.Grade >= 1 && c.Grade <= 4).Count();
            return count;
        }
    }
}
