using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.LomakinVI.Sprint2.Task6.V9.Lib
{
    public class DataService : ISprint2Task6V9
    {
        public string FindDateOfNextDay(int m, int n)
        {
            int resultDay = 0;
            int resultMonth;

            if ((m == 1) || (m == 3) || (m == 5) || (m == 7) || (m == 8) || (m == 10) || (m == 12))
            {
                switch (n)
                    
                {
                    case 31: resultDay = 1; break;
                    default: resultDay = n + 1; break;
                }
            }
            if (m == 4 || m == 6 || m == 9 || m == 11)
            {
                switch (n)
                {
                    case 30: resultDay = 1; break;
                    default: resultDay = n + 1; break;
                }
            }
            if (m == 2)
            {
                switch (n)
                {
                    case 28: resultDay = 1; break;
                    default: resultDay = n + 1; break;
                }
            }

            switch (resultDay)
            {
                case 1: resultMonth = m + 1; break;
                default: resultMonth = m; break;
            }

            string resultMonthFinal;
            switch (resultMonth)
            {
                case 1: resultMonthFinal = "Январь"; break;
                case 2: resultMonthFinal = "Февраль"; break;
                case 3: resultMonthFinal = "Март"; break;
                case 4: resultMonthFinal = "Апрель"; break;
                case 5: resultMonthFinal = "Май"; break;
                case 6: resultMonthFinal = "Июнь"; break;
                case 7: resultMonthFinal = "Июль"; break;
                case 8: resultMonthFinal = "Август"; break;
                case 9: resultMonthFinal = "Сентябрь"; break;
                case 10: resultMonthFinal = "Октябрь"; break;
                case 11: resultMonthFinal = "Ноябрь"; break;
                case 12: resultMonthFinal = "Декабрь"; break;

                default:
                    throw new ArgumentException($"Месяц должен быть от 1 до 12. Введенное значение {n}");
            }
            Console.WriteLine("Следующим днём будет: ");
            string resultDate = $"Месяц: {resultMonthFinal}\nДата: {resultDay}";
            return resultDate;
        }
    }
}
