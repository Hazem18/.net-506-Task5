namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new("Hazem" , 20 , "18-Rady st" , "Egyptian");
            Console.WriteLine(person.name);
            Console.WriteLine(person.age);
            Console.WriteLine(person.address);
            Console.WriteLine(person.nationality);
            Console.WriteLine("--------------------------------");
            Student student = new("Mohammed", 19, "1-Giza st", "UK" , 3 , "CS" , 3.6);
            Console.WriteLine(student.name);
            Console.WriteLine(student.age);
            Console.WriteLine(student.address);
            Console.WriteLine(student.nationality);
            Console.WriteLine(student.studyLevel);
            Console.WriteLine(student.specializtion);
            Console.WriteLine(student.GPA);
            Console.WriteLine("--------------------------------");
            Employee employee = new("Omar", 28, "1-OTT st", "Egyptian", 3000 , 5 ,"Accountant");
            Console.WriteLine(employee.name);
            Console.WriteLine(employee.age);
            Console.WriteLine(employee.address);
            Console.WriteLine(employee.nationality);
            Console.WriteLine(employee.salary);
            Console.WriteLine(employee.rank);
            Console.WriteLine(employee.job);
            Console.WriteLine("--------------------------------");
            SalariedEmployee se = new("Ali", 33, "20-Dokki st", "USA", 4000, 5, "SE",200 ,50);
            Console.WriteLine(se.name);
            Console.WriteLine(se.age);
            Console.WriteLine(se.address);
            Console.WriteLine(se.nationality);
            Console.WriteLine(se.salary);
            Console.WriteLine(se.rank);
            Console.WriteLine(se.job);
            Console.WriteLine(se.bonus);
            Console.WriteLine(se.deductions);
            Console.WriteLine("--------------------------------");
            HourlyEmployee he = new("Samir", 41, "20-Zamalek st", "Sudan", 2000, 3, "SE", 10, 50);
            Console.WriteLine(he.name);
            Console.WriteLine(he.age);
            Console.WriteLine(he.address);
            Console.WriteLine(he.nationality);
            Console.WriteLine(he.salary);
            Console.WriteLine(he.rank);
            Console.WriteLine(he.job);
            Console.WriteLine(he.workingHours);
            Console.WriteLine(he.hourlyRate);




        }
    }
}
