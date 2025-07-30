using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adapter
{
    public interface IPaymentProcessor
    {
        void ProcessPayment(double amount, string currency);
        string GetTransactionId();
        bool IsPaymentSuccessful();
    }
}
