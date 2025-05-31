namespace Practice2.Task24
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var e in Enum.GetNames(typeof(DayOfWeek)))
            {
                Console.WriteLine(e);
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