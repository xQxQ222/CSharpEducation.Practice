using System.Globalization;

namespace Practice3.Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetDayCount(Months.Сентябрь));
            
        }

        private static int GetDayCount(Months month)
        {
            return DateTime.DaysInMonth(DateTime.Now.Year, (int)month);
        }
    }

    public enum Months
    {
        Январь = 1,
        Февраль = 2,
        Март = 3,
        Апрель = 4,
        Май = 5,
        Июнь = 6,
        Июль = 7,
        Август = 8,
        Сентябрь = 9,
        Октябрь = 10,
        Ноябрь = 11,
        Декабрь = 12
    }
}