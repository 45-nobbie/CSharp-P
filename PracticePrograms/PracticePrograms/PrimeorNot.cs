using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms
{
    public class PrimeorNot
    {
        public static bool PrimeOrNot(int num)
        {
            if(num == 0 || num == 1) return false;
            if(num == 2) return true;
            
            int lpcnt = (int) Math.Floor(Math.Sqrt(num));
            for(int i = 3; i<= lpcnt; i++)
            {
                if(num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
