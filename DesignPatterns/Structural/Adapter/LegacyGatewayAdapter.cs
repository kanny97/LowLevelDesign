using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adapter
{
    public class LegacyGatewayAdapter : IPaymentProcessor
    {
        private readonly LegacyGateway legacyGateway;
        private long currentTransactionId;
        public LegacyGatewayAdapter(LegacyGateway legacyGateway)
        {
            this.legacyGateway = legacyGateway;
        }
        public void ProcessPayment(double amount, string currency)
        {
            legacyGateway.ExecuteTransaction(amount, currency);
            currentTransactionId = legacyGateway.GetReferenceNumber();
        }
        public bool IsPaymentSuccessful()
        {
            return legacyGateway.CheckStatus(currentTransactionId);
        }
        public string GetTransactionId()
        {
            return "LEGACY_TXN_" + currentTransactionId;
        }
    }
}
