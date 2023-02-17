using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class Linear_search
    {
        public static int LinearSearch(int[] arr, int target)
        {
            int item  = Array.Find(arr, element => element == target);

            return item;
        }
        public static int indexSearch(int[] arr, int target)
        {
            for(int i = 0; i< arr.Length; i++)
            {
                if(target == arr[i])
                {
                    return i;
                }
            }
            return -1;
        }
        public static Array ToFindAll(int[] arr, int target)
        {
            int[] items = Array.FindAll(arr, element => element >= target);
            
            return items;

        }
    }
}
