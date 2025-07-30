using DesignPatterns.Creational.AbstractFactory.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory.Factories
{
    public interface IGUIFactory
    {
        IButton CreateButton();
        ICheckbox CreateCheckbox();
    }
}
