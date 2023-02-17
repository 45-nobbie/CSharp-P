using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms
{
    public class SubStrings
    {
        public static void Substrings(string str)
        {
            StringBuilder sb = new StringBuilder();

            for(int i =0 ; i < str.Length; i++)
            {
                sb.Append(str[i]);
                Console.WriteLine(sb);
            }
        }
    }
}
