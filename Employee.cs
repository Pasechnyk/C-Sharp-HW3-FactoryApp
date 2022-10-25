using System;
using System.Collections.Generic;

namespace FactoryApp
{
    class Employee
    {
        // basic properties
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public decimal Salary { get; set; }

        // constructors
        public Employee() { }
        public Employee(string n, string s, DateTime b, decimal sal)
        {
            Name = n;
            Surname = s;
            BirthDate = b;
            Salary = sal;
        }

        // Show and ToString methods
        public void Show()
        {
            Console.WriteLine($" - - - - - Employees Information - - - - - ");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Surname: {Surname}");
            Console.WriteLine($"Date of Birth: {BirthDate}");
            Console.WriteLine($"Employee's salary: {Salary}");
        }
        public override string ToString()
        {
            return "Employee information:" + Name + " " + Surname + "\n"
                + "Birth date: " + BirthDate + "\n" + "Salary: " + Salary;
        }
    }
}
