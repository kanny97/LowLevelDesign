using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciples.DIP
{
    public class GmailClient : IEmailClient
    {
        public void SendEmail(string to, string subject, string body)
        {
            //Dummy send email implementation
            Console.WriteLine($"Sending email via Gmail to {to} with subject '{subject}' and body '{body}'");
        }
    }
}
