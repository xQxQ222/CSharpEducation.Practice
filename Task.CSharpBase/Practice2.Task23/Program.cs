namespace Practice2.Task23
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите год: ");
            int year = int.Parse(Console.ReadLine());
            bool isLeap = IsLeapYear(year);
            Console.WriteLine(isLeap ? "Год високосный" : "Год не високосный");
        }

        private static bool IsLeapYear(int year)
        {
            if (year % 400 == 0)
            {
                return true;
            }
            if(year % 4  == 0 && year % 100 != 0)
            {
                return true;
            }
            return false;
        }
    }
}
