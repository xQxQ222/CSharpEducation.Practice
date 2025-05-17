namespace Task12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива: ");
            string[] array = CreateArray(int.Parse(Console.ReadLine()));
            PrintArray(array);
        }

        private static string[] CreateArray(int n)
        {
            string[] array = new string[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Введите {i + 1}) слово: ");
                array[i] = Console.ReadLine();
            }
            return array;
        }

        static void PrintArray(string[] array)
        {
            foreach (string i in array)
                Console.Write(i + " ");
        }
    }
}