using System.Text;

namespace Practice2.Task1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Random random = new Random();
            //Счетчик for
            //for(int i = 0; i < random.Next(1,100); i++)
            //{
            //    Console.WriteLine($"Сейчас счетчик for равен {i}");
            //}

            //int counterWhile = random.Next(1,100);
            //int iWhile = 0;
            //while (iWhile < counterWhile)
            //{
            //    Console.WriteLine($"Счетчик while сейчас равен {iWhile}");
            //    iWhile++;
            //}

            //iWhile = 0;
            //do
            //{
            //    Console.WriteLine($"Счетчик do while сейчас равен {iWhile}");
            //    iWhile++;
            //}
            //while (iWhile < counterWhile);
            UserOutput(random);

        }

        public static void UserOutput(Random r)
        {
            int commonCounterMax = r.Next(1, 5);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < commonCounterMax; i++)
            {
                Console.Write($"Введите {i + 1} слово: ");
                sb.Append(Console.ReadLine());
                sb.Append(" ");
            }
            Console.WriteLine($"Целая фраза через for: {sb.ToString()}");
            sb.Clear();

            int whileCounter = 0;

            while (whileCounter < commonCounterMax)
            {
                Console.Write($"Введите {whileCounter + 1} слово: ");
                sb.Append(Console.ReadLine());
                sb.Append(" ");
                whileCounter++;
            }
            Console.WriteLine($"Целая фраза через while: {sb.ToString()}");
            sb.Clear();
            whileCounter = 0;
            do
            {
                Console.Write($"Введите {whileCounter + 1} слово: ");
                sb.Append(Console.ReadLine());
                sb.Append(" ");
                whileCounter++;
            }
            while (whileCounter < commonCounterMax);

            Console.WriteLine($"Целая фраза через do while: {sb.ToString()}");
            sb.Clear();

        }
    }
}