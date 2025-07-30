using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator
{
    public class DecoratorDemo
    {
        public static void Main(string[] args)
        {
            ITextView plainTextView = new PlainTextView("Hello World!");
            Console.WriteLine("Plain view");
            plainTextView.Render();

            ITextView boldStyle = new BoldDecorator(plainTextView);            
            Console.WriteLine("Bold view");
            boldStyle.Render();

            ITextView italicStyle = new ItalicDecorator(plainTextView);
            Console.WriteLine("Italic view");
            italicStyle.Render();

            ITextView underlinedStyle = new UnderlineDecorator(plainTextView);
            Console.WriteLine("Underlined view");
            underlinedStyle.Render();

            ITextView allStyles = new UnderlineDecorator(new ItalicDecorator(new BoldDecorator(plainTextView)));
            Console.WriteLine("All styles");
            allStyles.Render();
        }
    }
}
