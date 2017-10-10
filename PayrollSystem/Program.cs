using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee salariedEmployee = new SalariedEmployee("Alice", "Cooper", "123456789", 1000);
            Employee hourlyEmployee = new HourlyEmployee("Bob", "Dilan", "987654321", 20, 40);
            Employee commissionEmployee = new CommissionEmployee("Patrick", "Frost", "135798462", 500, 0.2);
            Employee basePlusCommissionEmployee = new BasePlusCommissionEmployee("Kristine", "Chen", "095478236", 600, 0.3, 300);

            Console.WriteLine(salariedEmployee.ToString());
            Console.WriteLine(hourlyEmployee.ToString());
            Console.WriteLine(commissionEmployee.ToString());
            Console.WriteLine(basePlusCommissionEmployee.ToString());

            Console.Read();

        }
    }
}
