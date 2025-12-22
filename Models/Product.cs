using System;

namespace EcommerceBackend.Models
{
    // Represents a product in the e-commerce system
    public class Product
    {
        // Unique identifier for the product
        public int Id { get; set; }

        // Name of the product
        public string Name { get; set; }

        // Price of the product
        public decimal Price { get; set; }

        // Quantity available in stock
        public int Stock { get; set; }

        // Category the product belongs to
        public string Category { get; set; }

        // Optional: constructor for quick initialization
        public Product(int id, string name, decimal price, int stock, string category)
        {
            Id = id;
            Name = name;
            Price = price;
            Stock = stock;
            Category = category;
        }
    }
}
