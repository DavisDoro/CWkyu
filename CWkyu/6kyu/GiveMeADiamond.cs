using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWkyu._6kyu
{
    internal class GiveMeADiamond
    {
        public static string print(int n)
        {
            string result = "";
            string diamonds = "*";
            int reduce = n;
            while (n > 0)
            {
                string print = "";
                for (int i = 0; i < n-1; i++)
                {
                    print += " ";
                }
                result += print + diamonds + "\n";
                diamonds += "*";
                n--;
            }
            while (n < reduce)
            {
                n++;
                string print = "";
                for (int i = 0; i < n; i++)
                {
                    print += " ";
                }
                diamonds = diamonds.Substring(0, reduce - print.Length);
                result += print + diamonds + "\n";
            }
            return result;
        }
    }
}
