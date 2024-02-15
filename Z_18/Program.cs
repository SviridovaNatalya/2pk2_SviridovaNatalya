using PZ_18;

namespace PZ_18
{
    internal class Prog
    {
        //Пример использования класса в методе Main:
        static void Main(string[] args)
        {
            Patient patient1 = new Patient("Иванов Иван", new DateTime(1980, 12, 31), new DateTime(2022, 1, 1));
            Patient patient2 = new Patient("Петров Петр", new DateTime(2005, 5, 15), new DateTime(2022, 2, 25));
            Patient patient3 = new Patient("Сидоров Сидор", new DateTime(1999, 10, 2), new DateTime(2022, 2, 2));
            Patient patient4 = new Patient("Федоров Федор", new DateTime(1988, 3, 20), new DateTime(2022, 3, 10));

            Patient.PrintPatientCount(); // Вывод информации о количестве пациентов
        }
    }
}