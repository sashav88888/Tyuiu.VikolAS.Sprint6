using Tyuiu.VikolAS.Sprint6.Task5.V27.Lib;

namespace Tyuiu.VikolAS.Sprint6.Task5.V27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт 6 | Task 5 | Вариант 27 | Выполнил: Викол А.С.";

            DataService ds = new DataService();

            string path = "InPutFileTask5V27.txt";

            double[] result = ds.LoadFromDataFile(path);

            Console.WriteLine("Исходные данные (не кратные 5):");

            foreach (double value in result)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine("\nРабота завершена.");
        }
    }
}
