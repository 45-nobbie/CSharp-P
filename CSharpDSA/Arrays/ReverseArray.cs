using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class ReverseArray
    {
        public static int[] ReverseArr(int[] arr)
        {
            ArrayList res = new ArrayList();

            for(int i = arr.Length-1; i>= 0; i--)
            {
                res.Add(arr[i]);
            }
            return (int[])(res.ToArray(typeof(int)));
        }

        public static void ReverseInPlace(int[] arr)
        {

            for(int i = 0; i<arr.Length/2; i++)
            {
                int tmp = arr[i];
                arr[i] = arr[arr.Length- i -1];
                arr[arr.Length- i-1] = tmp;
            }
        }

    }
}
