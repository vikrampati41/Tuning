using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuning.Inheritance
{
    public class BaseClass
    {
        protected internal string _name = "";
        private protected string _dd = "";
        public int id { get; set; }
        public string name { get; set; }
        public virtual void GetData()
        {
            Console.WriteLine("baseclass method");
        }
        public BaseClass(string name)
        {
            this._name = name;
        }

        // Due to private protection level derived class cannot inherite base class
        //private BaseClass()
        //{ }

        //static constructor must be parameterless
        //
        //static BaseClass()
        //{
        //    
        //}
    }

    public class DerivedClaas : BaseClass
    {
        private int _id;
        public string city { get; set; }
        public string state { get; set; }

        public DerivedClaas(int id, string name) : base(name)
        {
            _id = id;
            
        }

        public override void GetData()
        {
            base._name = "";
            base._dd = "";
            Console.WriteLine("derivedclass method.");
        }

    }
    public class NextDerivedClass : BaseClass
    {
        public NextDerivedClass(string name) : base(name)
        {
        }

        public override void GetData()
        {
            Console.WriteLine("NextDerivedClass method.");

        }
    }
}
