namespace Practice2.Task20
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] numbers = new int[10, 10];
            Random r = new Random();
            for(int i = 0;i < numbers.GetLength(0); i++)
            {
                for(int j = 0; j < numbers.GetLength(1); j++)
                {
                    numbers[i, j] = r.Next(1, 100);
                }
            }
            for(int i = 0; i < numbers.GetLength(0); i++)
            {
                int max = int.MinValue;
                int min = int.MaxValue;
                for(int j = 0;j < numbers.GetLength(1); j++)
                {
                    int currentNumber = numbers[i, j];
                    if (currentNumber > max)
                    {
                        max = numbers[i, j];
                    }
                    if(currentNumber < min)
                    {
                        min = numbers[i, j];
                    }
                }
                    
                Console.WriteLine($"В строке №{i+1} разница между максимальным и минимальным числом: {max-min}");
            }
        }
    }
}