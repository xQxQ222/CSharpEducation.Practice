namespace Task2
{
    class Program
    {
        public static void Main(string[] args) 
        {
            byte age = 20;
            string name = "Иван";
            sbyte outsideTemperature = 23;
            bool gender = false;
            Console.ReadKey(true);
            ReadAndOutput();
            CombineTwoLines();
            GetCircleSquare();
            GetHypotinuzeFromTwoLegs();
            GetLegFromHypotinuzeAndOtherLeg();
        }

        public static void ReadAndOutput()
        {
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Привет, {name}!");
        }

        public static void CombineTwoLines()
        {
            Console.Write("Введите первую строку: ");
            string firstLine = Console.ReadLine();
            Console.Write("Введите вторую строку: ");
            string secondLine = Console.ReadLine();
            Console.WriteLine($"{firstLine} {secondLine}");
        }

        public static void GetCircleSquare()
        {
            float radius = 14.3f;   
            const double pi = Math.PI;
            Console.WriteLine($"Площадь вашего круга: {Math.Round(pi * radius * radius,2)}");
        }

        public static void GetHypotinuzeFromTwoLegs()
        {
            Console.Write("Введите длину первого катета: ");
            double firstLeg = double.Parse( Console.ReadLine() );
            Console.Write("Введите длину второго катета: ");
            double secondLeg = double.Parse(Console.ReadLine());
            double hypotinuze = Math.Round(Math.Sqrt(Math.Pow(firstLeg, 2) + Math.Pow(secondLeg, 2)),2);
            Console.WriteLine($"Длина гипотенузы: {hypotinuze}");
        }

        public static void GetLegFromHypotinuzeAndOtherLeg()
        {
            Console.Write("Введите длину первого катета: ");
            double firstLeg = double.Parse(Console.ReadLine());
            Console.Write("Введите длину гипотенузы: ");
            double hypotinuze = double.Parse(Console.ReadLine());
            double secondLeg = Math.Round(Math.Sqrt(Math.Pow(hypotinuze, 2) - Math.Pow(firstLeg, 2)), 2);
            Console.WriteLine($"Длина второго катета: {secondLeg}");

        }

    }
}