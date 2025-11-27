using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.VikolAS.Sprint6.Task4.V3.Lib
{
    public class DataService : ISprint6Task4V3
    {
        public List<(double x, double fx)> TabulateFunction(double start, double end, double step)
        {
            var result = new List<(double x, double fx)>();

            for (double x = start; x <= end; x += step)
            {
                double denominator = Math.Sin(x) - 3 + x;

                double fx = Math.Abs(denominator) < 1e-10
                    ? 0
                    : (3 * x - 1.5) / denominator + 2;

                result.Add((x, Math.Round(fx, 2)));
            }

            return result;
        }

        public void SaveToFile(string filePath, List<(double x, double fx)> data)
        {
            using (StreamWriter sw = new StreamWriter(filePath))
                foreach (var item in data)
                    sw.WriteLine($"{item.x.ToString(CultureInfo.InvariantCulture)};{item.fx.ToString(CultureInfo.InvariantCulture)}");
        }

        public double[] GetMassFunction(int startValue, int stopValue)
        {
            throw new NotImplementedException();
        }
    }
}
