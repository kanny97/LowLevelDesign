// DesignPatterns\FactoryMethod\SmsNotificationCreator.cs
using DesignPatterns.Creational.FactoryMethod;
using DesignPatterns.Creational.FactoryMethod.ConcreteProducts;
using System;

namespace DesignPatterns.Creational.FactoryMethod.ConcreteCreators
{
    public class SmsNotificationCreator : NotificationCreator
    {
        public override INotification CreateNotification()
        {
            return new SMSNotification();
        }
    }
}