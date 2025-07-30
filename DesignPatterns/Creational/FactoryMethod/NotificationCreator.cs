using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.FactoryMethod
{
    public abstract class NotificationCreator
    {
        public abstract INotification CreateNotification();
        public void Notify(string message)
        {
            //Create appropriate notification
            INotification notification = CreateNotification();
            notification.Notify(message);
        }
    }
}
