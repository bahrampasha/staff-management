﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sarbaz.DataLayer.Services
{
    public class TashvighiHistory
    {
        public int ID { get; set; }
        public int soldierid { get; set; }
        public string type { get; set; }
        public int duration { get; set; }
        public string description { get; set; }
        public string date { get; set; }
        public string user { get; set; }
        public string commander { get; set; }
        public string used { get; set; }

    }
}
