using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuning
{
    public class YeildKeword
    {

        #region Without Yieild Keywords
        static void Main1()
        {
            int[] a = new int[10];
            a = func1(2, 10);
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(a[i]);
            }
            Console.Read();
        }
        public static int[] func1(int start, int number)
        {
            int[] _number = new int[number];
            for (int i = 0; i < number; i++)
            {
                _number[i] = start + 2 * i;
            }
            return _number;
        }
        #endregion Without Yieild Keywords

        #region Using Yield Keywords
        static void Main11()
        {
            foreach (var item in func(2, 10))
            {
                Console.WriteLine(item);
            }
            Console.Read();
        }
        public static IEnumerable func(int start, int number)
        {
            for (int i = 0; i < number; i++)
            {
                yield return start + 2 * i;
            }
        }
        #endregion
    }

}
