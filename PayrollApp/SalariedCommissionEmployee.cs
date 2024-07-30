using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollApp 
{
    internal class SalariedCommissionEmployee : CommissionEmployee
    {

        private decimal salary;

        public decimal Salary { get; protected set; }

        public SalariedCommissionEmployee(decimal salary, float commission, decimal sales) : base(commission, sales)
        {
            Salary = salary;
        }

        public override decimal Payment()
        {
            PaymentAmount = Salary + base.Payment();
            return PaymentAmount;
        }



    }
}
