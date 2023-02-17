using System;
using System.Collections;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            int[] arr2 = { -1, 0, 3, 5, 9, 12 };
            Console.WriteLine(Linear_search.LinearSearch(arr, 5));
            Console.WriteLine(Linear_search.indexSearch(arr, 4));
            /* int[] res = (int[])Linear_search.ToFindAll(arr, 3);
             foreach(int i in res)
             {
                 Console.WriteLine(i);
             }*/
            Console.WriteLine("-------------Binary Search---------------");
            Console.WriteLine(BinarySearch.BSearch(arr2,13));



            Console.WriteLine("----------------Filter & Aggregate---------------");
            ArrayList result = AggregateAndFilter.FindEvenNumbers(arr, arr2);
            foreach(int i  in result) Console.WriteLine(i);

            Console.WriteLine("-----------Reverse of an array-----------------------");
            /*int[] result2 =  ReverseArray.ReverseArr(arr2);
            Array.ForEach(result2, Console.WriteLine);*/
            ReverseArray.ReverseInPlace(arr2);
            Array.ForEach(arr2, Console.WriteLine);

            Console.WriteLine("--------------Roatation--------------------");
            Rotate_Array.LeftRotateArray(arr);
            Array.ForEach(arr, Console.WriteLine);
            Rotate_Array.RightRotateArray(arr2);
            Array.ForEach(arr2, Console.WriteLine);
        }
    }
}
