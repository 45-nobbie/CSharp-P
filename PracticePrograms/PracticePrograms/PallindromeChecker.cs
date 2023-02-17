using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms
{
    public class PallindromeChecker
    {
        public static bool isPallindrome(string s)
        {
            bool res = false;
            StringBuilder sb = new StringBuilder();


            foreach(char c in s)
            {
                if(!char.IsPunctuation(c) && c != ' ' && c != '^' && c != '$')
                {
                    sb.Append(c);
                }
            }


            string str =  sb.ToString();
            str = str.ToLower();
           
            StringBuilder sb2 = new StringBuilder();

            for(int i = str.Length- 1; i >= 0;i--)
            {
                sb2.Append(str[i]);
            }

            if (sb2.Equals(str))
            {
                return true;
            }
            return res;
        }
    }
}
