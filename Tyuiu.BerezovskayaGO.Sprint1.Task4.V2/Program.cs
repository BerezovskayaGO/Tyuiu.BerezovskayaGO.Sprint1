using Tyuiu.BerezovskayaGO.Sprint1.Task4.V2.Lib;
namespace Tyuiu.BerezovskayaGO.Sprint1.Task4.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила: Березовская Г. О. | АСОиУБ - 24-1";
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* Спринт #1                                                                                *");
            Console.WriteLine("* Тема: Class Math                                                                         *");
            Console.WriteLine("* Задание #4                                                                               *");
            Console.WriteLine("* Вариант #2                                                                               *");
            Console.WriteLine("* Выполнила: Березовская Галина Олеговна | АСОиУБ - 24-1                                   *");
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                 *");
            Console.WriteLine("* Написать программу, которая запришивает у пользователя исходные данные,                  *");
            Console.WriteLine("* вычисляет результат по формуле и печатает его на экране.                                 *");
            Console.WriteLine("*                                                                                          *");
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                         *");
            Console.WriteLine("********************************************************************************************");

            int x, y;

            Console.WriteLine("Введите значение x: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение y: ");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                               *");
            Console.WriteLine("********************************************************************************************");

            Console.WriteLine("1 / ((x + 2*y) ^ 0,5) = " + ds.Calculate(x, y));

            Console.ReadKey();
        }
    }
}
