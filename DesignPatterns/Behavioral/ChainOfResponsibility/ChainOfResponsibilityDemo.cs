using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    public class ChainOfResponsibilityDemo
    {
        public static void Main(string[] args)
        {
            // Create the chain of responsibility
            IRequestHandler authentication = new AuthenticationHandler();
            IRequestHandler authorization = new AuthorizationHandler();
            IRequestHandler rateLimit = new RateLimiterHandler();
            IRequestHandler dataValidation = new DataValidationHandler();
            IRequestHandler businessLogic = new BusinessLogicHandler();

            authentication.SetNext(authorization);
            authorization.SetNext(rateLimit);
            rateLimit.SetNext(dataValidation);
            dataValidation.SetNext(businessLogic);

            // Create a request and handle it through the chain
            Request request = new Request("john", "Admin", 10, "{ \"data\": \"valid\" }");
            authentication.Handle(request);
            //Create a bad request to test the chain
            Request badRequest = new Request(null, "User", 150, "");
            authentication.Handle(badRequest);
        }
    }
}
