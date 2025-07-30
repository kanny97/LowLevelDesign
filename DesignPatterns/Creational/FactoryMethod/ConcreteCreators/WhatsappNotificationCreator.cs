// DesignPatterns\FactoryMethod\WhatsappNotificationCreator.cs
using System;
using DesignPatterns.Creational.FactoryMethod;
using DesignPatterns.Creational.FactoryMethod.ConcreteProducts;

namespace DesignPatterns.Creational.FactoryMethod.ConcreteCreators
{
    public class WhatsappNotificationCreator : NotificationCreator
    {
        public override INotification CreateNotification()
        {
            return new WhatsappNotification();
        }
    }
}