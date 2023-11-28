namespace PZ_12
{
    internal class Program
    {
        // Метод, реализующий необходимую логику
        static string[] ExtendStrings(string[] arr)
        {
            int maxLength = 0;

            // Находим самую большую длину строки в массиве
            foreach (string str in arr)
            {
                if (str.Length > maxLength)
                {
                    maxLength = str.Length;
                }
            }

            // Увеличиваем строки до максимальной длины путем добавления символа "#"
            for (int i = 0; i < arr.Length; i++)
            {
                while (arr[i].Length < maxLength)
                {
                    arr[i] += "#";
                }
            }

            return arr;
        }

        static void Main()
        {
            // Ввод данных от пользователя
            Console.WriteLine("Введите строки через запятую: ");
            string input = Console.ReadLine();
            string[] inputArr = input.Split(',');

            // Вызов метода и вывод результата
            string[] result = ExtendStrings(inputArr);
            Console.WriteLine("Результат:");
            foreach (string str in result)
            {
                Console.WriteLine(str);
            }
        }
    }

}