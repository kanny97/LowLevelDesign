using DesignPatterns.Creational.AbstractFactory.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory.Factories
{
    public class WindowsFactory : IGUIFactory
    {
        public WindowsFactory() { }
        public IButton CreateButton()
        {
            return new WindowsButton();
        }
        public ICheckbox CreateCheckbox()
        {
            return new WindowsCheckbox();
        }
    }
}
