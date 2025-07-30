using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    public class RateLimiterHandler : BaseHandler
    {
        public override void Handle(Request request)
        {
            if (request.RequestCount > 100)
            {
                Console.WriteLine($"Rate limit exceeded for user: {request.User}. Request count: {request.RequestCount}");
                return;
            }
            Console.WriteLine($"Rate limit check passed for user: {request.User}. Request count: {request.RequestCount}");
            Forward(request);
        }
    }
}
