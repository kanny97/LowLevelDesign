using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    public class AuthenticationHandler : BaseHandler
    {
        public override void Handle(Request request)
        {
            if (string.IsNullOrEmpty(request.User) || string.IsNullOrEmpty(request.UserRole))
            {
                Console.WriteLine("Authentication failed: User or role is missing.");
                return;
            }
            Console.WriteLine($"Authentication successful for user: {request.User} with role: {request.UserRole}");
            Forward(request);
        }
    }
}
