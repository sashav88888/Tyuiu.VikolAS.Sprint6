using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.VikolAS.Sprint6.Task5.V27.Lib
{
    public class DataService : ISprint6Task5V27
    {
        public double[] LoadFromDataFile(string path)
        {
            List<double> values = new List<double>();

            string text = File.ReadAllText(path);

            string[] parts = text.Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string p in parts)
            {
                // заменяем запятую на точку для корректного парса
                string norm = p.Replace(',', '.');

                if (double.TryParse(norm, System.Globalization.NumberStyles.Float,
                    System.Globalization.CultureInfo.InvariantCulture, out double num))
                {
                    // фильтр: не кратные 5
                    if (num % 5 != 0)
                    {
                        // округление до 3 знаков
                        num = Math.Round(num, 3);
                        values.Add(num);
                    }
                }
            }

            return values.ToArray();
        }
    }
}
