using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5.Task3
{
    class Parrot : Animal, IFlyable
    {
        private ConsoleColor color;
        public Parrot(string name, int age, ConsoleColor color) : base(name, age)
        {
            this.color = color;
        }

        private new void MakeSound()
        {
            Console.WriteLine("Parrot is talking");
        }

        public void MakeSound(string words)
        {
            Console.ForegroundColor = color;
            Console.WriteLine("Parrot: " + words);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void Fly()
        {
            Console.ForegroundColor = color;
            Console.WriteLine("Parrot is flying");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
