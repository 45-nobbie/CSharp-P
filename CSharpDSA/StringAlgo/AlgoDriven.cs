using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAlgo
{
    public class AlgoDriven
    {
        public static string Reverse(string str)
        {
            if(String.IsNullOrEmpty(str)) return str;
            
            StringBuilder sb = new StringBuilder(str.Length);

            for (int i = str.Length-1; i>= 0; i--)
            {
                sb.Append(str[i]);
            }
            str = sb.ToString();
            return str;

        }
        public static string Reverse2(string str)
        {
            char[] chars = str.ToCharArray();
            Array.Reverse(chars);

            str =  String.Join("", chars);
            return str;
        }
    }
}
