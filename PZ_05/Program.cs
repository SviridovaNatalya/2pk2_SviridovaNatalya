namespace PZ_05
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите число: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("Таблица умножения для числа " + number + ":");

            int i = 1;
            while (i <= 10)
            {
                int result = number * i;
                Console.WriteLine($"{number} * {i} = {result}");
                i++;
            }
                Console.ReadLine();
        }
    }
}