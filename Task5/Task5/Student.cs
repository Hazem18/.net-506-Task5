using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Student : Person
    {
        public Student(string name, int age, string address, string nationality,int studyLevel, string specializtion, double gPA)
           : base (name , age , address , nationality)
        {
            this.studyLevel=studyLevel;
            this.specializtion=specializtion;
            GPA=gPA;
        }

        public int studyLevel { get; set; }
        public string specializtion { get; set; }

        public double GPA { get; set; }



    }
}
