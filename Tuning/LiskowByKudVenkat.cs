using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuning
{
    interface IEmployee
    {
        int ID { get; set; }
        string Name { get; set; }
        decimal GetMinimumSalary();
    }

    interface IEmployeeBonus
    {
        decimal CalculateBonus(decimal salary);
    }

    public abstract class Emp : IEmployee, IEmployeeBonus
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public Emp()
        { }

        public Emp(int id, string name)
        {
            this.ID = id;
            this.Name = name;

        }

        public abstract decimal CalculateBonus(decimal salary);

        public override string ToString()
        {
            return string.Format("ID : {0} Name : {1}", this.ID, this.Name);
        }

        public abstract decimal GetMinimumSalary();
    }

    public class PermanentEmployee : Emp
    {
        public PermanentEmployee()
        { }

        public PermanentEmployee(int id, string name) : base(id, name)
        { }

        public override decimal CalculateBonus(decimal salary)
        {
            return (salary * .1M);
        }

        public override decimal GetMinimumSalary()
        {
            return 15000;
        }
    }

    public class TemporaryEmployee : Emp
    {
        public TemporaryEmployee()
        { }

        public TemporaryEmployee(int id, string name) : base(id, name)
        { }

        public override decimal CalculateBonus(decimal salary)
        {
            return (salary * .05M);
        }

        public override decimal GetMinimumSalary()
        {
            return 5000;
        }
    }

    public class ContractEmployee : IEmployee
    {
        public int ID { get; set; }

        public string Name { get; set; }
        public ContractEmployee()
        { }

        public ContractEmployee(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }

        public decimal GetMinimumSalary()
        {
            return 5000;
        }

        public override string ToString()
        {
            return string.Format("ID : {0} Name : {1}", this.ID, this.Name);
        }
    }

    public class LiskowByKudVenkat
    {
        static void Main1111(string[] args)
        {
            List<Emp> employees = new List<Emp>();
            Emp emp1 = new PermanentEmployee(1, "John");
            Emp emp2 = new TemporaryEmployee(2, "Jason");

           
            Console.WriteLine(string.Format("Employee {0} Bonus: {1} MinSalary: {2}",
            emp1.ToString(),
            emp1.CalculateBonus(100000).ToString(),
            emp1.GetMinimumSalary().ToString()));


            Console.WriteLine(string.Format("Employee {0} Bonus: {1} MinSalary: {2}",
            emp2.ToString(),
            emp2.CalculateBonus(100000).ToString(),
            emp2.GetMinimumSalary().ToString()));

            
            Console.WriteLine();

            IEmployee employeesOnly = new ContractEmployee(3, "Mike");

            Console.WriteLine(string.Format("Employee {0}  MinSalary: {1}",
            employeesOnly.ToString(),
            employeesOnly.GetMinimumSalary().ToString()));

            Console.ReadLine();
        }
    }
}
