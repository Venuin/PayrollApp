using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollApp
{
    abstract class Employee : IComparable<Employee>
    {
        public abstract decimal PaymentAmount {  get; protected set; }
        public static int Count {  get; protected set; }

        public abstract decimal Payment();

        public int CompareTo(Employee other) 
        {
            if (other == null) return 1;
            
            Employee otherEmployee = (Employee)other;
            if (otherEmployee != null)
            {
                //Console.WriteLine("a-> " + this.PaymentAmount + " b-> " + otherEmployee.PaymentAmount);
                return this.Payment().CompareTo(otherEmployee.Payment());
            }
            else
                throw new ArgumentException("The object is not employee");
        }


    }
}
