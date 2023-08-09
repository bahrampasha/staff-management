using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sarbaz.DataLayer.Repositories
{
    public interface IGarrison
    {
        Garrison GetGarrisonInfo(int ID);
        bool UpdateGarrisonInfo(Garrison garrison);
    }
}
