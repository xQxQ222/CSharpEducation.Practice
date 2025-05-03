namespace Task17
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 8;
            ReplaceNums(ref a, ref b);
            Console.WriteLine($"{a} {b}");
        }

        private static void ReplaceNums(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}