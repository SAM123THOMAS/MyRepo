using System;

namespace Interface
{
   
    public interface IOrderProcessor
    {
        void ProcessOrder();    
        void CancelOrder();     
    }

   
    public class PaymentProcessor : IOrderProcessor
    {
        private string paymentStatus;

        
        public void ProcessOrder()
        {
            paymentStatus = "Payment Processed";
            Console.WriteLine(paymentStatus);
        }

       
        public void CancelOrder()
        {
            paymentStatus = "Payment Cancelled";
            Console.WriteLine(paymentStatus);
        }
    }

    
    public class ShippingProcessor : IOrderProcessor
    {
        private string shippingStatus;

        
        public void ProcessOrder()
        {
            shippingStatus = "Order Shipped";
            Console.WriteLine(shippingStatus);
        }

        
        public void CancelOrder()
        {
            shippingStatus = "Shipping Cancelled";
            Console.WriteLine(shippingStatus);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            IOrderProcessor paymentProcessor = new PaymentProcessor();
            paymentProcessor.ProcessOrder(); 
            paymentProcessor.CancelOrder();  

            Console.WriteLine();

            
            IOrderProcessor shippingProcessor = new ShippingProcessor();
            shippingProcessor.ProcessOrder(); 
            shippingProcessor.CancelOrder();  
        }
    }
}
