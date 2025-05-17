namespace Task16
{
    class Program
    {
        static void Main()
        {
            int n = -3;
            ReverseNumber(ref n);
            Console.WriteLine(n);
        }

        private static void ReverseNumber(ref int number)
        {
            number = -number;
        }
    }
}