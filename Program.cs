using System;

namespace EcommerceBackend
{
    class Program
    {
        static void Main(string[] args)
        {
            // Welcome message
            Console.WriteLine("Welcome to the E-Commerce Backend Demo - Day 1");

            // Product information
            // Product name
            string productName = "Laptop";

            // Product price in decimal
            decimal productPrice = 999.99M;

            // Product quantity
            int productQuantity = 2;

            // Calculate total price
            decimal totalPrice = CalculateTotal(productPrice, productQuantity);

            // Display product details
            Console.WriteLine($"Product: {productName}");
            Console.WriteLine($"Price: {productPrice} USD");
            Console.WriteLine($"Quantity: {productQuantity}");
            Console.WriteLine($"Total Price: {totalPrice} USD");

            // Extra exercise: check if quantity is even or odd
            if (productQuantity % 2 == 0)
            {
                Console.WriteLine("Quantity is even.");
            }
            else
            {
                Console.WriteLine("Quantity is odd.");
            }
        }

        // Method to calculate total price
        static decimal CalculateTotal(decimal price, int quantity)
        {
            return price * quantity;
        }
    }
}
