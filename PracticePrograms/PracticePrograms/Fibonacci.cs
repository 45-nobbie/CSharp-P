using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms
{
    public class Fibonacci
    {
        public static void GenFibo(int range)
        {
            int first = 0;
            int second = 1;
            Console.Write(first + ", " + second + ", ");
            for(int i = 0; i < range-2; i++)
            {
                int sum = first + second;
                Console.Write(sum +", ");
                first = second;
                second = sum;
            }
        }
    }
}
