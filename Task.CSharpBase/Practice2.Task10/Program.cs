namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintArray(CreateArray(int.Parse(args[0])));
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

        static void PrintArray(int[] array)
        {
            foreach (int i in array)
                Console.WriteLine(i);
        }
    }
}