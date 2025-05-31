namespace Practice2.Task25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер дня недели: ");
            try
            {
                int day = int.Parse(Console.ReadLine());
                if(day < 1 || day > 7)
                {
                    throw new ArgumentException();
                }
                Console.WriteLine(Enum.GetName(typeof(DayOfWeek), day-1));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }

    enum DayOfWeek
    {
        Понедельник,
        Вторник,
        Среда,
        Четверг,
        Пятница,
        Суббота,
        Воскресенье
    }
}