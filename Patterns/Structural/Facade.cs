using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsDemo.Patterns.Structural
{
    public class OrderServiceFacade
    {
        private readonly AuthenticationService _authService;
        private readonly Inventory _inventory;
        private readonly PaymentService _paymentService;

        public OrderServiceFacade()
        {
            _authService = new AuthenticationService();
            _inventory = new Inventory();
            _paymentService = new PaymentService();
        }

        public bool PlaceOrder(string username, string password, OrderRequest order)
        {
            if (!_authService.Authenticate(username, password))
            {
                Console.WriteLine("Authentication failed.");
                return false;
            }

            if (!_inventory.CheckStock(order.ProductName, order.Quantity))
            {
                Console.WriteLine("Insufficient stock.");
                return false;
            }

            if (!_paymentService.ProcessPayment(order))
            {
                Console.WriteLine("Payment processing failed.");
                return false;
            }

            Console.WriteLine("Order placed successfully.");
            return true;
        }
    }

    public class OrderRequest
    {
        public int OrderId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }

        public OrderRequest(int orderId, string productName, int quantity)
        {
            OrderId = orderId;
            ProductName = productName;
            Quantity = quantity;
        }
    }

    public class AuthenticationService
    {
        public bool Authenticate(string username, string password)
        {
            // Simulate authentication logic
            return username == "admin" && password == "password";
        }
    }


    public class Inventory
    {
        public bool CheckStock(string productName, int quantity)
        {
            // Simulate stock checking logic
            return quantity <= 100; // Assume we have 100 items in stock
        }
        public bool Exists(string productName)
        {
            // Simulate product existence check
            return productName == "Laptop";
        }
    }

    public class PaymentService
    {
        public bool ProcessPayment(OrderRequest order)
        {
            // Simulate payment processing logic
            return order.Quantity <= 1000; // Assume we can only process up to 1000 units at a time
        }
    }
}