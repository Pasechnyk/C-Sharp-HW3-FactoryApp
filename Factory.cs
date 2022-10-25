using System;
using System.Collections.Generic;

namespace FactoryApp
{
    class Factory
    {
        // basic properties
        public string Name { get; set; }
        private List<Employee> employees; // arrays turned into lists
        private List<Product> products;

        // constructors
        public Factory() { }
        public Factory(string n)
        {
            Name = n;
        }

        // Show and ToString methods
        public void Show()
        {
            Console.WriteLine($" - - - - - Factory Information - - - - - ");
            Console.WriteLine($"Name of this factory: {Name}");
            Console.WriteLine($"Workers in this factory: ");
            foreach (var e in employees)
            {
                Console.WriteLine("- - - - - - ");
                e.Show();
            }
            Console.WriteLine($"Products available: ");
            foreach (var p in products)
            {
                Console.WriteLine("- - - - - - ");
                p.Show();
            }
        }
        public override string ToString()
        {
            return "Information about factory:" + Name + "\n Number of employees: "
                + employees.Count + "\n Amount of products available: " + products.Count;
        }

        // additional complex properties
        public int EmployeeCount => employees.Count;
        public decimal TotalSalary
        {
            get
            {
                decimal totalSalary = 0;
                foreach (var e in employees)
                {
                    totalSalary += e.Salary;
                }
                return totalSalary;
            }
        }
        public decimal AvgSalary => TotalSalary / EmployeeCount;
        public decimal GDP
        {
            get
            {
                decimal productWorth = 0;
                foreach (var p in products)
                {
                    productWorth += p.Price;
                }
                return productWorth / EmployeeCount;
            }
        }
    }
}
