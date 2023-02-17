using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class BinarySearch
    {
        public static Boolean BSearch(int[] arr, int target)
        {
            int start = 0;
            int end = arr.Length-1;
            
            while ( start <= end)
            {
                int mid = (start + end) / 2;
                if (target > arr[mid])
                {
                    start = mid + 1;
                    continue;
                }
                else if (target < arr[mid])
                {
                    end = mid - 1;
                    continue;
                }
                else
                {
                    return true;
                }
            }

            return false;
        }
    }
}
