namespace Practice2.Task2
{
    class Program
    {
        private const float METRES_TO_KM_MULTIPLIER = 0.001f;
        private const float CENTIMETRES_TO_KM_MULTIPLIER = 0.00001f;
        private const float MS_TO_KMH_MULTIPLIER = 3.6f;
        private const float CELSIUM_TO_FARENHEIT_ADD = 273;
        private const string menu = "Выберите опцию:\n1)Перевод метров в километры\n2)Перевод сантиметров в километры" +
                "\n3)Перевод м/с в км/ч\n4)Перевод температуры из C в F\n5)Выход";
        public static void Main(string[] args)
        {
            string userChoise;
            while (true)
            {
                Console.WriteLine(menu);
                userChoise = Console.ReadLine();
                switch (userChoise)
                {
                    case "1":
                        Console.WriteLine("Введите длину в метрах");
                        float km = METRES_TO_KM_MULTIPLIER * float.Parse(Console.ReadLine());
                        Console.WriteLine($"Длина в километрах: {Math.Round(km, 2)} км.");
                        WaitAndClear();
                        break;
                    case "2":
                        Console.WriteLine("Введите длину в сантиметрах");
                        float kilometres = CENTIMETRES_TO_KM_MULTIPLIER * float.Parse(Console.ReadLine());
                        Console.WriteLine($"Длина в километрах: {Math.Round(kilometres, 2)} км.");
                        WaitAndClear();
                        break;
                    case "3":
                        Console.WriteLine("Введите скорость в м/с");
                        float kmh = MS_TO_KMH_MULTIPLIER * float.Parse(Console.ReadLine());
                        Console.WriteLine($"Скорость в км/ч: {Math.Round(kmh, 2)} км/ч");
                        WaitAndClear();
                        break;
                    case "4":
                        Console.WriteLine("Введите температуру в цельсиях");
                        float farenheits = CELSIUM_TO_FARENHEIT_ADD + float.Parse(Console.ReadLine());
                        Console.WriteLine($"Температура в градусах по Фаренгейту: {Math.Round(farenheits, 2)} F");
                        WaitAndClear();
                        break;
                    case "5":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Такой опции нет в меню");
                        WaitAndClear();
                        break;

                }
            }

        }

        private static void WaitAndClear()
        {
            Console.WriteLine("Нажмите любую кнопку для продолжения...");
            Console.ReadKey();
            Console.Clear();
        }

    }
}