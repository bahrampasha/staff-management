using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sarbaz.DataLayer.Repositories
{
    
    interface IComboBoxChange
    {
        DataTable refreshdata();
        DataTable refreshstate(int countryid);
        DataTable Education();
    }
}
