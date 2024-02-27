using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuning.Inheritance
{
    class A
    {
        public int id = 10;
        public string name { get; set; }


        protected virtual void F() { Console.WriteLine("X.F"); }
        protected virtual void F2() { Console.WriteLine("X.F2"); }
    }

    class B : A
    {
        sealed protected override void F() { Console.WriteLine("Y.F"); }
        protected override void F2() { Console.WriteLine("Y.F2"); }
    }

    class C : B
    {
        // Attempting to override F causes compiler error CS0239.
        //protected override void F() { Console.WriteLine("Z.F"); }

        // Overriding F2 is allowed.
        protected override void F2() { Console.WriteLine("Z.F2"); }
    }
    public class Multilevel
    {
        public static void Main1(string[] args)
        {
            C c = new C();    
            B b = new B();
            var name = b.name;
            var id = b.id;
            var cid = c.id;
        }

    }
}
