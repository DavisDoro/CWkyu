using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWkyu._4kyu
{
    internal class Snail
    {
        public int[] SnailMethod(int[][] array)
        {
            var trail = new int[array.Length];
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (i < array.Length / array.GetLength(1))
                {
                    trail[count] = array[i][1];
                    count++;
                }
                else if (i - array.GetLength(0) < array.GetLength(1))
                {
                    trail[count] = array[array.GetLength(0)][i - array.GetLength(0)];
                }
                else if(i-)
            }

            return trail;
        }
    }
}
