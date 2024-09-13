using System;
using System.Collections.Generic;

namespace ClassesAndObject
{
 
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }

        public Product(string name, double price, string category)
        {
            Name = name;
            Price = price;
            Category = category;
        }
    }

   
    class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public User(string username, string password, string email)
        {
            Username = username;
            Password = password;
            Email = email;
            Console.WriteLine($"User details: \n Username : " + Username + "\n Email: " + Email);
        }
      
    }

   
    class Order
    {
        public List<Product> Products = new List<Product>();
        public double OrderTotal
        {
            get
            {
                double total = 0;
                foreach (var product in Products)
                {
                    total += product.Price;
                }
                return total;
            }
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public void ShowOrderDetails()
        {
            Console.WriteLine("Order Details:");
            foreach (var product in Products)
            {
                Console.WriteLine($"Product: {product.Name}, Category: {product.Category}, Price: ${product.Price}");
            }
            Console.WriteLine($"Order Total: ${OrderTotal}");
        }
    }

    
    class Program
    {
        static void Main(string[] args)
        {
            
            Product product1 = new Product("Shirt", 999.99, "Fashion");
            Product product2 = new Product("Jeans", 700, "Fashion");
            Product product3 = new Product("Earbuds", 1000.01, "Electronics");

            User user = new User("sam", "password@123", "sam@ust.com");

            
            Order order = new Order();

            
            order.AddProduct(product1);
            order.AddProduct(product2);
            order.AddProduct(product3);

            order.ShowOrderDetails();
        }
    }

}