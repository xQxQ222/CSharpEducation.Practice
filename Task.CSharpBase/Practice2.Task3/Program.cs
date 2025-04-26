namespace Practice2.Task3
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.Write("Введите значение переменной a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите значение переменной b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Введите значение переменной f: ");
            double f = double.Parse(Console.ReadLine());
            double result;
            try
            {
                result = (a + b - f / a) + f * a * a - (a + b);
                Console.WriteLine($"Результат выражения: {Math.Round(result,3)}");
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("Было деление на 0 :(");
            }

        }
    }
}