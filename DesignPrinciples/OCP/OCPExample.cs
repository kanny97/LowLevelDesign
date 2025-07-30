using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciples.OCP
{
    // Open/Closed Principle (OCP) Example
    // The OCP states that software entities (classes, modules, functions, etc.) should be open for extension but closed for modification.
    public interface IPaymentMethod
    {
        public void Pay(double amount);
    }
    public class CreditCardPayment : IPaymentMethod
    {
        public void Pay(double amount)
        {
            Console.WriteLine($"{amount} paid using credit card");
        }
    }
    public class PaypalPayment : IPaymentMethod
    {
        public void Pay(double amount)
        {
            Console.WriteLine($"{amount} paid using PayPal");
        }
    }
    public class  PaymentProcessor
    {
        public void ProcessPayment(IPaymentMethod paymentMethod, double amount)
        {
            paymentMethod.Pay(amount);
        }
    }
    public class CheckoutService
    {
        public void Checkout(IPaymentMethod paymentMethod, double amount)
        {
            // Additional checkout logic can be added here
            paymentMethod.Pay(amount);
        }
    }
    public class OCPExample
    {
        public static void Main(string[] args)
        {
            IPaymentMethod creditCard = new CreditCardPayment();
            IPaymentMethod paypal = new PaypalPayment();
            CheckoutService checkoutService = new CheckoutService();
            checkoutService.Checkout(creditCard, 100.0);
            checkoutService.Checkout(paypal, 200.0);
        }
    }
}
