using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5.Task3
{
    public abstract class Animal
    {
        private string name;
        private int age;

        public Animal(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void Eat()
        {
            Console.WriteLine($"{this.GetType().Name} is eating");
        }

        public void Sleep()
        {
            Console.WriteLine($"{this.GetType().Name} is sleeping");
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic animal sound");
        }


    }
}
