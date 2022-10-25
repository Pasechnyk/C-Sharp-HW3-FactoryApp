using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Task 1, 2, 3 - create Factory hierarchy using different types of properties and methods

namespace FactoryApp
{
    internal class Program
    {
        // initialize new factory with given options
        public void NewBasicFactory()
        {
            Console.WriteLine("Proceed further to create your own factory!");

            Console.WriteLine("The name: ");
            string str0 = Console.ReadLine();
            Console.WriteLine("Type of profucts you wish to sell: ");
            string str1 = Console.ReadLine();
            Console.WriteLine("Amount of workers: ");
            string str2 = Console.ReadLine();

            Console.WriteLine("Information about your new factory:");
            Console.WriteLine($"The name - {str0}");
            Console.WriteLine($"Products for sale - {str1}");
            Console.WriteLine($"Workers at your factory - {str2}");
        }
        static void Main(string[] args)
        {
            // initializing
            Factory factory = new Factory("Toy Land");
            Employee employee1 = new Employee("Anastasia", "Melnyk", new DateTime(04, 08, 2000), 8000);
            Employee employee2 = new Employee("Tymofii", "Ostapov", new DateTime(12, 06, 1988), 14000);
            Product bunny = new Product("Fluffy Bunny", 12, CategoryType.Toys);
            factory.Show();
        }
    }
}
