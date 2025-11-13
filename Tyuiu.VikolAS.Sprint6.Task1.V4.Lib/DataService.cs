using System;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.VikolAS.Sprint6.Task1.V4.Lib
{
    public class DataService : ISprint6Task1V4
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] result = new double[len];

            int index = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                double y;

                // Проверка деления на ноль
                if (x + 1.2 == 0)
                {
                    y = 0;
                }
                else
                {
                    y = (Math.Sin(x) / (x + 1.2)) - (Math.Sin(x) * 2) - (2 * x);
                }

                result[index] = Math.Round(y, 2);
                index++;
            }

            return result;
        }
    }
}
