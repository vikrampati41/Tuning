using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuning
{
    public class _2Dto3x3Array
    {
        public static void Main1()
        {
            int i, j;
            int[,] arr1 = new int[2, 2];
            

            int[,] arr2 = { {1,4,7,9 }, {3,6,9,8 }, { 3, 6, 9, 8 } };
            Console.Write("\n\nRead a 2D array of size 3x3 and print the matrix :\n");
            Console.Write("------------------------------------------------------\n");


            /* Stored values into the array*/
            Console.Write("Input elements in the matrix :\n");
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.Write("element - [{0},{1}] : ", i, j);
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.Write("\nThe matrix is : \n");
            for (i = 0; i < 2; i++)
            {
                Console.Write("\n");
                for (j = 0; j < 2; j++)
                    Console.Write("{0}\t", arr1[i, j]);
            }
            Console.Write("\n\n");
        }

        
    }
}