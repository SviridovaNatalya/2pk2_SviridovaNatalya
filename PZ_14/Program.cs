namespace PZ_14
{
    internal class Program
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Введите путь к папке:");
                string folderPath = Console.ReadLine();

                // Проверяем существует ли указанная папка
                if (Directory.Exists(folderPath))
                {
                    // Получаем список текстовых файлов в указанной папке
                    string[] files = Directory.GetFiles(folderPath, "*.txt");

                    if (files.Length > 0)
                    {
                        // Создаем файл OUT.TXT в текущей директории
                        string outputPath = Path.Combine(Directory.GetCurrentDirectory(), "OUT.TXT");

                        // Используем потоки для чтения файлов и записи в новый файл
                        using (var outputStream = new StreamWriter(outputPath))
                        {
                            foreach (string file in files)
                            {
                                // Читаем содержимое каждого текстового файла
                                using (var inputStream = new StreamReader(file))
                                {
                                    string content = inputStream.ReadToEnd();
                                    // Записываем содержимое в OUT.TXT
                                    outputStream.WriteLine(file + ":\n" + content);
                                }
                            }
                        }

                        Console.WriteLine("Содержимое текстовых файлов успешно скопировано в OUT.TXT");
                    }
                    else
                    {
                        Console.WriteLine("В указанной папке отсутствуют текстовые документы");
                    }
                }
                else
                {
                    Console.WriteLine("Указанная папка не существует");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
        }
    }
}