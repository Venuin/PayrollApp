using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollApp
{
    class SalariedEmployee : Employee
    {   private decimal salary;
        public decimal Salary 
        {
            get { return salary; }
            set 
            {
                salary = value;
            }
        }
        public override decimal PaymentAmount {  get; protected set; }
        public SalariedEmployee(decimal salary) 
        {
            Salary = salary;
            Count++;
        }
        public override decimal Payment()
        {
            PaymentAmount = Salary;
            return PaymentAmount;
        }

    }
}
