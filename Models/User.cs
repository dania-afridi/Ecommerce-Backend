using System;

namespace EcommerceBackend.Models
{
    // Represents a user in the e-commerce system
    public class User
    {
        // Unique identifier for the user
        public int Id { get; set; }

        // User's full name
        public string Name { get; set; }

        // User's email (used for login)
        public string Email { get; set; }

        // Hashed password (never store plain text!)
        public string PasswordHash { get; set; }

        // Optional: constructor for quick initialization
        public User(int id, string name, string email, string passwordHash)
        {
            Id = id;
            Name = name;
            Email = email;
            PasswordHash = passwordHash;
        }
    }
}
