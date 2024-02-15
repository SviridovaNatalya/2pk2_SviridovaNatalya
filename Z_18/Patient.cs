using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_18
{
    internal class Patient
    {
        public static int Count { get; private set; } // Статическое поле количества пациентов

        private string _fullName;
        public string FullName
        {
            get { return _fullName; }
            set
            {
                while (string.IsNullOrWhiteSpace(value)) // Проверка на ввод пустых данных
                {
                    Console.WriteLine("Ошибка: ФИО пациента не может быть пустым. Пожалуйста, введите ФИО снова.");
                    value = Console.ReadLine();
                }
                _fullName = value;
            }
        }

        public DateTime DateOfBirth { get; set; } // Дата рождения пациента
        public DateTime DateOfAdmission { get; set; } // Дата поступления пациента
        public DateTime? DateOfDischarge { get; private set; } // Дата выписки пациента

        public Patient(string fullName, DateTime dateOfBirth, DateTime dateOfAdmission)
        {
            FullName = fullName; // Проверка на ввод пустых данных
            DateOfBirth = dateOfBirth;

            if (DateTime.Now.Year - dateOfBirth.Year < 18) // Проверка на возраст
            {
                Console.WriteLine("Ошибка: Несовершеннолетний пациент не может быть помещен в отделение.");
                return;
            }

            if ((DateTime.Now - dateOfAdmission).TotalDays > 7) // Проверка даты поступления
            {
                Console.WriteLine("Ошибка: Дата поступления не может быть позже, чем за неделю от текущей даты.");
                return;
            }

            if (Count >= 10) // Проверка на количество пациентов
            {
                Console.WriteLine("Ошибка: Нет мест в отделении.");
                return;
            }

            DateOfAdmission = dateOfAdmission;
            Count++;
        }

        public bool IsAdult() // Метод проверки совершеннолетия
        {
            return (DateTime.Now - DateOfBirth).TotalDays >= 365 * 18;
        }

        public void Discharge() // Метод выписки пациента
        {
            DateOfDischarge = DateTime.Now;
            Count--;
            Console.WriteLine($"Пациент {FullName} поступил в отделение {DateOfAdmission}, выписан {DateOfDischarge}");
        }

        public void PrintInfo() // Метод печати информации о пациенте
        {
            Console.WriteLine($"ФИО: {FullName}, Дата рождения: {DateOfBirth:D}, Дата поступления: {DateOfAdmission:D}");
        }

        public static void PrintPatientCount() // Статический метод вывода количества пациентов в отделении
        {
            Console.WriteLine($"Количество пациентов в отделении: {Count}");
        }
    }
}
