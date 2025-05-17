namespace Practice3.Task3
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите пример (число знак число): ");
            string[] func = Console.ReadLine().Split();
            Calculator calc = new Calculator();
            Console.WriteLine(calc.Calculate(double.Parse(func[0]), double.Parse(func[2]), func[1]));
        }
    }
}