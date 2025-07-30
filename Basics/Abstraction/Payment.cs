using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics.Abstraction
{
    public abstract class Payment
    {
        protected Payment(double amount) { Amount = amount; }
        protected double Amount { get; set; }
        public abstract void Pay();        
    }
}
