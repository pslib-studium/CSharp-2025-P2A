using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T01_OOP
{
    internal class Teacher : Human
    {
        public string Subject { get; set; }

        public Teacher(string name, int age, string subject)
            : base(name, age)
        {
            Subject = subject;
        }

        public override void Introduce()
        {
            Console.WriteLine($"Hello, my name is {Name} and I am {Age} years old, and I teach {Subject}.");
        }
    }
}
