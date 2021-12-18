using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWkyu._6kyu
{
    public class CamelCase
    {
        public string CamelCaseMethod(string str)
        {
            bool nextUpper = true;
            string newStr = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (nextUpper && str[i] != ' ')
                {
                    newStr += str[i].ToString().ToUpper();
                    nextUpper = false;
                }
                else if (str[i] == ' ')
                {
                    nextUpper = true;
                }
                else
                {
                    newStr += str[i];
                }
            }
            return newStr;
        }
    }
}
