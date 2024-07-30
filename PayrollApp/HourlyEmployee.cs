using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollApp
{
    internal class HourlyEmployee : Employee
    {
        private short hour;

        public decimal HourlyPayment{ get; set; }
        public override decimal PaymentAmount {  get; protected set; }
        public short NumOfHoursWorked 
        {
            get 
            {
                return hour;
            }
            set
            {
                hour = value;
            }
        }

        public HourlyEmployee(decimal hourlyPayment, short numOfHoursWorked)
        {
            HourlyPayment = hourlyPayment;
            NumOfHoursWorked = numOfHoursWorked;
            Count++;
        }

        public override decimal Payment()
        {
            PaymentAmount = (decimal)NumOfHoursWorked * HourlyPayment;
            if (NumOfHoursWorked > 40)
            {
                PaymentAmount += (NumOfHoursWorked - 40) * HourlyPayment * 1.5M;
            }
            return PaymentAmount;
        }
    }
}
