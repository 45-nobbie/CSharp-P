using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class AggregateAndFilter
    {
        public static ArrayList FindEvenNumbers(int[] arr1, int[] arr2)
        {
            ArrayList res = new ArrayList();

            foreach(int i in arr1)
            {
                if (i %2 == 0 && i >= 0)
                {
                    res.Add(i);
                }
            }
            foreach(int i in arr2)
            {
                if(i%2 == 0 && i >= 0)
                {
                    res.Add(i);
                }
            }
            return res;
        }
    }
}
