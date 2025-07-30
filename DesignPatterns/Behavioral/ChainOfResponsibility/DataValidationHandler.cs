using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    public class DataValidationHandler : BaseHandler
    {
        public override void Handle(Request request)
        {
            if (string.IsNullOrEmpty(request.Payload))
            {
                Console.WriteLine("Data validation failed: Data is missing.");
                return;
            }
            Console.WriteLine($"Data validation successful for data: {request.Payload}");
            Forward(request);
        }
    }    
}
