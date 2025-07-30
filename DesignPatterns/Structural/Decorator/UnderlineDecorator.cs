using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator
{
    public class UnderlineDecorator : TextDecorator
    {
        public UnderlineDecorator(ITextView inner) : base(inner)
        {
        }
        public override void Render()
        {
            Console.WriteLine("<u>");
            inner.Render();
            Console.WriteLine("</u>");
        }
    }
}
