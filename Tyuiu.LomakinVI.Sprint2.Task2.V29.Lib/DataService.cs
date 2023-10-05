using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.LomakinVI.Sprint2.Task2.V29.Lib
{
    public class DataService : ISprint2Task2V29
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool result = false;


            if (y == 3)
            {
                if ((3 <= x && x <= 5) || (9 <= x && x <= 12))
                {
                    result = true;
                }
            }

            if (y == 4)
            {
                if ((1<=x && x<=5) || (9 <= x && x <= 12))
                {
                    result = true;
                }
            }

            if (y == 5)
            {
                if (1 <= x && x <= 12)
                {
                    result = true;
                }
            }

            if (y == 6)
            {
                if (3 <= x && x <= 13)
                {
                    result = true;
                }
            }

            if (y == 7)
            {
                if (3 <= x && x <= 13)
                {
                    result = true;
                }
            }

            if (y == 8)
            {
                if ((x == 6) || (10 <= x && x <= 13))
                {
                    result = true;
                }
            }

            if (y == 9)
            {
                if ((x == 6) || (10 <= x && x <= 12))
                {
                    result = true;
                }
            }

            if (y == 10)
            {
                if ((x == 6) || (10 <= x && x <= 12))
                {
                    result = true;
                }
            }

            if (y == 11)
            {
                if ((3 <= x && x <= 6) || (10 <= x && x <= 12))
                {
                    result = true;
                }
            }

            if (y == 12)
            {
                if ((4 <= x && x <= 5) || (x == 10))
                {
                    result = true;
                }
            }
            return result;
        }
    }
}
