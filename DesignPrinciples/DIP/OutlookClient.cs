using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciples.DIP
{
    public class OutlookClient : IEmailClient
    {
        public void SendEmail(string to, string subject, string body)
        {
            Console.WriteLine($"Sending email via Outlook to {to} with subject '{subject}' and body '{body}'");
        }
    }
}
