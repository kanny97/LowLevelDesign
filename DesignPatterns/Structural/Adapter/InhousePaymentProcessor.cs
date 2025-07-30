using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adapter
{
    public class InhousePaymentProcessor : IPaymentProcessor
    {
        private bool IsPaymentSuccessfulFlag;
        private string TransactionId;
        public void ProcessPayment(double amount, string currency)
        {
            Console.WriteLine($"Processing payment of {amount} {currency} using Inhouse Payment Processor.");
            // Simulate payment processing logic
            IsPaymentSuccessfulFlag = true; // Simulate successful payment
            TransactionId = Guid.NewGuid().ToString(); // Generate a unique transaction ID
            Console.WriteLine($"Processing complete. Transaction ID: {TransactionId}");
        }
        public bool IsPaymentSuccessful()
        {
            return IsPaymentSuccessfulFlag;
        }
        public string GetTransactionId()
        {
            return TransactionId;
        }
    }
}
