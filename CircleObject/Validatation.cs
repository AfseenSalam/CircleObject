using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleObject
{
    internal class Validatation
    {
        public static bool inputValidating(string i, out double rad)
        {
            if (double.TryParse(i, out rad) && rad > 0)
            {
                return true;
            }
            return false;

        }
        
    }
}
