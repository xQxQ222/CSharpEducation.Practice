using System;
namespace Task1B
{
    class Program
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine(rnd.Next() % 2 == 0 ? "odd" : "even");
        }
    }
}