using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystem
{
    abstract class Employee
    {

        private string first;
        private string last;
        private string ssn;

        public Employee (string first, string last, string ssn)
        {
            First = first;
            Last = last;
            Ssn = ssn;
        }

        public string First { get; private set; }
        public string Last { get; private set; }
        public string Ssn { get; private set; }

        public abstract double Earnings();

        public override string ToString()
        {
            return string.Format("{0}: {1}\n{2}: {3}\n{4}: {5}\n",
               "First name", First,
               "Last name", Last, 
               "SSN", Ssn);
        }
    }
}
