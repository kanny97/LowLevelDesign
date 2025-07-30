using DesignPatterns.Creational.AbstractFactory.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class ApplicationDemo
    {
        public static void Main(string[] args)
        {
            IGUIFactory guiFactory;
            guiFactory = new WindowsFactory();
            Application application = new Application(guiFactory);
            application.RenderUI();
            guiFactory = new MacOsFactory();
            Application application2 = new Application(guiFactory);
            application2.RenderUI();
        }
    }
}
