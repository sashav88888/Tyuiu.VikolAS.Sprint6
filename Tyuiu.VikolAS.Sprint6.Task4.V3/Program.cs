using System;
using System.Windows.Forms;

namespace Tyuiu.VikolAS.Sprint6.Task4.V3
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}
