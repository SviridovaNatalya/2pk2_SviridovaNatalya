namespace PZ_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] jaggedArray = new int[5][];
            Random random = new Random();

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                int secondDimensionLength = random.Next(2, 31);
                jaggedArray[i] = new int[secondDimensionLength];

                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    jaggedArray[i][j] = random.Next(1, 101);// Заполнение массива рандомными значениями
                }
            }

            Console.WriteLine("Исходный массив:");

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + " "); // Вывод элементов массива в консоль
                }
                Console.WriteLine();
            }

            int[] lastElementsArray = new int[jaggedArray.Length];

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                lastElementsArray[i] = jaggedArray[i][jaggedArray[i].Length - 1]; // Заполнение массива последними элементами каждой строки
            }

            Console.WriteLine("\nМассив последних элементов:");
            for (int i = 0; i < lastElementsArray.Length; i++)
            {
                Console.Write(lastElementsArray[i] + " "); // Вывод массива последних элементов в консоль
            }

            int[] maxElementsArray = new int[jaggedArray.Length];

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                int maxElement = jaggedArray[i][0];

                for (int j = 1; j < jaggedArray[i].Length; j++)
                {
                    if (jaggedArray[i][j] > maxElement) // Поиск максимального элемента в каждой строке
                    {
                        maxElement = jaggedArray[i][j];
                    }
                }

                maxElementsArray[i] = maxElement; // Заполнение массива максимальных элементов
            }

            Console.WriteLine("\nМассив максимальных элементов:");
            for (int i = 0; i < maxElementsArray.Length; i++)
            {
                Console.Write(maxElementsArray[i] + " "); // Вывод массива максимальных элементов в консоль
            }

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                int maxIndex = 0;

                for (int j = 1; j < jaggedArray[i].Length; j++)
                {
                    if (jaggedArray[i][j] > jaggedArray[i][maxIndex]) // Поиск индекса максимального элемента в каждой строке
                    {
                        maxIndex = j;
                    }
                }

                int temp = jaggedArray[i][0];
                jaggedArray[i][0] = jaggedArray[i][maxIndex];
                jaggedArray[i][maxIndex] = temp; // Обмен местами первого элемента и максимального в каждой строке
            }

            Console.WriteLine("\nОбновленный массив:");
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + " "); // Вывод обновленного массива в консоль
                }
                Console.WriteLine();
            }

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Array.Reverse(jaggedArray[i]); // Реверс каждой строки ступенчатого массива
            }

            Console.WriteLine("\nРеверсированный массив:");
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + " "); // Вывод реверсированного массива в консоль
                }
                Console.WriteLine();
            }
        }
        static void PrintJaggedArray(int[][] array) // Вывод двумерного массива в консоль
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void PrintArray<T>(T[] array)// Вывод одномерного массива в консоль
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
        static int[] GetLastElements(int[][] array) // Получение последних элементов каждой строки ступенчатого массива
        {
            int[] lastElements = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                lastElements[i] = array[i][array[i].Length - 1];
            }
            return lastElements;
        }
        static int[] GetMaxElements(int[][] array)// Получение максимальных элементов каждой строки ступенчатого массива
        {
            int[] maxElements = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                int max = array[i][0];
                for (int j = 1; j < array[i].Length; j++)
                {
                    if (array[i][j] > max)
                    {
                        max = array[i][j];
                    }
                }
                maxElements[i] = max;
            }
            return maxElements;
        }
        static void SwapFirstAndMaxElements(int[][] array) // Замена первого элемента и максимального элемента в каждой строке ступенчатого массива
        {
            for (int i = 0; i < array.Length; i++)
            {
                int maxIndex = 0;
                int max = array[i][0];
                for (int j = 1; j < array[i].Length; j++)
                {
                    if (array[i][j] > max)
                    {
                        maxIndex = j;
                        max = array[i][j];
                    }
                }
                int temp = array[i][0];
                array[i][0] = max;
                array[i][maxIndex] = temp;
            }
        }
    }
}