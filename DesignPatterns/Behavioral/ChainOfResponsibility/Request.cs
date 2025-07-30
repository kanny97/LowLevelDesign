using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    public class Request
    {
        public string User { get; set; }
        public string UserRole { get; set; }
        public int RequestCount { get; set; }
        public string Payload { get; set; }
        public Request(string user, string userRole, int requestCount, string payload)
        {
            User = user;
            UserRole = userRole;
            RequestCount = requestCount;
            Payload = payload;
        }
    }
}
