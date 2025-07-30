using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Strategy
{
    public class Order
    {
        public Order(string orderId, double orderAmount, string shippingAddress, double weightInKg)
        {
            OrderId = orderId;
            OrderAmount = orderAmount;
            ShippingAddress = shippingAddress;
            WeightInKg = weightInKg;
        }
        public string OrderId { get; set; }
        public double OrderAmount { get; set; }
        public string ShippingAddress { get; set; }
        public double WeightInKg { get; set; }
        public override string ToString()
        {
            return $"Order ID: {OrderId}, Amount: {OrderAmount:C}, Shipping Address: {ShippingAddress}";
        }

    }
}
