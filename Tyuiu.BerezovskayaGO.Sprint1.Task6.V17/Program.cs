using Tyuiu.BerezovskayaGO.Sprint1.Task6.V17.Lib;
namespace Tyuiu.BerezovskayaGO.Sprint1.Task6.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнила: Березовская Г. О. | АСОиУБ - 24-1";
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* Спринт #1                                                                                *");
            Console.WriteLine("* Тема: Работа со строками класс String                                                    *");
            Console.WriteLine("* Задание #6                                                                               *");
            Console.WriteLine("* Вариант #17                                                                              *");
            Console.WriteLine("* Выполнила: Березовская Галина Олеговна | АСОиУБ - 24-1                                   *");
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                 *");
            Console.WriteLine("* Написать программу: пользователь вводит текст                                            *");
            Console.WriteLine("* Проверить, что строка является перевертышем.                                             *");
            Console.WriteLine("*                                                                                          *");
            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                         *");
            Console.WriteLine("********************************************************************************************");

            Console.WriteLine("Введите текст:");
            string text = Console.ReadLine();

            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                               *");
            Console.WriteLine("********************************************************************************************");
            var result = new DataService().CheckPalindrome(text);
            Console.WriteLine(result
                ? "Строка является перевертышем"
                : "Строка не является перевертышем");
            Console.ReadKey();
        }
    }
}
