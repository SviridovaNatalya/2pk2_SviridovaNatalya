namespace PZ_04
{
    internal class Program
    {
        // Задание 1
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1:");
            for (int i = 20; i <= 90; i += 5)
            {
                Console.WriteLine(i);
            }

            // Задание 2
            Console.WriteLine("Задание 2:");
            char startChar = 'Ж';

            for (int i = 0; i < 5; i++)
            {
                Console.Write(startChar);
                startChar++;
            }
            Console.WriteLine();

            // Задание 3
            Console.WriteLine("Задание 3:");
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    Console.Write('#');
                }
                Console.WriteLine();
            }

            // Задание 4
            Console.WriteLine("Задание 4:");
            int count = 0;
            for (int i = -100; i <= 0; i++)
            {
                if (i % 13 == 0)
                {
                    Console.Write(i + " ");
                    count++;
                }
            }
            Console.WriteLine("\nКоличество кратных чисел: " + count);


            // Задание 5
            Console.WriteLine("Задание 5:");
            int a = 5;
            int b = 100;

            while (Math.Abs(a - b) >= 9)
            {
                Console.WriteLine($"a = {a}, b = {b}");
                a++;
                b--;
            }

            Console.WriteLine($"Final values: a = {a}, b = {b}");


        }

    }
}