using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAlgo
{
    public class ParseNSearch
    {
        public static bool ParseString(string str)
        {
            //parsing a string with two options
            Console.WriteLine("Option 1");

            foreach(char c in str)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine("Option 2");

            for(int i = 0; i< str.Length; i++)
            {
                char c = str[i];
                Console.WriteLine(str[i]);
            }
            return true;
        }
        public static bool IsEvenIndex(string str, char ch)
        {
            if(String.IsNullOrEmpty(str)) return false;
            for (int i = 0; i < str.Length -1;i= i+2)
            {
                if (str[i] == ch)
                {
                    return true;
                }
            }
            return false;
            
        }
    }
}
