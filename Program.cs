// See https://aka.ms/new-console-template for more information

using DesignPatternsDemo.Patterns;

var payment = new PaymentContext(new CreditCardPayment());
            payment.Checkout(100);

            // Switch to PayPal
            payment.SetStrategy(new PaypalPayment());
            payment.Checkout(50);