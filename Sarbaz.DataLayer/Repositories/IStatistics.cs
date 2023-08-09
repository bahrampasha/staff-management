using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sarbaz.DataLayer.Repositories
{
    public interface IStatistics
    {
        int CountAllSoldiers();
        int CountOfficers();
        int CountNoncommissionedOfficer();
        int Soldiers();
        int PhdAndAbove();
        int MasterDegree();
        int BScDegree();
        int AssociateDegree();
        int DiplomaAndBelow();
        int Married();
        int Single();
        int Native();
        int NonNative();


    }
}
