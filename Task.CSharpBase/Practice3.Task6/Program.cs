namespace Practice3.Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point(1, 2);
            Point point2 = new Point(2, 3);

            Console.WriteLine(point1.GetDistanceTo(point2));
        }
    }
}