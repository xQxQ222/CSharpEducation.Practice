namespace Practice2.Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] {int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()) };
            int compared = numbers[0].CompareTo(numbers[1]);
            string res = compared == 1 ?  $"Число №1 ({numbers[0]}) больше числа №2 ({numbers[1]})" : (compared==-1 ? $"Число №1 ({numbers[0]}) " +
                $"меньше числа №2 ({numbers[1]})" : "Числа равны");
            Console.WriteLine(res);
        }
    }
}