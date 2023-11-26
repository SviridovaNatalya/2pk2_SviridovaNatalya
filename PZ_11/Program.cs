namespace PZ_11
{
    internal class Program
    {
        static int Quarter(int x, int y)
        {
            if (x > 0 && y > 0)
            {
                return 1;
            }
            else if (x < 0 && y > 0)
            {
                return 2;
            }
            else if (x < 0 && y < 0)
            {
                return 3;
            }
            else if (x > 0 && y < 0)
            {
                return 4;
            }
            else
            {
                return 0;
            }
        }

        static void Main(string[] args)
        {
            int x1, y1, x2, y2, x3, y3;
            Console.WriteLine("Введите координаты первой точки (x1, y1):");
            x1 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координаты второй точки (x2, y2):");
            x2 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координаты третьей точки (x3, y3):");
            x3 = Convert.ToInt32(Console.ReadLine());
            y3 = Convert.ToInt32(Console.ReadLine());

            int quarter1 = Quarter(x1, y1);
            int quarter2 = Quarter(x2, y2);
            int quarter3 = Quarter(x3, y3);

            Console.WriteLine("Номер координатной четверти для первой точки: " + quarter1);
            Console.WriteLine("Номер координатной четверти для второй точки: " + quarter2);
            Console.WriteLine("Номер координатной четверти для третьей точки: " + quarter3);

            Console.ReadLine();
        }
    }
}