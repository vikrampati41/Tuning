using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuning
{
    public class Singleton
    {
        private static Singleton instance;
        private static object syncRoot = new object();
        private Singleton() { }
        public static Singleton Instance
        {
            get 
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                        {
                            instance = new Singleton();
                            Console.WriteLine("Created new singletone instance");
                        }
                        else
                        {
                            Console.WriteLine("Already Created singletone instance");
                        }
                    }
                }
                return instance;
            }
        }        
    }

    public class TestSingltone
    {
        public static void Instance1()
        {
            var singltone = Singleton.Instance;
            
        }
        public static void Main12355()
        {
            char charr = 'c';
            int i = charr;
            charr = (char)i;
            var singltone = Singleton.Instance;
        }

    }

    public static class ssingleton
    {
        static int val = 1;
    }
}
