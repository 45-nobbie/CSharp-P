using System;
using System.Text;


namespace StringAlgo
{

    class Program
    {

       

        static void Main(string[] args)
        {
            /*StringAlgo.StringValidator st = new StringAlgo.StringValidator();*/
            Console.WriteLine(StringValidator.isUpperCase("THIS IS A STRING"));
            Console.WriteLine(StringValidator.isLowerCase("this will return false"));
            Console.WriteLine(StringValidator.isPasswordComplex("Abc43@"));

            Console.WriteLine("----------------Normaize--------------------");
            Console.WriteLine(NormalizeString.Normalize(" It's Over anakin, I have the high ground "));

            Console.WriteLine("------------------Parse & Search String--------------------------------");
            /*Console.WriteLine(ParseNSearch.ParseString("Hello There!"));*/
            Console.WriteLine(ParseNSearch.IsEvenIndex("This is a test string no 1", 'o'));
            Console.WriteLine(ParseNSearch.IsEvenIndex("abcdefghijklmnopqrstuvwxyz", 'y'));

            Console.WriteLine("---------------------Reversing The String---------------------");
            Console.WriteLine(AlgoDriven.Reverse("My name is Ram."));
            Console.WriteLine(AlgoDriven.Reverse2("My name is Ram."));
            Console.WriteLine("-------------------------Reversing Words---------------------");
            Console.WriteLine(ReversingWords.ReversingWords1("This is a string"));

            
        }

    }
}