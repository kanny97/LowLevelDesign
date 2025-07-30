using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Strategy
{
    public class WeightBasedShipping : IShippingStrategy
    {
        private readonly double ratePerKg;
        public WeightBasedShipping(double ratePerKg)
        {
            this.ratePerKg = ratePerKg;
        }
        public double CalculateShippingCost(Order order)
        {
            // Assuming order amount is in kg for simplicity
            return order.WeightInKg * ratePerKg;
        }
    }
}
