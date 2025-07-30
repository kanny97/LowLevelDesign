using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory.Products
{
    public interface ICheckbox
    {
        void Paint();
        void OnClick();
    }
}
