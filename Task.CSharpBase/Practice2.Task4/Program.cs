using System.Text;

namespace Practice2.Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите высоту будущей елочки: ");
            int height = int.Parse(Console.ReadLine());
            DrawTree(height);
            Console.WriteLine("Введите знак для отрисовки ели: ");
            char c = Console.ReadKey(true).KeyChar;
            DrawTree(height, c);
        }

        private static void DrawTree(int height, char fill = '*')
        {
            Console.WriteLine("Елочка №1");
            StringBuilder sb = new StringBuilder();
            int i = 0;
            while (i < height)
            {
                sb.Append(fill);
                Console.WriteLine(sb.ToString());
                i++;
            }
            sb.Clear();
            Console.WriteLine("Елочка №2");
            i = 0;
            while (i < height)
            {
                sb.Append(fill);
                string res = sb.ToString().PadLeft(height);
                Console.WriteLine(res);
                i++;
            }
        }

    }
}