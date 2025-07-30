using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adapter
{
    public class PaymentApplication
    {
        public static void Main(string[] args)
        {
            IPaymentProcessor processor = new InhousePaymentProcessor();
            CheckoutService checkoutService = new CheckoutService(processor);
            checkoutService.Checkout(199.99, "USD");
            
            LegacyGateway legacyGateway = new LegacyGateway();
            IPaymentProcessor legacyProcessor = new LegacyGatewayAdapter(legacyGateway);
            CheckoutService legacyCheckoutService = new CheckoutService(legacyProcessor);
            legacyCheckoutService.Checkout(299.99, "EUR");
        }
    }
}
