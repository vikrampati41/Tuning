using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuning
{
    public class Palindrome
    {
        public static void CheckPalindrome()
        {
            Console.WriteLine("Enter string to check whether string is palindrome or not: ");
            string strInput = Console.ReadLine();
            //nitin
            WithoutFunction(strInput);
            UsingFunction(strInput);

        }

        private static void WithoutFunction(string strInput)
        {
            Console.WriteLine("Checking using without functions.");
            string newString = string.Empty;
            for (int i = strInput.Length - 1; i >= 0; i--)
            {
                newString = newString + strInput[i];
            }

            if (newString == strInput)
            {
                Console.WriteLine("This is palindrome string: {0}", strInput);
            }
            else
            {
                Console.WriteLine("This is not palindrome string: {0}", strInput);

            }
        }

        private static void UsingFunction(string strInput)
        {
            Console.WriteLine("Checking using exsting functions.");
            char[] arr = strInput.ToCharArray();
            Array.Reverse(arr);
            if (strInput == new string(arr))
            {
                Console.WriteLine("This is palindrome string: {0}", strInput);
            }
            else
            {
                Console.WriteLine("This is not palindrome string: {0}", strInput);

            }
            Console.ReadKey();
        }
    }
}
