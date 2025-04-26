namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            FindPercentage();
            WaitAndClear();
            Console.Write("Введите строку: ");
            string str = Console.ReadLine();
            char c = Console.ReadKey(true).KeyChar;
            FindPercentage(str, c);
            WaitAndClear();
            FindPercentage(args[0], args[1].ToCharArray()[0]);

        }

        private static void FindPercentage(string str = "ггг", char c = 'г')
        {
            double counter = 0;
            foreach (var e in str.ToCharArray())
            {
                if (e.Equals(c))
                    counter++;
            }
            double percentage = Math.Round(counter / str.Length,4)*100;
            Console.WriteLine($"Строка: {str}\nСимвол: {c}");
            Console.WriteLine($"Процент попадания символа {c.ToString()} в строку: {percentage}%");
        }

        private static void WaitAndClear()
        {
            Console.WriteLine("Нажмите любую клавишу чтобы продолжить");
            Console.ReadKey(true);
            Console.Clear();
        }
    }
}