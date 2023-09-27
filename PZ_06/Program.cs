namespace PZ_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 101);
            }

            Console.WriteLine("Все элементы массива:");
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine("\nУникальные элементы массива:");
            foreach (int number in array)
            {
                int count = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (number == array[i])
                    {
                        count++;
                    }
                }

                if (count == 1)
                {
                    Console.Write($"{number} ");
                }
            }

        }
    }
}