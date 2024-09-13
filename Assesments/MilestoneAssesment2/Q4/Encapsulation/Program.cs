using System;

namespace Encapsulation
{
    // Product Class with encapsulation
    public class Product
    {
        // Private fields
        private string name;
        private double price;
        private string category;

        // Public property for Name (read-only)
        public string Name
        {
            get { return name; }
        }

        // Public property for Category (read-only)
        public string Category
        {
            get { return category; }
        }

        // Public property for Price (read and write with validation)
        public double Price
        {
            get { return price; }
            private set
            {
                if (value >= 0)
                    price = value; 
                else
                    Console.WriteLine("Error: Price cannot be negative.");
            }
        }

        // Constructor to initialize fields
        public Product(string name, double price, string category)
        {
            this.name = name;
            this.category = category;
            Price = price; 
        }

        // Method to update the product price (encapsulating the logic)
        public void UpdatePrice(double newPrice)
        {
            Price = newPrice; 
            Console.WriteLine($"Product price updated to: ${Price}");
        }
    }

    // User Class with encapsulation
    public class User
    {
        // Private fields
        private string username;
        private string password; 
        private string email;

        // Public property for Username (read-only)
        public string Username
        {
            get { return username; }
        }

        // Public property for Email (read and write with validation)
        public string Email
        {
            get { return email; }
            set
            {
                if (IsValidEmail(value))
                    email = value;
                else
                    Console.WriteLine("Error: Invalid email format.");
            }
        }

        // Constructor to initialize fields
        public User(string username, string password, string email)
        {
            this.username = username;
            this.password = password; 
            Email = email; 
        }

        // Method to update user password (encapsulated)
        public void UpdatePassword(string currentPassword, string newPassword)
        {
            if (password == currentPassword)
            {
                password = newPassword;
                Console.WriteLine("Password updated successfully.");
            }
            else
            {
                Console.WriteLine("Error: Current password is incorrect.");
            }
        }

        // Private method to check if an email format is valid (encapsulation)
        private bool IsValidEmail(string email)
        {
            return email.Contains("@") && email.Contains(".");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creating a Product instance
            Product product1 = new Product("Laptop", 999.99, "Electronics");
            Console.WriteLine($"Product: {product1.Name}, Price: ${product1.Price}, Category: {product1.Category}");

            // Updating product price
            product1.UpdatePrice(1099.99); // Valid price
            product1.UpdatePrice(-200); // Invalid price (negative)

            Console.WriteLine();

            // Creating a User instance
            User user1 = new User("john_doe", "password123", "john@example.com");
            Console.WriteLine($"Username: {user1.Username}, Email: {user1.Email}");

            // Updating email
            user1.Email = "new_email@example.com"; // Valid email
            user1.Email = "invalid-email"; // Invalid email

            // Updating password
            user1.UpdatePassword("password123", "newpassword456"); // Correct current password
            user1.UpdatePassword("wrongpassword", "newpassword789"); // Incorrect current password
        }
    }
}
