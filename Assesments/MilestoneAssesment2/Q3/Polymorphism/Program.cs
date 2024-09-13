using System;
using System.Collections.Generic;

namespace PolymorphismDemo
{
    
    public class Order
    {
        public List<string> Products { get; set; }
        public double TotalAmount { get; set; }

        public Order()
        {
            Products = new List<string>();
            TotalAmount = 0;
        }

        
        public virtual double CalculateTotalAmount()
        {
            Console.WriteLine("Calculating total without discount.");
            return TotalAmount;
        }

        
        public void AddProduct(string product, double price)
        {
            Products.Add(product);
            TotalAmount += price;
            Console.WriteLine($"Added product: {product}, Price: ${price}");
        }

        public void AddProduct(string product, int quantity, double unitPrice)
        {
            Products.Add(product);
            double totalProductPrice = quantity * unitPrice;
            TotalAmount += totalProductPrice;
            Console.WriteLine($"Added product: {product}, Quantity: {quantity}, Total Price: ${totalProductPrice}");
        }
    }

    
    public class DiscountOrder : Order
    {
        public double Discount { get; set; }

        public DiscountOrder(double discount)
        {
            Discount = discount;
        }

       
        public override double CalculateTotalAmount()
        {
            Console.WriteLine("Calculating total with discount.");
            double discountAmount = TotalAmount * (Discount / 100);
            return TotalAmount - discountAmount;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            Order regularOrder = new Order();
            regularOrder.AddProduct("Laptop", 999.99);
            regularOrder.AddProduct("Mouse", 2, 25.50);
            Console.WriteLine($"Total without discount: ${regularOrder.CalculateTotalAmount()}");

            Console.WriteLine();

            
            DiscountOrder discountOrder = new DiscountOrder(10); 
            discountOrder.AddProduct("Smartphone", 999.99);
            discountOrder.AddProduct("Headphones", 2, 25.50);
            Console.WriteLine($"Total with discount: ${discountOrder.CalculateTotalAmount()}");
        }
    }
}
