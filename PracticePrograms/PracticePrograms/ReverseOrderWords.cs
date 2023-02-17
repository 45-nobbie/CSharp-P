using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms
{
    public class ReverseOrderWords
    {
        public static string ReverserOrderOfWords(string str)
        {
            StringBuilder sb = new StringBuilder();
            string[] words = str.Split(" ");
            for(int i = words.Length-1; i>= 0; i--)
            {
                sb.Append(words[i]);
                sb.Append(" ");
            }
            return sb.ToString();
        }
    }
}
