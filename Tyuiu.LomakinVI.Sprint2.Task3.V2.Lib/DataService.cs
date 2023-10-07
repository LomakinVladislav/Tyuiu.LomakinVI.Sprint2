using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.LomakinVI.Sprint2.Task3.V2.Lib
{
    public class DataService : ISprint2Task3V2
    {
        public double Calculate(double x)
        {
            double y = 0;

            if (x > 3)
            {
                y = x - 12 * x + Math.Cos(x);
            }

            else if (x == 2)
            {
                y = x - (1 / x);
            }

            else if ((-6 < x) && (x < 1))
            {
                y = Math.Pow(x, 5) + 10 * x - (1 / Math.Sqrt(x + 3));
            }

            if (x < -6)
            {
                y = x + 10 * x - (1 / (x * x * x * x));
            }

            return Math.Round(y, 3);    
        }
    }
}
