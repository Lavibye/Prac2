using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prac2
{
    public partial class File : Form
    {
        public File()
        {
            InitializeComponent();
        }

        private void ProcessCoordinates(double[] xCoordinates, double[] yCoordinates)
        {
            PointCalculator calculator = new PointCalculator();
            FileWriter fileWriter = new FileWriter();
            string outputPath = @"result.txt";

            ArraysAB arrays = new ArraysAB
            {
                X = xCoordinates,
                Y = yCoordinates
            };

            var matchingPoints = calculator.FindPointsWithinSquare(arrays.X, arrays.Y);

            if (matchingPoints.Count > 0)
            {
                labelResult.Text = "Точки, що належать квадрату:";
                labelCoordinates.Text = string.Join(Environment.NewLine, matchingPoints.Select(p => $"({p.x}, {p.y})"));

                // Запис результатів у файл
                fileWriter.WriteArray(outputPath, matchingPoints.SelectMany(p => new[] { p.x, p.y }).ToArray());
            }
            else
            {
                labelResult.Text = "Жодна точка не належить квадрату.";
                labelCoordinates.Text = string.Empty;
            }
        }

        // Кнопка для обробки координат введених вручну
        private void buttonEnterCoordinates_Click(object sender, EventArgs e)
        {
            try
            {
                double[] xCoordinates = textBoxXCoordinates.Text.Split(',').Select(double.Parse).ToArray();
                double[] yCoordinates = textBoxYCoordinates.Text.Split(',').Select(double.Parse).ToArray();

                ProcessCoordinates(xCoordinates, yCoordinates);
            }
            catch (FormatException)
            {
                MessageBox.Show("Переконайтеся, що координати введено правильно і розділено комами.", "Помилка формату");
            }
        }
        // Кнопка для завантаження координат з файлів
        private void buttonLoadFromFile_Click_1(object sender, EventArgs e)
        {
            FileReader fileReader = new FileReader();

            string pathX = @"1.txt";
            string pathY = @"2.txt";

            try
            {
                double[] xCoordinates = fileReader.ReadArray(pathX);
                double[] yCoordinates = fileReader.ReadArray(pathY);

                // Конвертація масивів у строки для відображення в TextBox
                textBoxXCoordinates.Text = String.Join(", ", xCoordinates);
                textBoxYCoordinates.Text = String.Join(", ", yCoordinates);

                // Обробка координат та виведення результатів
                ProcessCoordinates(xCoordinates, yCoordinates);
            }
            catch (Exception ex)
            {
                // Виведення повідомлення про помилку
                MessageBox.Show($"Помилка при читанні файлів: {ex.Message}", "Помилка");
            }
        }
    }
}
