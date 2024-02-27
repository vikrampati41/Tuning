using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuning
{
    public class Fibonacci
    {
        public static void GenFibonacciSeries()
        {
            long n1 = 0;
            long n2 = 1;
            long temp = 0;
            int dd = 0;
            Console.WriteLine("Fibonacci Series {0}", n1);
            Console.WriteLine("Fibonacci Series {0}", n2);
            double j = 3;
            for (int i = 2; i <= 10; i++)
            {
                j++;
                temp = n1 + n2;
                Console.WriteLine("Fibonacci Series {0}", temp);
                n1 = n2;
                n2 = temp;
            }
        }
    }
}
