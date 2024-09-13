using System;

namespace InheritanceDemo
{
    
    public class Person
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public Person(string name, string email)
        {
            Name = name;
            Email = email;
        }

       
        public void DisplayPersonInfo()
        {
            Console.WriteLine($"Name: {Name}, Email: {Email}");
        }
    }

    
    public class Customer : Person
    {
        public int CustomerID { get; set; }

        public Customer(string name, string email, int customerID)
            : base(name, email) 
        {
            CustomerID = customerID;
        }

       
        public void PlaceOrder()
        {
            Console.WriteLine($"{Name} (Customer ID: {CustomerID}) has placed an order.");
        }
    }

    
    public class Admin : Person
    {
        public int EmployeeID { get; set; }

        public Admin(string name, string email, int employeeID) : base(name, email)
        {
            EmployeeID = employeeID;
        }

        
        public void ManageUser(Customer customer)
        {
            Console.WriteLine($"{Name} (EmployeeID: {EmployeeID}) is managing customer: {customer.Name}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            Customer customer1 = new Customer("Libin Abraham", "libin@gmail.com", 1005);
            customer1.DisplayPersonInfo(); 
            customer1.PlaceOrder(); 

            Console.WriteLine();

            
            Admin admin1 = new Admin("Sam Thomas Abraham", "sam@ust.com", 5);
            admin1.DisplayPersonInfo(); 
            admin1.ManageUser(customer1); 
        }
    }
}
