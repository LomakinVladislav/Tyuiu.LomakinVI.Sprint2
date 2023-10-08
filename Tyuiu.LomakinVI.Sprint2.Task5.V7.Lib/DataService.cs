using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.LomakinVI.Sprint2.Task5.V7.Lib
{
    public class DataService : ISprint2Task5V7
    {
        public string FindMonthName(int startYear, int n)
        {
            while (n >= 12)
            {
                n -= 12;
            }

            string res;
            switch (n)
            {
                case 0:
                    res = "Январь";
                    break;
                case 1:
                    res = "Февраль";
                    break;
                case 2:
                    res = "Март";
                    break;
                case 3:
                    res = "Апрель";
                    break;
                case 4:
                    res = "Май";
                    break;
                case 5:
                    res = "Июнь";
                    break;
                case 6:
                    res = "Июль";
                    break;
                case 7:
                    res = "Август";
                    break;
                case 8:
                    res = "Сентябрь";
                    break;
                case 9:
                    res = "Октябрь";
                    break;
                case 10:
                    res = "Ноябрь";
                    break;
                case 11:
                    res = "Декабрь";
                    break;

                default:
                    throw new ArgumentException($"Месяц должен быть от 1 до 12. Введенное значение {n}");
            }
            return res;
        }
    }
}
