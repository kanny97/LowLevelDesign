using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics.Aggregation
{
    public class Professor
    {
        private string Name;
        private string Subject;
        public Professor(string name, string subject)
        {
            this.Name = name;
            this.Subject = subject;
        }
        public string GetName()
        {
            return Name;
        }
        public string GetSubject()
        {
            return Subject;
        }
        public void Teach()
        {
            Console.WriteLine($"{Name} is teaching {Subject}");
        }
    }
}
