using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWkyu
{
    public class _3or5
    {
        public int Solution(int value)
        {
            int result = 0;
            for (int i = 0; i < value; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    result += i;
                }
                else if (i % 3 == 0)
                {
                    result += i;

                }
                else if (i % 5 == 0)
                {
                    result += i;
                }
            }
            return result;
        }
    }
}
