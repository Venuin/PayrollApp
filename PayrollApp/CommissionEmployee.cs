using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollApp
{
    internal class CommissionEmployee : Employee
    {
        private float commission;

        private decimal sales;

        public float Commission
        {
            get
            {
                return commission;
            }
            set
            {
                if (value < 0 || value > 1)
                {
                    throw new ArgumentOutOfRangeException("Commision can not be lower than zero or higher than one.");
                }
                commission = value;
            }
        }

        public decimal Sales 
        {
            get
            {
                return sales;
            }
            set
            {   if (value < 0) { throw new ArgumentOutOfRangeException(""); }
                sales = value;
            }
        }

        public override decimal PaymentAmount { get; protected set ; }

        public CommissionEmployee(float commission, decimal sales)
        {
            Commission = commission;
            Sales = sales;
            Count++;
        }

        public override decimal Payment()
        {
            PaymentAmount = Sales * (decimal)Commission;
            return PaymentAmount;
        }

    }
}
