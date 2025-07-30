using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adapter
{
    public class CheckoutService
    {
        IPaymentProcessor paymentProcessor;
        public CheckoutService(IPaymentProcessor paymentProcessor)
        {
            this.paymentProcessor = paymentProcessor;
        }
        public void Checkout(double amount, string currency)
        {
            paymentProcessor.ProcessPayment(amount, currency);
            if (paymentProcessor.IsPaymentSuccessful())
            {
                Console.WriteLine($"Checkout successful. Transaction ID: {paymentProcessor.GetTransactionId()}");
            }
            else
            {
                Console.WriteLine("Checkout failed. Please try again.");
            }
        }
    }
}
