using System;

namespace Tuning
{
    public class NumberPattern
    {
        public static void printTraingle()
        {
            int pyramid = 6;
            int space = 0;
            for (int i = 1; i <= pyramid; i++)
            {
                space = pyramid - i;
                for (int k = 1; k <= space; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i ; j++)
                {
                    Console.Write(j);
                }
                for (int l = 1; l <= i ; l++)
                {
                    Console.Write(l);
                }
                Console.WriteLine();
            }
        }
    }
}