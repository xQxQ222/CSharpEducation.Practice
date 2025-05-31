using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5.Task3
{
    class Cat : Animal
    {
        public Cat(string name, int age) : base(name, age)
        {
            Console.WriteLine($"Cat {name}, {age} is created");
        }

        public override void MakeSound()
        {
            Console.WriteLine("MEEEEOW");
        }
    }
}
