using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory.Products
{
    public interface IButton
    {
        void Paint();
        void OnClick();
    }
}
