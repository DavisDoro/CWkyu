using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWkyu._7kyu
{
    public class Limit
    {
        public static bool SmallEnough(int[] a, int limit)
        {
            foreach (var item in a)
            {
                if (item > limit)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
