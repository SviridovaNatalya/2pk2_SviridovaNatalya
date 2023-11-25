namespace PZ_10
{
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Введите произвольный текст:");
                string text = Console.ReadLine();

                string[] emails = text.Split(' ');
                foreach (string email in emails)
                {
                    if (IsValidEmail(email))
                    {
                        string userName = GetUserName(email);
                        Console.WriteLine($"Привет, {userName}!");
                    }
                }
            }

            static bool IsValidEmail(string email)
            {
                return email.Contains("@"); // Проверяем наличие символа @ в строке
            }

            static string GetUserName(string email)
            {
                int atIndex = email.IndexOf("@");
                return email.Substring(0, atIndex);
            }
        }
    }