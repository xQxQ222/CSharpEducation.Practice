namespace Task19
{
    class Program
    {
        static void Main()
        {
            int[] a = CreateAndFillArray();
            Console.WriteLine(a.Max() - a.Min());
        }

        static int[] CreateAndFillArray()
        {
            Random r = new Random();
            int[] a = new int[r.Next(1, 101)];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = r.Next(1,101);
            }
            return a;
        }
    }
}