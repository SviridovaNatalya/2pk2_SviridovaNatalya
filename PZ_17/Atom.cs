using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_17
{
    internal class Atom
    {
        public string Name { get; set; }
        public int CountElectrons { get; set; }
        public double Mass { get; set; }
        public int Valence { get; set; }

        // Конструкторы класса
        public Atom()
        {
            Name = "Unknown";
            CountElectrons = 0;
            Mass = 0;
            Valence = 0;
        }

        public Atom(string name, int countElectrons, double mass, int valence)
        {
            Name = name;
            CountElectrons = countElectrons;
            Mass = mass;
            Valence = valence;
        }

        public Atom(string name, int countElectrons)
        {
            Name = name;
            CountElectrons = countElectrons;
            Mass = 0; // значение по умолчанию
            Valence = 0; // значение по умолчанию
        }

        // Метод для вывода информации
        public void PrintInfo()
        {
            Console.WriteLine($"Имя: {Name}, Количество электронов: {CountElectrons}, Масса: {Mass}, Валентность: {Valence}");
        }
    }

    class Program
    {
        static void Main()
        {
            // Создание объектов с использованием различных конструкторов
            Atom carbon = new Atom("Carbon", 6, 12.01, 4);
            Atom oxygen = new Atom("Oxygen", 8, 16.00, 6);
            Atom hydrogen = new Atom("Hydrogen", 1); // Используется второй конструктор
            Atom helium = new Atom(); // Используется конструктор по умолчанию

            // Проверка работы метода PrintInfo для каждого объекта
            carbon.PrintInfo();
            oxygen.PrintInfo();
            hydrogen.PrintInfo();
            helium.PrintInfo();
        }
    }
}
