namespace Task9
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите длину массива: ");
            int n = int.Parse(Console.ReadLine());
            PrintArray(CreateArray(n));
        }

        private static int[] CreateArray(int n)
        {
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = i;
            }
            return array;
        }

        private static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
                Console.WriteLine(array[i]);
        }
    }
}