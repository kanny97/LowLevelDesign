﻿using System;

namespace DesignPatterns.Structural.Adapter
{
    public class LegacyGateway
    {
        private long transactionReference;
        private bool isPaymentSuccessful;

        public void ExecuteTransaction(double totalAmount, string currency)
        {
            Console.WriteLine($"LegacyGateway: Executing transaction for {currency} {totalAmount}");
            transactionReference = DateTime.UtcNow.Ticks;
            isPaymentSuccessful = true;
            Console.WriteLine($"LegacyGateway: Transaction executed successfully. Txn ID: {transactionReference}");
        }

        public bool CheckStatus(long transactionReference)
        {
            Console.WriteLine($"LegacyGateway: Checking status for ref: {transactionReference}");
            return isPaymentSuccessful;
        }

        public long GetReferenceNumber()
        {
            return transactionReference;
        }
    }
}
