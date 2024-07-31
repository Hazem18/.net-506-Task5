using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class HourlyEmployee : Employee
    {
        public HourlyEmployee(string name, int age, string address, string nationality, double salary, int rank, string job, int workingHours, double hourlyRate)
            : base(name, age, address, nationality, salary, rank, job)
        {
            this.workingHours=workingHours;
            this.hourlyRate=hourlyRate;
        }

        public int workingHours { get; set; }
        public double hourlyRate { get; set; }
    }
}
