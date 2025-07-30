using DesignPatterns.Creational.FactoryMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.FactoryMethod.ConcreteProducts
{
    public class SMSNotification : INotification
    {
        public void Notify(string message)
        {
            Console.WriteLine("Sending SMS notification: " + message);
        }
    }
}
