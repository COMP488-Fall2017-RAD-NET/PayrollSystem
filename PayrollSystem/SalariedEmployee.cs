using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystem
{
    class SalariedEmployee : Employee
    {
        private decimal baseSalary;

        public SalariedEmployee(string first, string last, string ssn, decimal salary)
           : base(first, last, ssn)
        {
            BaseSalary = salary;
        }

        public decimal BaseSalary {
            get
            {
                return baseSalary;
            }
            private set
            {
                this.baseSalary = (value > 0) ? value : 0;
            }
        }

        public override double Earnings()
        {
            return (double) BaseSalary;
        }             

        public override string ToString()
        {
            return string.Format("Salaried employee: \n{0}Base salary: {1:C}\nEarnings: {2:C}\n",
                base.ToString(), BaseSalary, Earnings());
        }
    }
}
