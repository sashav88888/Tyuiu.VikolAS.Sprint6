using Tyuiu.VikolAS.Sprint6.Task6.V6.Lib;

namespace Tyuiu.VikolAS.Sprint6.Task6.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт 6 | Task 6 | Вариант 6 | Викол А.С.";

            Console.WriteLine("***********************************************");
            Console.WriteLine("* Спринт 6                                     *");
            Console.WriteLine("* Задание 6                                    *");
            Console.WriteLine("* Вариант 6                                    *");
            Console.WriteLine("* Поиск слов, содержащих букву b/B            *");
            Console.WriteLine("***********************************************");
            Console.WriteLine();

            Console.Write("Введите путь к файлу: ");
            string path = Console.ReadLine();

            DataService ds = new DataService();

            try
            {
                string result = ds.CollectTextFromFile(path);

                Console.WriteLine("\nСлова содержащие 'b' или 'B':");
                Console.WriteLine(result);

            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nОшибка: {ex.Message}");
            }

            Console.WriteLine("\nРабота завершена.");
        }
    }
}
