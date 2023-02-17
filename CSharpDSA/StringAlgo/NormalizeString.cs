using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAlgo
{
    public class NormalizeString
    {
        public static string Normalize(string str)
        {
           return str.ToLower().Trim().Replace(",", "");
        }
    }
}
