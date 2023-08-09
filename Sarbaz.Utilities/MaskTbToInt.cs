using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sarbaz.Utilities
{
    public class MaskTbToInt
    {
        public Int64 Masktoint(string mask)
        {
            return Convert.ToInt64(string.Join("", mask.ToString().ToCharArray().Where(Char.IsDigit))); 
        }
    }
}
