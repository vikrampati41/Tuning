using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuning
{
    public class Parent
    {
        public int Id { get; set; }
        public Parent()
        { 
        }
        public void ParentMethod()
        {
        }
    }

    public class Child : Parent
    {
        public int Name { get; set; }

        public void ChildMethod()
        {

        }
        //public Child() : base(10)
        //{

        //}

        //public Child(int id) : base(id)
        //{ 
        //}
    }

    class Persitance
    {
        static void Main1(string[] args)
        {
            Parent p = new Parent();
            Parent c = new Child();
            c.ParentMethod();

        }
    }
}
