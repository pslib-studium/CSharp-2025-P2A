using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T01_OOP
{
    internal class Student: Human, ITeacheable
    {
        public string ClassName { get; set; }

        public Student(string name, int age, string className) 
            : base(name, age)
        {
            ClassName = className;
        }



        public override void Introduce() // override vs new
                                         // override - přepisuje metodu z rodičovské třídy, zachovává polymorfismus
                                         // new - skryje metodu z rodičovské třídy, ale nezachovává polymorfismus
        {
            Console.WriteLine($"Hello, my name is {Name} and I am {Age} years old, and I am in {ClassName} class.");
        }

        public void Teach()
        {
            Console.WriteLine($"I am a student and I am learning in {ClassName} class.");
        }
    }
}
