using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Net.Mime.MediaTypeNames;

namespace Model1VadAnt
{
    public partial class Form1 : Form
    {
        private Distribution distribution;
        public Form1()
        {
            InitializeComponent();
            distribution = new Distribution(0.12345);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            LemerChart.Series[0].Points.Clear();

            int amount = 1024;
            double[] data = distribution.GenerateRandomNumbers(amount);
            int numIntervals = 20;

            double min = 0;
            double max = 1;

            double intervalWidth = (max - min) / numIntervals;
            int[] counts = new int[numIntervals];


            foreach (double value in data)
            {
                int intervalIndex = (int)((value - min) / intervalWidth);


                if (intervalIndex >= 0 && intervalIndex < numIntervals)
                {
                    counts[intervalIndex]++;
                }
                else
                {

                    Console.WriteLine($"Значение {value} вне диапазона."); //Это сообщение будет в выводе Visual Studio.
                }
            }
            for (int i = 0; i < numIntervals; i++)
            {
                double intervalStart = min + i * intervalWidth;
                LemerChart.Series[0].Points.AddXY(intervalStart, counts[i]);  // X - начало интервала, Y - частота
            }
            
            text.Text = SeriesMethod.ScrutiniseSequence(data, amount);
        }

       
    }
}