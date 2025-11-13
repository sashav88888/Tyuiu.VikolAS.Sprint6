using System;
using Tyuiu.VikolAS.Sprint6.Task1.V4.Lib;

namespace Tyuiu.VikolAS.Sprint6.Task1.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #6 | Выполнил: Викол А.С. | ИСПб-25-1";
            Console.WriteLine("************************************************");
            Console.WriteLine("* Спринт #6                                   *");
            Console.WriteLine("* Тема: Табулирование функции                 *");
            Console.WriteLine("* Задание #1                                  *");
            Console.WriteLine("* Вариант #4                                  *");
            Console.WriteLine("* Выполнил: Викол А.С. | ИСПб-25-1           *");
            Console.WriteLine("************************************************");
            Console.WriteLine();

            DataService ds = new DataService();

            int start = -5;
            int end = 5;
            double[] results = ds.GetMassFunction(start, end);

            Console.WriteLine(" x\tF(x)");
            for (int i = 0; i < results.Length; i++)
            {
                Console.WriteLine($"{start + i}\t{results[i]:F2}");
            }

            Console.ReadKey();
        }
    }
}
