namespace PZ_07
{
    internal class Program
    {
        static void Main()
        {
            int size = 5; // размер квадратной матрицы
            int[,] matrix = new int[size, size];

            Random random = new Random();  // Заполнение матрицы случайными числами от 0 до 9
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = random.Next(10);
                }
            }

            Console.WriteLine("Исходная матрица:");
            PrintMatrix(matrix);

            int minElement = FindMinElementBelowSecondaryDiagonal(matrix);
            Console.WriteLine("Минимальный элемент ниже побочной диагонали: " + minElement);

            Console.WriteLine("Матрица ниже побочной диагонали:");
            int[,] diagonalMatrix = GetBelowSecondaryDiagonal(matrix);
            PrintMatrix(diagonalMatrix);
        }
        static void PrintMatrix(int[,] matrix)
        {
            int size = matrix.GetLength(0);
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static int FindMinElementBelowSecondaryDiagonal(int[,] matrix) // Поиск минимального элемента ниже побочной диагонали
        {
            int size = matrix.GetLength(0);
            int minElement = matrix[size - 1, 0]; // предполагаем, что первый элемент ниже побочной диагонали является минимальным

            for (int i = size - 2; i >= 0; i--)
            {
                for (int j = size - i - 1; j < size; j++)
                {
                    if (matrix[i, j] < minElement)
                    {
                        minElement = matrix[i, j];
                    }
                }
            }

            return minElement;
        }
        static int[,] GetBelowSecondaryDiagonal(int[,] matrix) // Получение подматрицы, содержащей элементы ниже побочной диагонали
        {
            int size = matrix.GetLength(0);
            int[,] diagonalMatrix = new int[size, size];

            for (int i = size - 2; i >= 0; i--)
            {
                for (int j = size - i - 1; j < size; j++)
                {
                    diagonalMatrix[i, j] = matrix[i, j];
                }
            }

            return diagonalMatrix;
        }
    }
}