using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Strategy
{
    public interface IShippingStrategy
    {
        public double CalculateShippingCost(Order order);
    }
}
