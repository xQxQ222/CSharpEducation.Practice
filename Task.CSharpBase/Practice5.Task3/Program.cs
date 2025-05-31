namespace Practice5.Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            Dog dog = new Dog("Barboze", 10);
            Cat cat = new Cat("Sam", 5);
            Parrot parrot = new Parrot("Kesha", 2, ConsoleColor.DarkMagenta);
            Eagle eagle = new Eagle();
            animals.Add(cat);
            animals.Add(parrot);
            animals.Add(dog);
            foreach (Animal animal in animals)
            {
                if(animal is not Parrot)
                    animal.MakeSound();
                else
                {
                    ((Parrot)animal).MakeSound("Я кеша");
                }
            }
            List<IFlyable> flyables = new List<IFlyable>();
            flyables.Add(parrot);
            flyables.Add(eagle);
            foreach(IFlyable flyable in flyables)
            {
                flyable.Fly();
            }
        }
    }
}