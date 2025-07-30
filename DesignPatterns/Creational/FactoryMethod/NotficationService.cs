using DesignPatterns.Creational.FactoryMethod.ConcreteProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.FactoryMethod
{
    public class NotficationService
    {
        public void SendNotification(string type, string message)
        {
            //Not a clean way to send different types of notifications
            //This violates the Open/Closed Principle as we need to modify this method to add new notification types
            //A better way would be to use a Factory Method or Dependency Injection to create the appropriate notification object
            INotification notification;
            switch (type.ToLower())
            {
                case "email":
                    notification = new EmailNotification();
                    break;
                case "sms":
                    notification = new SMSNotification();
                    break;
                case "whatsapp":
                    notification = new WhatsappNotification();
                    break;
                default:
                    throw new ArgumentException("Invalid notification type");
            }
            notification.Notify(message);
        }
    }
}
