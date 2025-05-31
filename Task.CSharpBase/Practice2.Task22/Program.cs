namespace Practice2.Task22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Игра: УГАДАЙ ЧИСЛО!");
            Random r = new Random();
            int randomNumber = r.Next(1, 100);
            int maxTryCount = r.Next(2, 20);
            Console.WriteLine($"У вас будет {maxTryCount} попыток угадать число!");
            int userInput = 0;
            int i = 0;
            do
            {
                i++;
                Console.Write($"Попытка №{i}\nВведите число: ");
                try
                {
                    userInput = int.Parse(Console.ReadLine());
                    if (userInput > randomNumber)
                    {
                        Console.WriteLine("Ваше число больше загаданного!");
                    }
                    else if (userInput < randomNumber)
                    {
                        Console.WriteLine("Ваше число меньше загаданного!");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            while (userInput != randomNumber && i < maxTryCount);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Вы победили! Поздравляем!\nНа отгадывание числа ушло {i} попыток");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}