using System;
using System.Collections.Generic;

namespace FactoryApp
{
    public enum CategoryType { Puzzles, Toys, Educational }
    struct Product
    {
        // basic properties
        public string Name { get; set; }
        public readonly DateTime ManufactureDate;
        public CategoryType Category { get; set; }
        public decimal Price { get; set; }

        // constructor
        public Product(string n, decimal p, CategoryType type)
        {
            Name = n;
            ManufactureDate = DateTime.Now;
            Category = type;
            Price = p;
        }

        // Show and ToString methods
        public void Show()
        {
            Console.WriteLine($" - - - - - Product Information - - - - - ");
            Console.WriteLine($"Name of the product: {Name}");
            Console.WriteLine($"Date of establishment: {ManufactureDate}");
            Console.WriteLine($"Category type: {Category}");
            Console.WriteLine($"Product price: {Price}");
        }
        public override string ToString()
        {
            return "Product information:" + Name + "\n" + "Manufacture date: " +
                ManufactureDate + "\n" + "Category: " + Category + "\n" 
                + "Product price: " + Price;
        }
    }
}
