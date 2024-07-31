using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Employee : Person
    {
        public Employee(string name, int age, string address, string nationality, double salary, int rank, string job)
             : base(name, age, address, nationality)
        {
            this.salary=salary;
            this.rank=rank;
            this.job=job;
        }

        public double salary { get; set; }
        public int rank { get; set; }
        public string job { get; set; }
    }
}
