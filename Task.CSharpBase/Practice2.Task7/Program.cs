namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку:");
            string str = Console.ReadLine();
            Console.WriteLine($"В верхнем регистре: {str.ToUpper()}");
            Console.WriteLine($"В нижнем регистре: {str.ToLower()}");
            Console.WriteLine($"Первая буква большая: {MakeFirstLetterUpper(str)}");
        }

        static string MakeFirstLetterUpper(string str)
        {
            string[] strings = str.Split();
            for (int i = 0; i < strings.Length; i++)
            {
                strings[i] = strings[i].Substring(0,1).ToUpper() + strings[i].Substring(1, strings[i].Length-1).ToLower();
            }
            return string.Join(' ',strings);
        }
    }
}
