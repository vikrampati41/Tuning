using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuning
{
    class Net {
        public virtual void Act() 
        { 
            Console.WriteLine("Net.Act");
        }
    }
    class Perl : Net {
        public override void Act()
        {
            Console.WriteLine("Perl.Act");
        } 
    }
    class Python : Net
    {
        public override void Act()
        {
            Console.WriteLine("Python.Act");
        }
    }
    class Program11
    {
        static void Main1()
        {// Use base class and derived types in a
            List<Net> nets = new List<Net>();
            nets.Add(new Perl());
            nets.Add(new Python());
            // Call virtual method on each instance.
            foreach (Net net in nets)
            {
                net.Act();
            }

        }
    }
}
