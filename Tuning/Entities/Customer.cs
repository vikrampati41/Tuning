using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuning.Entities
{
    public class Customer : IEnumerable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public long Mobile { get; set; }
        public double Amount { get; set; }

        public IEnumerator GetEnumerator()
        {
            //Customer[] customers = new Customer[]
            //{
            //new Customer {Name="Vithal Wadje",City="Mumbai",Mobile=9966332211,Amount=89.45 },
            //new Customer { Name = "Sudhir Wadje", City = "Latur", Mobile = 9966332222, Amount =426.00 },
            //new Customer { Name = "Anil", City = "Delhi", Mobile = 9966332233, Amount = 5896.20 }
            //};
            return new Customer().GetEnumerator();
        }
    }

    public class Customer2 : IEnumerator
    {
        public object Current => throw new NotImplementedException();

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
