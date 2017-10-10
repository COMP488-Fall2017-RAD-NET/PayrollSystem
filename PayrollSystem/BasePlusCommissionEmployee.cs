using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystem
{
    class BasePlusCommissionEmployee : CommissionEmployee
    {
        private decimal baseSalary; // base salary per week

        // six-parameter constructor
        public BasePlusCommissionEmployee(string first, string last,
           string ssn, decimal sales, double rate, decimal salary)
           : base(first, last, ssn, sales, rate)
        {
            BaseSalary = salary; // validate base salary via property
        } // end six-parameter BasePlusCommissionEmployee constructor

        // property that gets and sets 
        // base-salaried commission employee's base salary
        public decimal BaseSalary
        {
            get
            {
                return baseSalary;
            } // end get
            set
            {
                baseSalary = (value >= 0) ? value : 0; // validation
            } // end set
        } // end property BaseSalary

        // calculate earnings; override method Earnings in CommissionEmployee
        public override double Earnings()
        {
            return (double) BaseSalary + base.Earnings();
        } // end method Earnings               

        // return string representation of BasePlusCommissionEmployee object
        public override string ToString()
        {
            return string.Format("Base + commission employee:\n{0}Gross sales: {1:C}\nCommission rate: {2:F2}\nBase salary: {3:C}\nEarnings: {4:C}",
               base.Name(), base.GrossSales, base.CommissionRate, BaseSalary, Earnings());
        } // end method ToString                
    }
}
