using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    public abstract class BaseHandler : IRequestHandler
    {
        protected IRequestHandler next;
        public abstract void Handle(Request request);
        public void Forward(Request request)
        {
            if (next != null)
            {
                next.Handle(request);
            }
            else
            {
                Console.WriteLine("No handler available for this request.");
            }
        }
        public void SetNext(IRequestHandler next)
        {
            this.next = next;
        }
    }
}
