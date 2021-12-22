using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWkyu._5kyu
{
    internal class BestTravel
    {
        public int? chooseBestSum(int t, int k, List<int> ls)
        {
            int distance = 0;
            ls.Sort();
            for (int i = 0; i < k; i++)
            {
                distance += ls[i];
            }
            if (distance > t)
            {
                return -1;
            }



            return -1;
        }
    }
}
