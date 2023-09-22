namespace PZ_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Не акула, а зубы имеет," +
            "\nПерекусить дерево сумеет," +
            "\nВ руки ты ее бери" +
            "\nИ туда-сюда води.");
            string answer = Console.ReadLine().ToLower(); // Ввод ответа пользователя
            switch (answer) // Проверка ответа пользователя
            {
                case "Пила":
                    Console.WriteLine("Правильно! Ты отгадал!");
                    break;
                case "Сдаюсь":
                    Console.WriteLine("Ответ на загадку: пила");
                    break;
                default:
                    Console.WriteLine("Ответ неверный!");
                    break;
                    Console.ReadLine(); //Нужно, чтобы окно консошли не закрывалось после вывода результата
            }
        }
    }
}