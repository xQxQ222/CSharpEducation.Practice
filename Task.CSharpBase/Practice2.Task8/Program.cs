namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int[] nums = new int[3];
            while (i < 3)
            {
                Console.Write($"Введите {i + 1} число: ");
                nums[i] = int.Parse( Console.ReadLine() );
                i++;
            }
            if(nums.Distinct().Count() >= 2)
            {
                foreach(var e in nums)
                {
                    Console.WriteLine(e+5);
                }
            }
        }
    }
}