using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sarbaz.DataLayer
{
   public class SoldiersFilter
    {
        public string Name { get; set; }
        public string Familyname { get; set; }
        public string Fathername { get; set; }
        public long Nationalcode { get; set; }
        public long PersonnelID { get; set; }
        public long FileNumber { get; set; }
        public int UnitID { get; set; }
        public string Unit { get; set; }
        public int ID { get; set; }
    }
}
