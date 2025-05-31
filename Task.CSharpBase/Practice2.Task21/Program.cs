namespace Practice2.Task21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Игра: УГАДАЙ ЧИСЛО!");
            Random r = new Random();
            int randomNumber = r.Next(1, 100);
            int userInput = 0;
            int i = 0;
            do
            {
                i++;
                Console.Write($"Попытка №{i}\nВведите число: ");
                try
                {
                    userInput = int.Parse(Console.ReadLine());
                    if (userInput != randomNumber)
                    {
                        Console.WriteLine("НЕТ!");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            while (userInput != randomNumber);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Вы победили! Поздравляем!\nНа отгадывание числа ушло {i} попыток");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}