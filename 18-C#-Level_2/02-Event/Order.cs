using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Event
{
    // create many subscriber 

    public class OrderEventArgs : EventArgs
    {
        public int OrderID { get; }
        public double TotalPrice { get; }
        public string ClientEmail { get; }
        public OrderEventArgs(int OrderID, double TotalPrice, string ClientEmail)
        {
            this.OrderID = OrderID;
            this.TotalPrice = TotalPrice;
            this.ClientEmail = ClientEmail;
        }
    }

    public class Order
    {
        //Event 
        public event EventHandler<OrderEventArgs> OnOrderCompleted;
        // protected method raise data
        protected virtual void RaiseOrder(OrderEventArgs orderEventArgs)
        {
            OnOrderCompleted(this, orderEventArgs);
        }
        // method to use protected method and fill data

        public void NewOrder (int OrderID, double TotalPrice, string ClientEmail)
        {
            RaiseOrder(new OrderEventArgs(OrderID, TotalPrice, ClientEmail));
        }
    }

    public class EmailService
    {
        public void Subscribe(Order order)
        {
            order.OnOrderCompleted += HandleOrderCompleted;
        }
        public void UnSubscribe(Order order)
        {
            order.OnOrderCompleted -= HandleOrderCompleted;
        }

        public void HandleOrderCompleted(object sender, OrderEventArgs e)
        {
            Console.WriteLine("Email Service :. ");
            Console.WriteLine("Content : " + e.OrderID);
            Console.WriteLine("Content : " + e.ClientEmail);
            Console.WriteLine("Price : " + e.TotalPrice);
            Console.WriteLine();
        }
    } 
    public class SMSService
    {
        public void Subscribe(Order order)
        {
            order.OnOrderCompleted += HandleOrderCompleted;
        }
        public void UnSubscribe(Order order)
        {
            order.OnOrderCompleted -= HandleOrderCompleted;
        }

        public void HandleOrderCompleted(object sender, OrderEventArgs e)
        {
            Console.WriteLine("SMS Service :. ");
            Console.WriteLine("Content : " + e.OrderID);
            Console.WriteLine("Content : " + e.ClientEmail);
            Console.WriteLine("Price : " + e.TotalPrice);
            Console.WriteLine();
        }
    } 
    
    public class ShippingService
    {
        public void Subscribe(Order order)
        {
            order.OnOrderCompleted += HandleOrderCompleted;
        }
        public void UnSubscribe(Order order)
        {
            order.OnOrderCompleted -= HandleOrderCompleted;
        }

        public void HandleOrderCompleted(object sender, OrderEventArgs e)
        {
            Console.WriteLine("Shipping Service :. ");
            Console.WriteLine("OrderID : " + e.OrderID);
            Console.WriteLine("Email   : " + e.ClientEmail);
            Console.WriteLine("Price   : " + e.TotalPrice + " $");
            Console.WriteLine();
        }
    }



    internal class program
    {
   
        static void Main(string[] args)
        {
            Order order = new Order();

            EmailService emailService= new EmailService();
            SMSService smsService= new SMSService();
            ShippingService shippingService= new ShippingService();

            emailService.Subscribe(order);
            smsService.Subscribe(order);
            shippingService.Subscribe(order);

            order.NewOrder(1,10,"ahmed@gmail.com");
            order.NewOrder(2,30,"ahmed@gmail.com");

            shippingService.UnSubscribe(order);

            order.NewOrder(3,90,"ahmed@gmail.com");

            Console.ReadKey();

        }
    }
}
