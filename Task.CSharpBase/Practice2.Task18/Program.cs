namespace Task18
{
    class Program
    {
        static void Main()
        {
            int deletedCount = 0;
            int[] a = DeleteNegativesNumbs(new int[] { 1, 2, 3, -5, -8, -8, -9, -1 }, out deletedCount);
            Console.WriteLine(deletedCount + " " + a.Length);
        }

        static int[] DeleteNegativesNumbs(int[] array, out int deletedCount)
        {
            deletedCount = array.Where(x => x < 0).Count();
            return array.Where(x => x > 0).ToArray();
        }
    }
}