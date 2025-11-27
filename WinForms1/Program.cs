using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.VikolAS.Sprint6.Task4.V3.Lib;

namespace Tyuiu.VikolAS.Sprint6.Task4.V3.App
{
    public class MainForm : Form
    {
        private TextBox textBox;
        private Button btnCalculate;
        private Button btnSave;
        private Chart chart;
        private DataService dataService;
        private List<(double x, double fx)> lastResult;

        public MainForm()
        {
            dataService = new DataService();
            lastResult = new List<(double x, double fx)>();
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Text = "Табулирование F(x)";
            this.Size = new Size(800, 600);

            textBox = new TextBox
            {
                Multiline = true,
                ScrollBars = ScrollBars.Vertical,
                Location = new Point(20, 20),
                Size = new Size(300, 400)
            };

            btnCalculate = new Button
            {
                Text = "Вычислить",
                Location = new Point(20, 430)
            };
            btnCalculate.Click += BtnCalculate_Click;

            btnSave = new Button
            {
                Text = "Сохранить в файл",
                Location = new Point(150, 430)
            };
            btnSave.Click += BtnSave_Click;

            chart = new Chart
            {
                Location = new Point(350, 20),
                Size = new Size(400, 400)
            };
            chart.ChartAreas.Add(new ChartArea("MainArea"));
            chart.Series.Add(new Series("F(x)")
            {
                ChartType = SeriesChartType.Line,
                XValueType = ChartValueType.Double,
                YValueType = ChartValueType.Double
            });

            this.Controls.Add(textBox);
            this.Controls.Add(btnCalculate);
            this.Controls.Add(btnSave);
            this.Controls.Add(chart);
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            lastResult = dataService.TabulateFunction(-5, 5, 1);
            textBox.Clear();
            chart.Series["F(x)"].Points.Clear();

            foreach (var item in lastResult)
            {
                textBox.AppendText($"x = {item.x}, F(x) = {item.fx}\r\n");
                chart.Series["F(x)"].Points.AddXY(item.x, item.fx);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (lastResult.Count == 0)
            {
                MessageBox.Show("Сначала выполните вычисление!");
                return;
            }

            string path = "OutPutFileTask4V3.txt";
            dataService.SaveToFile(path, lastResult);
            MessageBox.Show($"Данные сохранены в {path}");
        }
    }
}
