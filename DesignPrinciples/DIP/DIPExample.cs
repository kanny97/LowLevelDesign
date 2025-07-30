using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciples.DIP
{
    public class DIPExample
    {
        public static void Main(string[] args)
        {
            // Dependency Inversion Principle (DIP) Example
            // The DIP states that high-level modules should not depend on low-level modules. Both should depend on abstractions.
            // Abstractions should not depend on details. Details should depend on abstractions.
            IEmailClient emailClient = new OutlookClient();
            EmailService emailService = new EmailService(emailClient);
            emailService.SendWelcomeEmail("kachakr@microsoft.com","Welcome Kanakdeep", "Welcome to the Ads Team");
            emailService.SendPasswordResetEmail("kachakr@microsoft.com", "https://passwordreset.com");
        }
    }
}
