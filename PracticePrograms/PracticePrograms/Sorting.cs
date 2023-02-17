using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms 
{
    public class Sorting
    {
        public static int[] BubbleSort(int[] nums)
        {
            for(int i = 0; i < nums.Length; i++)
            {
                for(int j = 0; j < nums.Length-i-1; j++)
                {
                    if (nums[j] > nums[j + 1])
                    {
                        int tmp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = tmp;
                    }
                }
            }
            return nums;
        } 
        public static int[] SelectionSort(int[] nums)
        {
            int tmp;
            for(int i = 0; i < nums.Length ; i++)
            {
                int minimum = nums[i];
                int idx = i;
                for(int j = i+1; j< nums.Length; j++)
                {
                    if (nums[j] < minimum)
                    {
                        minimum = nums[j];
                        idx = j;
                    }
                }
                tmp = nums[i];
                nums[i] = nums[idx];
                nums[idx] = tmp;

            }
            return nums;
        }
        public static int[] InsersionSort(int[] nums)
        {
            for(int i =1 ; i < nums.Length; i++)
            {
                int tmp = nums[i];

                int j = i - 1;
                while(j >= 0 && tmp < nums[j])
                {
                    nums[j+1] = nums[j];
                    j--;
                }
                nums[j+1] = tmp;
            }
            return nums;
        }
    }
}
