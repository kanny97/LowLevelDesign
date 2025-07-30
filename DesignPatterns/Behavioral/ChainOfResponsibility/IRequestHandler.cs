using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    public interface IRequestHandler
    {
       void Handle(Request request);
       void SetNext(IRequestHandler next);
    }
}
