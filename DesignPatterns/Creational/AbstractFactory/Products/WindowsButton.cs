using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory.Products
{
    public class WindowsButton : IButton
    {
        public void Paint()
        {
            Console.WriteLine("Painting Windows Button");
        }
        public void OnClick()
        {
            Console.WriteLine("Windows Button Clicked");
        }
    }
}
