using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class SalariedEmployee : Employee
    {
        public SalariedEmployee(string name, int age, string address, string nationality, double salary, int rank, string job ,double bonus, double deductions)
            : base(name , age , address , nationality , salary , rank , job)
        {
            this.bonus=bonus;
            this.deductions=deductions;
        }

        public double bonus { get; set; }
        public double deductions { get; set; }

    }
}
