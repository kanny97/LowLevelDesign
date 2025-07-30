using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Strategy
{
    public class ShippingCostCalculator
    {
        private IShippingStrategy shippingStrategy;
        public ShippingCostCalculator(IShippingStrategy shippingStrategy)
        {
            this.shippingStrategy = shippingStrategy;
        }
        public double CalculateShippingCost(Order order)
        {
            if (order == null)
            {
                throw new ArgumentNullException(nameof(order), "Order cannot be null");
            }
            Console.WriteLine($"Calculating shipping cost for order: {order}");
            Console.WriteLine($"Using shipping strategy: {shippingStrategy.GetType().Name}");
            return shippingStrategy.CalculateShippingCost(order);
        }
        
        public void SetShippingStrategy(IShippingStrategy newStrategy)
        {
            if (newStrategy == null)
            {
                throw new ArgumentNullException(nameof(newStrategy), "New shipping strategy cannot be null");
            }
            shippingStrategy = newStrategy;
            Console.WriteLine($"Shipping strategy updated to: {shippingStrategy.GetType().Name}");
        }
    }
}
