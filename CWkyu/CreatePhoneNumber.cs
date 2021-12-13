using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWkyu
{
    internal class CreatePhoneNumber
    {
        public string PhoneNr(int[] numbers)
        {
            string phoneNr = "(" + numbers[0].ToString() + numbers[1].ToString() + numbers[2].ToString() + ") ";
            for (int i = 3; i < 6; i++)
            {
                phoneNr += numbers[i].ToString();
            }
            phoneNr += "-";
            for (int i = 6; i < 10; i++)
            {
                phoneNr += numbers[i].ToString();
            }
            return phoneNr;
        }
    }
}
