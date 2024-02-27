using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuning
{
    public class BasseClass
    {
        public virtual void DoWork() 
        { 
           Console.WriteLine("Called Base class member");
        }
        public virtual int WorkProperty
        {
            get { return 0; }
        }
    }
    public class DeriveddClass : BasseClass
    {
        public override void DoWork() 
        {
            Console.WriteLine("Called Derived class member");
        }
        public override int WorkProperty
        {
            get { return 0; }
        }
    }

    public class Client
    {
        public static void Main1()
        {
            DeriveddClass B = new DeriveddClass();
            B.DoWork(); // Calls the new(derived class) method.

            BasseClass A = B;
            A.DoWork(); // Calls the new(derived class) method.
        }
    }
 }
