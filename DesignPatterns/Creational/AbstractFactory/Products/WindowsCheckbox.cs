using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory.Products
{
    public class WindowsCheckbox : ICheckbox
    {
        //Implement ICheckbox interface below
        public void Paint()
        {
            Console.WriteLine("Painting a Windows Checkbox");
        }
        public void OnClick()
        {
            Console.WriteLine("Clicking a Windows Checkbox");
        }
    }
}
