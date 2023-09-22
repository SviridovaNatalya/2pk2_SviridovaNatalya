namespace PZ_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение a:"); //Выводим на экран просьбу ввести значение переменной a
            double a = Convert.ToDouble(Console.ReadLine()); //Ввод значения переменной a, конвертация строки в тип double
            Console.WriteLine("Введите значение b:"); //Выводим на экран просьбу ввести значение переменной a
            double b = Convert.ToDouble(Console.ReadLine()); //Ввод значения переменной b, конвертация строки в тип double
            Console.WriteLine("Введите значение c:"); //Выводим на экран просьбу ввести значение переменной a
            double c = Convert.ToDouble(Console.ReadLine()); //Ввод значения переменной c, конвертация строки в тип double

            double result; //Переменная результата
            result = ((Math.Pow(10, 4)) * (Math.Pow(Math.Sin(2.5 * c), 2)) - ((0.32 * (Math.Pow(c, 3)) + (4 * c) + b) / (Math.Cos(2 * a))) *
                            (Math.Pow(((0.32 * Math.Pow(c, 3)) - b), (1.0 / 6)) + (Math.Abs(b)))); //Вычисление значения уравнения
            Console.WriteLine("Результат: " + (result)); //Вывод результата
            Console.ReadLine(); //Чтобы окно консоли не закрывалось после запуска
        }
    }
}