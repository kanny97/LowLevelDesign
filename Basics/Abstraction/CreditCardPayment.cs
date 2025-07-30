using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics.Abstraction
{
    public class CreditCardPayment : Payment
    {
        public CreditCardPayment(double amount) : base(amount) { }

        public override void Pay()
        {
            Console.WriteLine($"{Amount} paid using credit card");
        }
    }
}
