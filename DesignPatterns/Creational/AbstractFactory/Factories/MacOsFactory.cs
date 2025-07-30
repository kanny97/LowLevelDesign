using DesignPatterns.Creational.AbstractFactory.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory.Factories
{
    public class MacOsFactory : IGUIFactory
    {
        public MacOsFactory() { }
        public IButton CreateButton()
        {
            return new MacOsButton();
        }
        public ICheckbox CreateCheckbox()
        {
            return new MacOsCheckbox();
        }
    }
}
