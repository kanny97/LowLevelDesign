using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator
{
    public class ItalicDecorator : TextDecorator
    {
        public ItalicDecorator(ITextView inner) : base(inner) 
        { 
        }

        public override void Render()
        {
            Console.WriteLine("<i>");
            inner.Render();
            Console.WriteLine("</i>");
        }
    }
}
