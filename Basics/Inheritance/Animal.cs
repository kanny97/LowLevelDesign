using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics.Inheritance
{
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Animal(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            Console.WriteLine($"Animal constructor called for {name} aged {age}");
        }
        public virtual void Speak()
        {
            Console.WriteLine($"{Name} makes a sound.");
        }
        public void Eat()
        {
            Console.WriteLine($"{Name} is eating.");
        }
    }
}
