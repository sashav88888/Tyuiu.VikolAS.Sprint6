using System;
using System.IO;
using Tyuiu.VikolAS.Sprint6.Task7.V27.Lib;

namespace Tyuiu.VikolAS.Sprint6.Task7.V27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #6 | Task7 | Вариант 27 | Викол А.С.";

            Console.WriteLine("************************************************");
            Console.WriteLine("* Спринт 6                                     *");
            Console.WriteLine("* Задание 7                                    *");
            Console.WriteLine("* Вариант 27                                   *");
            Console.WriteLine("* Изменить отрицательные числа 5-й строки     *");
            Console.WriteLine("************************************************\n");

            Console.Write("Введите путь к файлу InPutFileTask7V27.csv: ");
            string path = Console.ReadLine();

            DataService ds = new DataService();

            int[,] matrix = ds.GetMatrix(path);

            Console.WriteLine("\nМатрица после обработки:\n");

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.Write("\nВведите путь для сохранения OutPutFileTask7.csv: ");
            string outPath = Console.ReadLine();

            using (StreamWriter sw = new StreamWriter(outPath))
            {
                for (int i = 0; i < rows; i++)
                {
                    string line = "";
                    for (int j = 0; j < cols; j++)
                    {
                        line += matrix[i, j];
                        if (j < cols - 1) line += ";";
                    }
                    sw.WriteLine(line);
                }
            }

            Console.WriteLine("\nФайл успешно сохранён!");
        }
    }
}
