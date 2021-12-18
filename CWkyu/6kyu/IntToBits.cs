using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWkyu._6kyu
{
    public class IntToBits
    {
        public void GetBits(int n)
        {
        int value = 1234;
        string binary = Convert.ToString(value, 2);
        int count = 0;

        Console.WriteLine("Int value to bits: {0}", binary);

        for (int i = 0; i<binary.Length; i++)
        {
            if (binary[i].ToString() == "1")
            {
                count++;
            }
        }
        Console.WriteLine(count);
        }
    }
}

