using System;
using System.Windows.Forms;
using Tyuiu.VikolAS.Sprint6.Task2.V19.Lib;

namespace Tyuiu.VikolAS.Sprint6.Task2.V19.App
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // Красивый заголовок в консоли
            Console.Title = "Спринт #6 | Выполнил: Викол А.С. | ИСПб-25-1";
            Console.WriteLine("************************************************");
            Console.WriteLine("* Спринт #6                                   *");
            Console.WriteLine("* Тема: Табулирование функции                 *");
            Console.WriteLine("* Задание #1                                  *");
            Console.WriteLine("* Вариант #19                                 *");
            Console.WriteLine("* Выполнил: Викол А.С. | ИСПб-25-1           *");
            Console.WriteLine("************************************************");
            Console.WriteLine();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Создаем форму с DataGridView
            Form form = new Form
            {
                Text = "Таблица функции F(x)"
            };

            DataGridView dgv = new DataGridView
            {
                Dock = DockStyle.Fill,
                ColumnCount = 2,
                ReadOnly = true,
                AllowUserToAddRows = false
            };
            dgv.Columns[0].Name = "x";
            dgv.Columns[1].Name = "F(x)";
            form.Controls.Add(dgv);

            // Заполняем DataGridView
            DataService service = new DataService();
            double[] results = service.GetMassFunction(-5, 5);

            int index = 0;
            for (int x = -5; x <= 5; x++)
            {
                dgv.Rows.Add(x, results[index]);
                index++;
            }

            Application.Run(form);
        }
    }
}
