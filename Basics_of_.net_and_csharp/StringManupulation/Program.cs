using System;
using System.Threading.Tasks.Dataflow;

namespace StringManupulation
{
    class Manupulation
    {
        static void Main(string[] args)
        {
            string str1 = "The quick brown fox jumps over the lazy dog.";
            string str2 = "This is a string";
            string str3 = "THIS is a STRING";
            string[] strs = { "one", "two", "three", "four" };

            // TODO: Length of a string 
            Console.WriteLine(str1.Length);

            // TODO: Access individual characters
            Console.WriteLine(str2[5]);

            // TODO: Iterate over a string like any other sequence of values
            foreach (char ch in str3)
            {
                Console.WriteLine(ch);
            }

            // TODO: String Concatenation         
            string outstr;
            outstr = str2 + str3;

            // TODO: Joining strings together with Join
            outstr = string.Join(",", strs);
            Console.WriteLine(outstr);
            // TODO: String Comparison

            // Equals just returns a regular Boolean
            bool isEqual = str2.Equals(str3);
            Console.WriteLine($"{isEqual}");

            // Compare will perform an ordinal comparison and return:
            // < 0 : first string comes before second in sort order
            // 0 : first and second strings are same position in sort order
            // > 0 : first string comes after the second in sort order
            Console.WriteLine($"{str2.CompareTo(outstr)}");
            Console.WriteLine($"{str2.CompareTo(str3)}");

            // TODO: Replacing content
            /*            str1 =  str1.Replace("fox", "cat");
                        Console.WriteLine(str1);*/
            Console.WriteLine($"{str1.Contains("fox",StringComparison.CurrentCultureIgnoreCase)}");
            //starts with and ends with function to verify whether the sting starts or end with the given string arguments
            Console.WriteLine($"{str1.StartsWith("The")}");
            Console.WriteLine($"{str1.EndsWith("Dog.",StringComparison.CurrentCultureIgnoreCase)}");
            //Index of or last index of 
            Console.WriteLine($"{str1.IndexOf('e')}");
            Console.WriteLine($"{str1.IndexOf("Fox", StringComparison.CurrentCultureIgnoreCase)}");
            Console.WriteLine($"{str1.LastIndexOf('e')}");
            Console.WriteLine($"{str1.LastIndexOf("Fox")}");

            string testStr1 = null;
            string testStr2 = " ";
            string testStr3 = string.Empty;

            Console.WriteLine($"{String.IsNullOrEmpty(testStr1)}");
            Console.WriteLine($"{String.IsNullOrEmpty(testStr2)}");
            Console.WriteLine($"{String.IsNullOrEmpty(testStr3)}");
            Console.WriteLine($"{String.IsNullOrWhiteSpace(testStr2)}");


        }
    }
}