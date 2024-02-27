using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Tuning
{
    public class ReverseString
    {
        public static void Main()
        {
            Display();
        }
        public static void Display()
        {
            Console.WriteLine("Enter string to print reverse order :");
            string strInput = Console.ReadLine();
            ReverseWords(strInput);
            //UsingFunction(strInput);
            //WithoutFunction(strInput);
        }
        static void ReverseWords(string input)
        {
            string[] words = input.Split(' '); 
            Array.Reverse(words);             
            Console.WriteLine("reverse string is : {0}", string.Join(" ", words));
            //I/P "vikram patil"
            //O/P "patil vikram"
        }
        private static void UsingFunction(string strInput)
        {
            //char[] arr = strInput.ToCharArray();
            //Array.Reverse(arr);
            //var res = new string(arr);

            Console.WriteLine("reverse string using functions");
            string[] strArr = strInput.Split(" ");
            string newStr = string.Empty;

            for (int i = 0; i <= strArr.Length - 1; i++)
            {
                char[] charArr = strArr[i].ToCharArray();
                Array.Reverse(charArr);
                strArr[i] = new string(charArr);
            }

            Console.WriteLine("reverse string is : {0}", String.Join(" ", strArr));
        }

        private static void WithoutFunction(string strInput)
        {
            Console.WriteLine("reverse string using without functions");
            string[] strArr = strInput.Split(" ");
            string newStr = string.Empty;
            for (int i = 0; i <= strArr.Length - 1; i++)
            {
                string interString = strArr[i];
                for (int j = interString.Length - 1; j >= 0; j--)
                {
                    newStr = newStr + interString[j];
                }
                strArr[i] = newStr;
                newStr = string.Empty;
            }

            Console.WriteLine("reverse string is : {0}", String.Join(" ", strArr));
        }
    }
}
