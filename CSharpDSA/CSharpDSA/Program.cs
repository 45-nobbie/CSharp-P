using System;
using System.Data;

namespace Algorithms
{

    class Program
    {
        static int Maximum(int a, int b, int c)
        {
            int max = a;

            if (b > max)
            {
                max = b;
            }
            if (c > max) 
            { 
                max = c;
            }
            return max;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Maximum(5, 10, 144));
            Console.WriteLine(Maximum(15, 0, 4));
            Console.WriteLine(Maximum(54, 190, 144));
            Console.WriteLine(Maximum(55477, 1787780, 90898144));
            Console.WriteLine(Maximum(51, 10, 44));
        }
    }
}