using System;

namespace Delegates_Events_Lambdas
{
    class Program
    {
        static string func1(int a, int b)
        {
            return (a+b).ToString();
        }
        static string func2(int a, int b) 
        {
            return (a*b).ToString();
        }
        static void Main(string[] args)
        {
            MyDelegate f = func1;
            Console.WriteLine("The sum of numbers are "+ f(10,20));
            f = func2;
            Console.WriteLine("The product is "+f(10,20));
            //using instance methord froma class

            //Delegates md = new Delegates();

            f = Delegates.instanceMethod1;
            Console.WriteLine("From the class: " + f(10, 20));
        }
    }
}