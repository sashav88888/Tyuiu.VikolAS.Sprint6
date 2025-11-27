using System;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.VikolAS.Sprint6.Task2.V19.Lib
{
    public class DataService : ISprint6Task2V19
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int size = stopValue - startValue + 1;
            double[] result = new double[size];

            int index = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                double fx = 0;
                try
                {
                    // Проверка деления на ноль
                    double denominator = x + 1.7;
                    double firstPart = Math.Abs(denominator) < 1e-10 ? 0 : Math.Sin(x) / denominator;

                    // Полная функция
                    fx = firstPart - Math.Cos(x) * 4 * x - 6;

                    fx = Math.Round(fx, 2); // округляем до двух знаков
                }
                catch
                {
                    fx = 0;
                }

                result[index++] = fx;
            }

            return result;
        }
    }
}
