using Tyuiu.VikolAS.Sprint6.Task6.V6.Lib;

namespace Tyuiu.VikolAS.Sprint6.Task6.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт 6 | Задание 6 | Вариант 6 | Выполнил: Викол А.С.";

            Console.WriteLine("***************************************************");
            Console.WriteLine("* Спринт 6                                         *");
            Console.WriteLine("* Задание 6                                        *");
            Console.WriteLine("* Вариант 6                                        *");
            Console.WriteLine("* Тема: Чтение файла и обработка текста            *");
            Console.WriteLine("***************************************************");
            Console.WriteLine();

            Console.Write("Введите путь к файлу: ");
            string path = Console.ReadLine();

            DataService ds = new DataService();

            try
            {
                string result = ds.CollectTextFromFile(path);
                Console.WriteLine("\nРезультирующая строка:");
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }

            Console.WriteLine("\nРабота завершена.");
        }
    }
}
