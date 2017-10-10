using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystem
{
    class CommissionEmployee : Employee
    {
        private decimal grossSales; // gross weekly sales
        private double commissionRate; // commission percentage

        // five-parameter constructor
        public CommissionEmployee(string first, string last, string ssn,
           decimal sales, double rate)
           : base(first, last, ssn)
        {
            GrossSales = sales; // validate gross sales via property
            CommissionRate = rate; // validate commission rate via property
        } // end five-parameter CommissionEmployee constructor

        // property that gets and sets commission employee's commission rate
        public double CommissionRate
        {
            get
            {
                return commissionRate;
            } // end get
            set
            {
                commissionRate = (value > 0 && value < 1) ? value : 0; // validation
            } // end set
        } // end property CommissionRate

        // property that gets and sets commission employee's gross sales
        public decimal GrossSales
        {
            get
            {
                return grossSales;
            } // end get
            set
            {
                grossSales = (value >= 0) ? value : 0; // validation
            } // end set
        } // end property GrossSales

        // calculate earnings; override abstract method Earnings in Employee
        public override double Earnings()
        {
            return CommissionRate * (double) GrossSales;
        } // end method Earnings              

        // return string representation of CommissionEmployee object
        public override string ToString()
        {
            return string.Format("Commission employee:\n{0}Gross sales: {1:C}\nCommission rate: {2:F2}\nEarnings: {3:C}\n",
               base.ToString(), GrossSales, CommissionRate, Earnings());
        } // end method ToString   

        public string Name()
        {
            return string.Format("{0}", base.ToString());
        }
    }
}
