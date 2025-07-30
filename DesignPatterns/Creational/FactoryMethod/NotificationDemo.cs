using DesignPatterns.Creational.FactoryMethod.ConcreteCreators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.FactoryMethod
{
    public class NotificationDemo
    {
        public static void Main(string[] args)
        {
            //Incorrect unclean way to send notifications
            NotficationService notficationService = new NotficationService();
            notficationService.SendNotification("email", "Hello, this is a notification!");

            //Using Factory Method to send notifications
            NotificationCreator creator;
            //Send Email
            creator = new EmailNotificationCreator();
            creator.Notify("Hello, this is an email notification!");

            //Send SMS
            creator = new SmsNotificationCreator();
            creator.Notify("Hello, this is an SMS notification!");

            //Send Whatsapp
            creator = new WhatsappNotificationCreator();
            creator.Notify("Hello, this is a WhatsApp notification!");
        }
    }
}
