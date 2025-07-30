using DesignPatterns.Creational.FactoryMethod;
using DesignPatterns.Creational.FactoryMethod.ConcreteProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.FactoryMethod.ConcreteCreators
{
    public class EmailNotificationCreator : NotificationCreator
    {
        public override INotification CreateNotification()
        {
            return new EmailNotification();
        }
    }
}
