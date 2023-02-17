using System;
using System.Collections;

namespace PracticePrograms
{
    class ProgramMain
    {
        static void Main(string[] args)
        {
            // Console.WriteLine(ReverseOfString.ReverseString("My Name is Ram"));

            // Console.WriteLine(ReverseOrderWords.ReverserOrderOfWords("My Name is Ram")); 


            // Console.WriteLine(PallindromeChecker.isPallindrome("Madam I'm Adam")); Pallindrome Checker

            //SubStrings.Substrings("This is a string"); Substring of a string 

            //Console.WriteLine(PrimeorNot.PrimeOrNot(1223)); Prime numbers

            //Fibonacci.GenFibo(10); Fibonnaci series

            //Console.WriteLine(Factorial.FactorialR(5));

            // HelloWorld.Hello();

            //Matrix Oprations
            //Console.WriteLine(Matrix.SmallestInMatrix());

            //Console.WriteLine(Matrix.LargestInMatrix());

            //Addition of two matrix
            /*int[,] result = Matrix.Addition();
            for(int i = 0; i <result.GetLength(0) ; i++)
            {
                for(int j = 0; j<result.GetLength(1) ; j++)
                {
                    Console.Write($"{result[i, j],-5} ");
                }
                Console.WriteLine();
            }*/

            //Sorting Algorithms
            //Bubble sort

            /* int[] nums = { 44, 5, 98, 54, 87, 193, 88 };

             int[] result = Sorting.BubbleSort(nums);

             foreach (int i in result)
             {
                 Console.Write(i + ", ");
             }*/

            //Selection Sort

            /*int[] nums = { 44, 5, 98, 54, 87, 193, 88 };

            Sorting.SelectionSort(nums);

            foreach (int i in nums)
            {
                Console.Write(i+", ");
            }*/

            //insersion sort
            /*int[] nums = { 44, 5, 98, 54, 87, 193, 88 };
            Sorting.InsersionSort(nums);
            foreach (int i in nums)
            {
                Console.Write(i+", ");
            }*/
            
        }
    }
}
