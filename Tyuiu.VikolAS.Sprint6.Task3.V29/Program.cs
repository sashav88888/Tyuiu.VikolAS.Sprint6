using System;
using Tyuiu.VikolAS.Sprint6.Task3.V29.Lib;

namespace Tyuiu.VikolAS.Sprint6.Task3.V29.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт 6 | Задание 3 | Вариант 29 | Викол А.С.";

            int[,] matrix =
            {
                { -2, -13, -15, -9, -17 },
                { 13, -20, -15, 27, 18 },
                { -12, -1, -20, 13, 0 },
                { 15, 32, 18, -12, -18 },
                { 16, 5, 3, -5, -8 }
            };

            DataService ds = new DataService();
            int[,] sorted = ds.SortMatrix(matrix);

            Console.WriteLine("Матрица после сортировки по 5 столбцу:");

            for (int i = 0; i < sorted.GetLength(0); i++)
            {
                for (int j = 0; j < sorted.GetLength(1); j++)
                {
                    Console.Write(sorted[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
