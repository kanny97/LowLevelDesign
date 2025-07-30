using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory.Products
{
    public class MacOsButton : IButton
    {
        public void Paint()
        {
            Console.WriteLine("Painting MacOS button.");
        }
        public void OnClick()
        {
            Console.WriteLine("Clicking MacOS button.");
        }
    }
}
