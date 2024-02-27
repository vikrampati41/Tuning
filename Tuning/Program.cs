using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Tuning.Entities;
using Tuning.Inheritance;

namespace Tuning
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            //Console.WriteLine("Singletone practice");
            //Thread t1 = new Thread(TestSingltone.Instance1);
            //Thread t2 = new Thread(TestSingltone.Instance2);
            //t1.Start();
            //t2.Start();

            //Fibonaccie Series
            Fibonacci.GenFibonacciSeries();

            //Palindrome
            //Palindrome.CheckPalindrome();

            //Reverse String
            //ReverseString.Display();

            //Number patther trangle
            //NumberPattern.printTraingle();

            int[] values = new int[] { 1, 2, 3, 4 };
            string[] values2 = new string[] { "sd", "dfsd" };
            double average = values.Average();
            display();


            BaseClass bc = new BaseClass("vikram");
            //BaseClass bc = new BaseClass();
            bc.name = "VIKRAM";
            bc.id = 10;
            bc._name = "";

            BaseClass bc2= new DerivedClaas(0, "");
            bc2.id = 20;
            bc2.name = "";
            bc2._name = "";

            DerivedClaas bc1 = (DerivedClaas)bc;
            

            DerivedClaas dc = new DerivedClaas(0, "");
            dc.name = "vikram";

            dc.id = 20;
            dc.city = "ss";
            dc.state = "ss";
            dc.GetData();
        }

        

        public static void display()
        {
            //IEnumerable<bool> argument = new List<bool> {true, false, true };
            IEnumerable<Customer> argument = new List<Customer>();

            

            foreach (var item in argument)
            {
                Console.WriteLine(item);
            }


        }

        public interface ICustomer
        {
            int id { get; set; }
            
        }
    }
}
