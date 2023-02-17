using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace StringAlgo
{
    public class ReversingWords
    {
        public static string ReversingWords1(string str)
        {
            if (String.IsNullOrEmpty(str))
            {
                return str;
            }
            string[] words = str.Split(' ');
            
            for (int i = 0; i< words.Length; i++)
            {
                string word = words[i];
                words[i] = AlgoDriven.Reverse(word);
            }
            
            str =  String.Join(" ", words);

            return str;
        }
    }
}
