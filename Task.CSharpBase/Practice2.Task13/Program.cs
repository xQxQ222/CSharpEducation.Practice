namespace Task13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину массива: ");
            int length = int.Parse(Console.ReadLine());
            Console.Write("Введите ширину массива: ");
            int width = int.Parse(Console.ReadLine());
            PrintArray(CreateArray(length, width));
        }

        static int[,] CreateArray(int length, int width)
        {
            int[,] array = new int[length, width];
            Random r = new Random();
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    array[i, j] = r.Next(1, 10);
                }
            }
            return array;
        }

        static void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.Write("\n");
            }
        }
    }
}