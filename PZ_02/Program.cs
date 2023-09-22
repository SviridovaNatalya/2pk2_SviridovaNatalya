namespace PZ_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение h: ");
            double h = Convert.ToDouble(Console.ReadLine());
            double x, y, z;
            double result;

            if (h > 3.5)
            {
                x = h * Math.Cos(a + Math.Sqrt(a + h));
            }
            else
            {
                x = a * Math.Sin(h + 1) + 4.5 * a;
            }

            if (x <= 7)
            {
                y = a * Math.Pow(h, 2) + 4 * Math.Sin(x) + x;
            }
            else
            {
                y = Math.Exp(a) + Math.Pow(x, 2) - h * x;
            }

            double absoluteY = Math.Abs(y);

            z = (a * Math.Pow(h, 3)) / (Math.Pow(x, 2) + absoluteY + 10);

            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);
            Console.WriteLine("z = " + z);

            Console.ReadLine();
        }
    }
}
