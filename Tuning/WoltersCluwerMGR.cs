using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuning
{
    public class WoltersCluwer
    {
        static int id = 0;



        static WoltersCluwer()
        { 
            //static constructor will call only once while 1st object
            //is creating of the class
        }

        public WoltersCluwer()
        {
        }
    }
    public class DerivedClass : WoltersCluwer { 


    }

    public class Program12
    {
        public static void Main1(string[] args)
        {
            DerivedClass a = new DerivedClass();
            DerivedClass a1 = new DerivedClass();
        }
    }
}
