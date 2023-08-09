using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sarbaz.DataLayer.Repositories;
using Sarbaz.DataLayer.Services;

namespace Sarbaz.DataLayer.Context
{
    public class UnitOfWork:IDisposable
    {
        SoldierEntities1 db = new SoldierEntities1();

        private ISarbazRepository _sarbazRepository;
        public ISarbazRepository SoldierRepository
        {
            get
            {
                if (_sarbazRepository == null)
                {
                    _sarbazRepository = new SoldierRepository(db);
                }
                return _sarbazRepository;
            }
        }
        private IStatistics _statisticsReporitory;
        public IStatistics StaticticsRepository
        {
            get
            {
                if (_statisticsReporitory == null)
                {
                    _statisticsReporitory = new StatisticsRepository(db);
                }
                return _statisticsReporitory;
            }
        }

        private IGarrison _garrisonRepository;
        public IGarrison GarrosonRepository
        {
            get
            {
                if (_garrisonRepository == null)
                {
                    _garrisonRepository = new GarrisonRepository(db);
                }
                return _garrisonRepository;
            }
        }
        private ILeavingForm _tashvighiRepositiry;
        public ILeavingForm TashvighiRepository
        {
            get
            {
                if (_tashvighiRepositiry == null)
                {
                    _tashvighiRepositiry = new TashvighiRepository(db);
                }
                return _tashvighiRepositiry;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}
