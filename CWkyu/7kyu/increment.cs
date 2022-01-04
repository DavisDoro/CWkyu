using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWkyu._7kyu
{
    public class increment
    {
        public static int[] Incrementer(int[] numbers)
        {
            int[] result = new int[numbers.Length];
            if (numbers.Length < 0)
            {
                return result;
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                result[i] = numbers[i] + i + 1;
                if (result[i] >= 10)
                {
                    result[i] = result[i] % 10;
                }
            }
            return result;
        }
    }
}
