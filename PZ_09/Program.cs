namespace PZ_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите адрес электронной почты:");
            string email = Console.ReadLine();

            if (IsValidEmail(email))
            {
                Console.WriteLine("Адрес электронной почты корректен.");
            }
            else
            {
                Console.WriteLine("Адрес электронной почты некорректен.");
            }
        }

        static bool IsValidEmail(string email)
        {
            // Проверка наличия знака @
            if (!email.Contains("@"))
                return false;

            // Разделение адреса на имя и домен
            string[] parts = email.Split('@');
            if (parts.Length != 2)
                return false;

            string name = parts[0];
            string domain = parts[1];

            // Проверка имени на допустимые символы
            foreach (char c in name)
            {
                if (!char.IsLetterOrDigit(c) && c != '!' && c != '-' && c != '_' && c != '.')
                    return false;
            }

            // Проверка домена на допустимые значения
            if (domain != "gmail.com" && domain != "yandex.ru" && domain != "mail.ru")
                return false;

            return true;
        }
    }
}