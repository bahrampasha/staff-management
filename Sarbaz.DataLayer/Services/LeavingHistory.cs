using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sarbaz.DataLayer.Services
{
    public class LeavingHistory
    {
        public int ID { get; set; }
        public int soldierid { get; set; }
        public string enterance { get; set; }
        public string exit { get; set; }
        public int duration { get; set; }
        public string user { get; set; }
        public int estehghaghi { get; set; }
        public int tashvighi { get; set; }
        public int esterahat { get; set; }
        public int saati { get; set; }
        public int estelaji { get; set; }
        public int toorahi { get; set; }
        public string date { get; set; }
    }
}
