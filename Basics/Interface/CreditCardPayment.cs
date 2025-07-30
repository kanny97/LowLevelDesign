using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics.Interface
{
    public class CreditCardPayment : IPayment
    {
        public void Pay(double amount)
        {
            Console.WriteLine($"{amount} paid using credit card");
        }
    }
}
