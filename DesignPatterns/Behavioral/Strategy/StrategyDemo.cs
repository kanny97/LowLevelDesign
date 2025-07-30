using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Strategy
{
    public class StrategyDemo
    {
        public static void Main(string[] args)
        {
            // Create an order
            Order order = new Order("1", 100, "123 Main St", 10);
            Console.WriteLine($"Order created: {order}");
            // Create different shipping strategies
            IShippingStrategy flatRateShipping = new FlatRateShipping(5);
            IShippingStrategy weightBasedShipping = new WeightBasedShipping(2);                
            // Create a shipping cost calculator with a specific strategy
            ShippingCostCalculator calculator = new ShippingCostCalculator(flatRateShipping);
            double cost = calculator.CalculateShippingCost(order);
            Console.WriteLine($"Shipping cost: {cost}");

            //Change the shipping strategy
            calculator.SetShippingStrategy(weightBasedShipping);
            cost = calculator.CalculateShippingCost(order);
            Console.WriteLine($"Shipping cost after changing strategy: {cost}");
        }
    }
}
