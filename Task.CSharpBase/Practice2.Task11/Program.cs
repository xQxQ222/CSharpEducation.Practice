namespace Task11
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintArray(CreateArray(int.Parse(args[0]), int.Parse(args[1])));
        }

        private static int[] CreateArray(int n, int fillNumber)
        {
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = fillNumber;
            }
            return array;
        }

        static void PrintArray(int[] array)
        {
            foreach (int i in array)
                Console.WriteLine(i);
        }
    }
}