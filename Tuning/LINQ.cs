using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Tuning
{
    public class LINQ
    {

        public int empid { get; set; }
        public string empname { get; set; }
        public double salary { get; set; }

        public static List<LINQ> GetEmployeeRecord()
        {
            List<LINQ> empList = new List<LINQ>();

            empList.Add(new LINQ { empid = 1, empname = "Vikram", salary = 10000 });
            empList.Add(new LINQ { empid = 2, empname = "Employee2", salary = 8500 });
            empList.Add(new LINQ { empid = 3, empname = "Employee3", salary = 14200 });
            empList.Add(new LINQ { empid = 4, empname = "Employee4", salary = 15000 });
            empList.Add(new LINQ { empid = 5, empname = "Employee5", salary = 10000 });
            empList.Add(new LINQ { empid = 6, empname = "Employee6", salary = 6000 });
            empList.Add(new LINQ { empid = 7, empname = "Employee7", salary = 20000 });
            empList.Add(new LINQ { empid = 8, empname = "Employee8", salary = 15000 });
            empList.Add(new LINQ { empid = 9, empname = "Employee9", salary = 7000 });
            empList.Add(new LINQ { empid = 10, empname = "Employee10", salary = 7000 });
            return empList;
        }
        public static void Main3333()
        {
            IEnumerable<int> list = new List<int> { 1, 2, 8, 6, 7, 3, 4, 1, 2 };

            #region Single
            // Return one record
            //Used when exactly one element is expected as a result.
            var single = list.Single(s => s == 8);

            //If sequnce contains more than one elements then throw exception  //System.InvalidOperationException
            //Exception: If sequece contains no matching elements then throw exception //System.InvalidOperationException
            try
            {
                single = list.Single(s => s == 2);
            }
            catch (Exception)
            {
            }

            //Sequence contains no matching element then throw exception
            try
            {
                single = list.Single(s => s == 10);
            }
            catch (Exception)
            {
            }
            #endregion

            #region SingleOrDefault
            // Return one record
            var singleOrDefault = list.SingleOrDefault(s => s == 9);

            //Sequnce contains more than one elements then throw exception
            //No exception, if sequence does not contain matching element
            try
            {
                singleOrDefault = list.SingleOrDefault(s => s == 2);
            }
            catch (Exception)
            {
            }

            //Sequence contains no matching element return null or zero
            try
            {
                singleOrDefault = list.SingleOrDefault(s => s == 10);
            }
            catch (Exception)
            {
            }
            #endregion

            #region First
            // Return one record
            //Used when exactly one element is expected as a result.
            var First = list.First(s => s == 1);

            //Sequnce contains more than one elements then return 1st matching element
            //Exception: If sequece contains no matching elements then throw exception //System.InvalidOperationException
            try
            {
                First = list.First(s => s == 2);
            }
            catch (Exception)
            {
            }

            //Sequence contains no matching element then throw exception
            try
            {
                First = list.First(s => s == 10);
            }
            catch (Exception)
            {
            }
            #endregion

            #region FirstOrDefault
            // Return one record
            var FirstOrDefault = list.FirstOrDefault(s => s == 1);

            //Sequnce contains more than one elements then return 1st matching element
            //No exception, if sequence does not contain matching element
            try
            {
                FirstOrDefault = list.FirstOrDefault(s => s == 2);
            }
            catch (Exception)
            {
            }

            //Sequence contains no matching element then return null or zero
            try
            {
                FirstOrDefault = list.FirstOrDefault(s => s == 10);
            }
            catch (Exception)
            {
            }
            #endregion

            #region Second, Third Highest Sal Using Linq

            IEnumerable<double> salary = new List<double> { 2000, 1000, 5000, 7000, 9000, 9000 };

            //Retrieve single records/element
            var result = GetEmployeeRecord().Where(p => p.empid > 1);


            //2nd Highest Sal
            //var result2 = salary.OrderByDescending(x => x)
            var result2 = GetEmployeeRecord()
                .OrderByDescending(x => x.salary)
               .Select(x => new { x.salary, x.empname })
               .Distinct()
               .Take(2)
               .LastOrDefault();

            //2nd Highest Sal
            var result3 = salary.OrderByDescending(x => x)
                .Distinct()
                .Skip(1)
                .FirstOrDefault();

            //2nd Highest Sal
            var result4 = salary.OrderByDescending(sal => sal)
                .Select(x => x)
                .Distinct()
                .Take(2)
                .Skip(1)
                .FirstOrDefault();


            #endregion


            //API call A()   1
            //API call A()   1

            //API call B()   0
            //API call B()   0

            //controller{

            //int i =0;

            // A()
            //{
            // i= i+1;
            // print i
            //}

            // B()
            //{
            // 
            // print i
            //}
            //}

        }
    }
}
