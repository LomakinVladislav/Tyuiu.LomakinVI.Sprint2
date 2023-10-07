using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.LomakinVI.Sprint2.Task3.V2.Lib;

namespace Tyuiu.LomakinVI.Sprint2.Task3.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Ломакин В. И. | ИИПб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Вложенненные операторы if-else                                    *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #2                                                              *");
            Console.WriteLine("* Выполнил: Ломакин Владислав Игоревич | ИИПб-23-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение функции Y      *");
            Console.WriteLine("* с использованием вложенных оператор if-else, где пользователь вводит    *");
            Console.WriteLine("* значение переменной X с клавиатуры. Округлить полученное значение до    *");
            Console.WriteLine("* трех знаков после запятой.                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" y = x - 12x + cosx, если x > 3");
            Console.WriteLine(" y = x - (1 / x), если x = 2");
            Console.WriteLine(" y = x^5 + 10x - (1/sqrt(x+3)), если -6 < x < 1");
            Console.WriteLine(" y = x + 10x - (1/(x^4)), если x < -6");
            Console.WriteLine("P.S. Значения x -6, 1, 3 не предусмотрены условием задачи. Программа на них");
            Console.WriteLine("выведет x = 0.");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите значение X: ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double y = ds.Calculate(x);
            Console.WriteLine(y);
            Console.ReadKey();
        }
    }
}
