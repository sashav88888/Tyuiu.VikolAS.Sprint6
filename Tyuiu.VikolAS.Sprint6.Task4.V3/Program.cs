using System;
using System.IO;
using Tyuiu.VikolAS.Sprint6.Task4.V3.Lib;

namespace Tyuiu.VikolAS.Sprint6.Task4.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #6 | Задание 4 | Вариант 3 | Выполнил: Викол А.С.";

            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            double[] values = ds.GetMassFunction(startValue, stopValue);

            Console.WriteLine(" Таблица значений функции F(x)");
            Console.WriteLine(" x\tF(x)");
            Console.WriteLine("------------------------");

            int i = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                Console.WriteLine($"{x}\t{values[i]}");
                i++;
            }

            // Сохранение в файл
            string path = "OutPutFileTask4V3.txt";
            File.WriteAllLines(path, Array.ConvertAll(values, v => v.ToString()));

            Console.WriteLine($"\nРезультат сохранён в файл: {path}");
            Console.ReadKey();
        }
    }
}
