using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Person
    {
        public Person(string name, int age, string address, string nationality)
        {
            this.name=name;
            this.age=age;
            this.address=address;
            this.nationality=nationality;
        }

        public string name { get; set; }
        public int age { get; set; }
        public string address { get; set; }
        public string nationality { get; set; }

    }
}
