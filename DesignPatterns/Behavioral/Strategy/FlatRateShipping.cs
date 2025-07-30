using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Strategy
{
    public class FlatRateShipping : IShippingStrategy
    {
        private readonly double flatRate;
        public FlatRateShipping(double flatRate)
        {
            this.flatRate = flatRate;
        }
        public double CalculateShippingCost(Order order)
        {
            return flatRate;
        }
    }
}
