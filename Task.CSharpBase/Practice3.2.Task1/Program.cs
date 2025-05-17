namespace Practice32.Task1
{
    class Program
    {
        static void Main()
        {
            MathHelper.MathHelper mathHelper = new MathHelper.MathHelper();
            Console.Write("Введите пример в формате a ? b: ");
            string[] func = Console.ReadLine().Split();
            double result = mathHelper.Solve(double.Parse(func[0]), double.Parse(func[2]), func[1]);
            Console.WriteLine($"Ответ: {result}");
        }
    }
}