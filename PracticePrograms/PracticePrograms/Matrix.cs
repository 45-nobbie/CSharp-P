using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms
{
    public class Matrix
    {
        public static int SmallestInMatrix()
        {
            int[,] values = { { 7, 2, 3 }, { 4, 5, 6 }, { 1, 8, 9 } };

            int smallest = values[0, 0]; 

            for(int i = 0; i< values.GetLength(0); i++)
            {
                for (int j = 0; j < values.GetLength(1); j++)
                {

                    if (values[i, j] < smallest)
                    {   
                        smallest = values[i, j];
                    }
                }
            }
            return smallest;
        }
        public static int LargestInMatrix()
        {
            int[,] values = { { 7, 2, 3 }, { 4, 5, 6 }, { 1, 8, 9 } };

            int largest = values[0, 0];

            foreach(int i in values)
            {
                if(i > largest)
                {
                    largest = i;
                }
            }
            return largest;
        }
        public static int[,] Addition()
        {
            int[,] mat1 = { { 1, 2, 3 }, { 3, 4, 5 }, { 5, 6, 7 } };
            int[,] mat2 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            int[,] res = new int[3, 3];

            for(int i = 0; i< mat1.GetLength(0); i++)
            {
                for(int j = 0; j<mat2.GetLength(1); j++)
                {
                    res[i, j] = mat1[i, j] + mat2[i, j] ;
                }
            }
            return res;
        }
    }
}
