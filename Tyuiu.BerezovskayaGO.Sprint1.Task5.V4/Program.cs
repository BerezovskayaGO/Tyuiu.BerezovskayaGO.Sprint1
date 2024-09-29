using Tyuiu.BerezovskayaGO.Sprint1.Task5.V4.Lib;
namespace Tyuiu.BerezovskayaGO.Sprint1.Task5.V4
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

            Console.WriteLine("Введите секунду суток: ");
            int k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                               *");
            Console.WriteLine("********************************************************************************************");

            Console.WriteLine("К этому моменту прошло " + ds.SecondsToHours(k) + " часов");

            Console.ReadKey();
        }
    }
}
