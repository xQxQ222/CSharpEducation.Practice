namespace Task14
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] array = new int[random.Next(1, 100)];
            Console.WriteLine(ReturnEmptyArray(array).Length);
        }

        static int[] ReturnEmptyArray(int[] array)
        {
            return new int[array.Length];
        }
    }
}