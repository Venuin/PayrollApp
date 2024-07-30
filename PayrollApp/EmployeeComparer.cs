using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollApp
{
    class EmployeeComparer : IComparer<Employee>
    {
        public int Compare(Employee e1, Employee e2)
        {
            if (e1 == null || e2 == null)
            {
                throw new ArgumentException("Null Reference Exception");
            }
            else
            {
                //Console.WriteLine("a-> " + e1.PaymentAmount + " b-> " + e2.PaymentAmount);
                return e1.Payment().CompareTo(e2.Payment());
            }
        }
    }
}
