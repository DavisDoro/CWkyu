using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWkyu._8kyu
{
    internal class DutyFree
    {
        public static int DutyFree2(int normPrice, int Discount, int hol)
        {
            double saving = 0;
            int bottleCount = 0;
            do
            {
                saving += normPrice - (normPrice * Discount/100);
                bottleCount++;
            } while (saving <= hol);
            return bottleCount;
        }
    }
}
