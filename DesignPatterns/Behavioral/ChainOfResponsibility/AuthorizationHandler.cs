using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    public class AuthorizationHandler : BaseHandler
    {
        public override void Handle(Request request)
        {
            if (request.UserRole != "Admin" && request.UserRole != "Manager")
            {
                Console.WriteLine($"Authorization failed for user: {request.User} with role: {request.UserRole}");
                return;
            }
            Console.WriteLine($"Authorization successful for user: {request.User} with role: {request.UserRole}");
            Forward(request);
        }
    }
}
