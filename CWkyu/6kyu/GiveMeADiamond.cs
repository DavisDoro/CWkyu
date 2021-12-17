using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWkyu._6kyu
{

    // You need to return a string that looks like a diamond shape when printed on the screen, 
    // using asterisk (*) characters.Trailing spaces should be removed, and every line must be 
    // terminated with a newline character (\n).
    // Return null/nil/None/... if the input is an even number or negative, as it is not possible to print a diamond of even or negative size.

    //    A size 3 diamond:
    // *
    //***
    // *

    public class GiveMeADiamond
    {
        public string Print(int n)
        {
            if(n % 2 == 0 || n < 0)
            {
                return null;
            }
            string result = "";
            string diamonds = "*";
            n = n / 2 + 1;
            int reduce = n;

            while (n > 0)
            {
                string print = "";
                for (int i = 0; i < n-1; i++)
                {
                    print += " ";
                }
                result += print + diamonds + "\n";
                diamonds += "**";
                n--;
            }
            int step = diamonds.Length - 4;
            while (n < reduce)
            {
                diamonds = "";
                
                for (int i = 0; i < step; i++)
                {
                    diamonds += "*";
                }
                step = diamonds.Length - 2;

                string print = "";
                for (int i = 0; i < n+ 1; i++)
                {
                    print += " ";
                }
                n++;
                if (diamonds.Length == 0)
                {
                    break;
                }
                result += print + diamonds + "\n";
            }
            return result;
        }
    }
}
