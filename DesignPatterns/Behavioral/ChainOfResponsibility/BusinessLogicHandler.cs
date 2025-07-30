using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    public class BusinessLogicHandler : BaseHandler
    {
        public override void Handle(Request request)
        {
            Console.WriteLine("BusinessLogicHandler: 🚀 Processing request...");
        }
    }
}
