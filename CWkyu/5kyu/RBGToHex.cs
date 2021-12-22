using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWkyu._5kyu
{
    internal class RBGToHex
    {
        public string Rgb(int r, int g, int b)
        {
            int[] RgbArray = new int[] {r, g, b};
            string hex = "";
            for (int i = 0; i < 3; i++)
            {
                if (RgbArray[i] > 255)
                {
                    RgbArray[i] = 255;
                }
                else if(RgbArray[i] < 0)
                {
                    RgbArray[i] = 0;
                }
            }
            foreach (var color in RgbArray)
            {
                if (color.ToString("X").Length == 1)
                {
                    hex += "0" + color.ToString("X");
                }
                else
                {
                    hex += color.ToString("X");
                }
            }
            return hex;
        }
    }
}
