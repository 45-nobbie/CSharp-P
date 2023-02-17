using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms
{
    public class ReverseOfString
    {
        public static string ReverseString(string str)
        {
            if (str == null)
            {
                return str;
            }
            else
            {
                StringBuilder sb = new StringBuilder();
                for (int i = str.Length - 1; i >= 0; i--)
                {
                    sb.Append(str[i]);
                }
                return sb.ToString();

            }
        }
    }
}
