using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms
{
    public class Factorial
    {
        public static int FactorialR(int num)
        {
            if(num == 0) return 1;
            else
            {
                return num*FactorialR(num-1);
            }
        }
    }
}
