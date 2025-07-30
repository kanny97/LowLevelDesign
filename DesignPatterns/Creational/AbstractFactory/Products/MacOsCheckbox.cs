using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory.Products
{
    public class MacOsCheckbox : ICheckbox
    {
        public void Paint()
        {
            Console.WriteLine("Painting a MacOS checkbox.");
        }
        public void OnClick()
        {
            Console.WriteLine("MacOS checkbox clicked.");
        }
    }
}
