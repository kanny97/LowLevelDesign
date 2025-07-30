using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator
{
    public class PlainTextView : ITextView
    {
        private readonly string text;
        public PlainTextView(string text)
        {
            this.text = text;
        }
        public void Render()
        {
            Console.WriteLine(text);
        }
    }
}
