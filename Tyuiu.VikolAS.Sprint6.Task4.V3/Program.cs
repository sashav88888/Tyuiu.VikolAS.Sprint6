using System;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Tyuiu.VikolAS.Sprint6.Task4.V3.App
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm()); // здесь просто запускаем форму
        }
    }
}
