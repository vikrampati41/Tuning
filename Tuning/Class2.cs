using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Tuning
{
    interface IEmployeee
    {
        int ID { get; set; }
        string name { get; set; }
        void getMinSal();
    }
    interface IEmpoyeeeBonus
    {
        void CalculateBonuss();
    }

    public class Permonent : IEmployeee, IEmpoyeeeBonus
    {
        protected int _id;
        private string _name;

        public Permonent()
        {
        }

        public Permonent(int v1, string v2)
        {
            this._id = v1;
            this._name = v2;
        }

        public int ID 
        { 
            get => this._id; 
            set => this._id = value; 
        }
        public string name 
        { 
            get => this._name; 
            set => this._name = value; 
        }

        public void CalculateBonuss()
        {
        }

        public void getMinSal()
        {
        }
    }

    public class Temparary : IEmployeee, IEmpoyeeeBonus
    {
        public int ID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void CalculateBonuss()
        {
            //
        }

        public void getMinSal()
        {
            //
        }
    }

    public class Contract : IEmployeee
    {
        public int ID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void getMinSal()
        {
            //
        }
    }

    public class Class2
    {
        public static void Main1111()
        {
            Permonent per = new Permonent(1, "Tanaji");
            per.CalculateBonuss();
            per.getMinSal();
            
            per.ID = 2;
            per.name = "Vikram";

            var id = per.ID;
            var name = per.name;
            
            
        }
    }
}
