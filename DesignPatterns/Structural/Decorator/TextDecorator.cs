using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator
{
    public abstract class TextDecorator : ITextView
    {
        protected ITextView inner;
        protected TextDecorator(ITextView inner)
        {
            this.inner = inner;
        }
        public virtual void Render()
        {
            inner.Render();
        }
    }
}
