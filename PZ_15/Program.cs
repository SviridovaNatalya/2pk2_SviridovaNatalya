namespace PZ_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                try
                {
                    Console.WriteLine("Введите полный путь к каталогу:");
                    string directoryPath = Console.ReadLine();

                    // Проверка существования каталога
                    if (!Directory.Exists(directoryPath))
                    {
                        throw new DirectoryNotFoundException("Каталог не найден");
                    }

                    string[] files = Directory.GetFiles(directoryPath); // Получение списка файлов

                    Console.WriteLine("Доступные файлы:");

                    foreach (string file in files)
                    {
                        Console.WriteLine(Path.GetFileNameWithoutExtension(file));  // Вывод списка файлов без расширения
                    }

                    Console.WriteLine("Введите название файла (без расширения):");
                    string fileName = Console.ReadLine();

                    string filePath = Path.Combine(directoryPath, fileName + ".txt");

                    // Проверка существования файла
                    if (!File.Exists(filePath))
                    {
                        throw new FileNotFoundException("Файл не найден");
                    }

                    string fileContent = File.ReadAllText(filePath); // Чтение содержимого файла
                    Console.WriteLine("Содержимое файла:");
                    Console.WriteLine(fileContent);
                }
                catch (DirectoryNotFoundException ex)
                {
                    Console.WriteLine("Ошибка: " + ex.Message);
                }
                catch (FileNotFoundException ex)
                {
                    Console.WriteLine("Ошибка: " + ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Произошла ошибка: " + ex.Message);
                }
            }
        }
    }
}