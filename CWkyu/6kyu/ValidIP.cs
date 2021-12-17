using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CWkyu._6kyu
{
    public class ValidIP
    {
        string ipPattern = @"^((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9]?[0-9])\.){3}(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9]?[0-9])$";
        Regex regex = new Regex(ipPattern);

        string myIp = "255.255.255.255";

        bool validIp = regex.IsMatch(myIp);
    }
}
