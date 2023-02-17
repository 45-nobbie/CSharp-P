using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAlgo
{
    public class StringValidator
    {
        public static Boolean isUpperCase(String s)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in s)
            {
                if (c != ' ')
                {
                    sb.Append(c);
                }
            }
            s = sb.ToString();
            return s.All(char.IsUpper);
        }
        public static Boolean isLowerCase(String s)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in s)
            {
                if (c != ' ')
                {
                    sb.Append(c);
                }
            }
            s = sb.ToString();
            return s.All(char.IsLower);
        }

        public static Boolean isPasswordComplex(String s)
        {
            return s.Any(char.IsDigit) && s.Any(char.IsLower) && s.Any(char.IsUpper);
        }
    }
}
