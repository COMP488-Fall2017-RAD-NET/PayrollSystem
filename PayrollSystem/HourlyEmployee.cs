using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystem
{
    class HourlyEmployee : Employee
    {
        private decimal hourlyRate;
        private decimal hoursPerWeek;

        public HourlyEmployee(string first, string last, string ssn, decimal hourlyRate, decimal hoursPerWeek)
           : base(first, last, ssn)
        {
            HourlyRate = hourlyRate;
            HoursPerWeek = hoursPerWeek;
        }

        public decimal HourlyRate
        {
            get
            {
                return hourlyRate;
            }
            private set
            {
                this.hourlyRate = (value >= 0) ? value : 0;
            }
        }

        public decimal HoursPerWeek
        {
            get
            {
                return hoursPerWeek;
            }
            private set
            {
                this.hoursPerWeek = (value >= 0) ? value : 0;
            }
        }

        public override double Earnings()
        {
            return (double) (HoursPerWeek * HourlyRate);
        }

        public override string ToString()
        {
            return string.Format("Hourly employee: \n{0}Hourly rate: {1:C}\nWorked {2} hours per week\nEarnings: {3:C}\n",
                base.ToString(), HourlyRate, HoursPerWeek, Earnings());
        }
    }
}
