using System;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.VikolAS.Sprint6.Task4.V3.Lib
{
    public class DataService : ISprint6Task4V3
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] result = new double[len];

            int index = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                double denominator = Math.Sin(x) - 3 + x;
                double y;

                if (Math.Abs(denominator) < 1e-9)
                    y = 0;
                else
                    y = ((3 * x - 1.5) / denominator) + 2;

                result[index] = Math.Round(y, 2);
                index++;
            }

            return result;
        }
    }
}
