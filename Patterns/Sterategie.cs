using System;

namespace DesignPatternsDemo.Patterns
{
    // Step 1: Define the Strategy interface
    public interface IPaymentStrategy
    {
        void Pay(decimal amount);
    }

    // Step 2: Implement concrete strategies
    public class CreditCardPayment : IPaymentStrategy
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount:C} using Credit Card.");
        }
    }

    public class PaypalPayment : IPaymentStrategy
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount:C} using PayPal.");
        }
    }

    // Step 3: Context class that uses the strategy
    public class PaymentContext
    {
        private IPaymentStrategy _strategy;

        public PaymentContext(IPaymentStrategy strategy)
        {
            _strategy = strategy;
        }

        public void SetStrategy(IPaymentStrategy strategy)
        {
            _strategy = strategy;
        }

        public void Checkout(decimal amount)
        {
            _strategy.Pay(amount);
        }
    }
}
