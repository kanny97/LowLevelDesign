using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics.Inheritance
{
    public class Dog : Animal
    {
        public Dog(string name, int age) : base(name, age)
        {
            Console.WriteLine($"Dog constructor called for {name} aged {age}");
        }

        public override void Speak()
        {
            Console.WriteLine("Woof!");
        }
    }
}
