using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWkyu._6kyu
{
    public static class CountingDuplicates
    {
        public static int DublicateCount(string str)
        {
            str = str.ToLower();
            string testStr = str;
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < str.Length; j++)
                {
                    if (str[i] == testStr[j] && i != j)
                    {
                        count++;
                        str = str.Replace(str[i], ' ');
                    }
                }
            }
            return count;
        }
    }
}
