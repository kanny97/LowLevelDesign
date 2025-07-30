using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciples.DIP
{
    public class EmailService
    {
        private readonly IEmailClient emailClient;
        public EmailService(IEmailClient emailClient)
        {
            this.emailClient = emailClient;
        }
        public void SendWelcomeEmail(string recipientEmail, string subject, string body)
        {
            if (string.IsNullOrEmpty(recipientEmail) || string.IsNullOrEmpty(subject) || string.IsNullOrEmpty(body))
            {
                throw new ArgumentException("Email parameters cannot be null or empty.");
            }
            emailClient.SendEmail(recipientEmail, subject, body);
            Console.WriteLine($"Welcome email sent to {recipientEmail} with subject '{subject}'");
        }
        public void SendPasswordResetEmail(string recipientEmail, string resetLink)
        {
            if (string.IsNullOrEmpty(recipientEmail) || string.IsNullOrEmpty(resetLink))
            {
                throw new ArgumentException("Email parameters cannot be null or empty.");
            }
            string subject = "Password Reset Request";
            string body = $"Click the following link to reset your password: {resetLink}";
            emailClient.SendEmail(recipientEmail, subject, body);
            Console.WriteLine($"Password reset email sent to {recipientEmail}");
        }
    }
}
