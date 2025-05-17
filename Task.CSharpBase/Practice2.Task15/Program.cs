namespace Task15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину массива: ");
            int length = int.Parse(Console.ReadLine());
            int[] a = CreateArray(length);
            Console.WriteLine("Неинвертированный массив:");
            PrintArray(a);
            Array.Reverse(a);
            Console.WriteLine("Инвертированный массив:");
            PrintArray(a);

        }


        static int[] CreateArray(int length)
        {
            int[] array = new int[length];
            Random r = new Random();
            for (int i = 0; i < length; i++)
            {
                array[i] = r.Next(1, 10);
            }
            return array;
        }

        static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}