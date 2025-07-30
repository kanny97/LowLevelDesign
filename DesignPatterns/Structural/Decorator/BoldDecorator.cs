using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator
{
    public class BoldDecorator : TextDecorator
    {
        public BoldDecorator(ITextView inner) : base(inner)
        {
        }

        public override void Render()
        {
            Console.WriteLine("<b>");
            inner.Render();
            Console.WriteLine("</b>");
        }
    }
}
