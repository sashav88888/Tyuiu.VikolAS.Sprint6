using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace Tyuiu.VikolAS.Sprint6.Task4.V3.Lib
{
    public class DataService
    {
        public List<(double x, double fx)> TabulateFunction(double start, double end, double step)
        {
            var result = new List<(double x, double fx)>();

            for (double x = start; x <= end; x += step)
            {
                double fx;

                double denominator = Math.Sin(x) - 3 + x;
                if (Math.Abs(denominator) < 1e-10)
                    fx = 0; // проверка деления на ноль
                else
                    fx = (3 * x - 1.5) / denominator + 2;

                fx = Math.Round(fx, 2);
                result.Add((x, fx));
            }

            return result;
        }

        public void SaveToFile(string filePath, List<(double x, double fx)> data)
        {
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                foreach (var item in data)
                {
                    sw.WriteLine($"{item.x.ToString(CultureInfo.InvariantCulture)};{item.fx.ToString(CultureInfo.InvariantCulture)}");
                }
            }
        }
    }
}
