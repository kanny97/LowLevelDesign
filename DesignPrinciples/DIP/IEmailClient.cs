using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciples.DIP
{
    public interface IEmailClient
    {
        void SendEmail(string to, string subject, string body);
    }
}
