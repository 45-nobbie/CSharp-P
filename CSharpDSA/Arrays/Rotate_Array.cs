using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class Rotate_Array
    {
        public static void LeftRotateArray(int[] arr)
        {
            int x= arr[0];
            for(int i = 0; i < arr.Length-1; i++)
            {
                arr[i] = arr[i+1];
            }
            arr[arr.Length-1] = x;
        }
        //TODO
        public static void RightRotateArray(int[] arr)
        {
            int x = arr[arr.Length-1];
            for (int i = arr.Length - 1; i > 0; i--)
            {
                arr[i] = arr[i-1];
            }
            arr[0] = x;
        }
    }
}
