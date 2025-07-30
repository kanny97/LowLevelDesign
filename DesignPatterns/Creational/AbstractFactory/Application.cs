using DesignPatterns.Creational.AbstractFactory.Factories;
using DesignPatterns.Creational.AbstractFactory.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class Application
    {
        private readonly IButton button;
        private readonly ICheckbox checkbox;
        public Application(IGUIFactory factory)
        {
            button = factory.CreateButton();
            checkbox = factory.CreateCheckbox();
        }
        public void RenderUI()
        {
            button.Paint();
            checkbox.Paint();
        }
    }
}