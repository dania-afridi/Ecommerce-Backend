using System;
using System.Collections.Generic;
using EcommerceBackend.Models;

namespace EcommerceBackend
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of products
            List<Product> products = new List<Product>
            {
                new Product(1, "Laptop", 1200, 5, "Electronics"),
                new Product(2, "Mouse", 25, 0, "Accessories"),
                new Product(3, "Keyboard", 70, 10, "Accessories")
            };

            // Loop through products 
            foreach (var product in products)
            {
                // Check stock status
                if (product.Stock > 0)
                {
                    Console.WriteLine($"{product.Name} is in stock.");
                }
                else
                {
                    Console.WriteLine($"{product.Name} is out of stock.");
                }
            }
        }

        // Method to calculate total price
        static decimal CalculateTotal(decimal price, int quantity)
        {
            return price * quantity;
        }
    }
}
