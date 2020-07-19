using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Summer_Practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double concA, concB;
        bool firstPoint = true;

        private void buildAnalyticalGraph()
        {
            for (double time = 0; time <= Convert.ToDouble(numericUpDownTime.Value); time += Convert.ToDouble(numericUpDownTime.Value) / 20)
            {
                concA = Convert.ToDouble(numericUpDownSubA.Value) * Math.Exp((-1)*Convert.ToDouble(numericUpDownSpeedK1.Value)*time);
                graphField.Series[0].Points.AddXY(time, concA);
                concB = (Convert.ToDouble(numericUpDownSubA.Value) - concA) * Math.Exp((-1) * Convert.ToDouble(numericUpDownSpeedK2.Value)*time);
                graphField.Series[1].Points.AddXY(time, concB);
                graphField.Series[2].Points.AddXY(time, Convert.ToDouble(numericUpDownSubA.Value) - concA - concB);
            }    
        }

        private void buildTableAnalytical()
        {
            int currentRow = 0;
            valueTable.RowCount = Convert.ToInt32(numericUpDownTime.Value * 20); 
            valueTable.ColumnCount = 4;

            for (double time = 0; time < Convert.ToDouble(numericUpDownTime.Value); time += Convert.ToDouble(numericUpDownTime.Value) / 20)
            {
                concA = Convert.ToDouble(numericUpDownSubA.Value) * Math.Exp((-1) * Convert.ToDouble(numericUpDownSpeedK1.Value) * time);
                concB = (Convert.ToDouble(numericUpDownSubA.Value) - concA) * Math.Exp((-1) * Convert.ToDouble(numericUpDownSpeedK2.Value) * time);
                
                valueTable.Rows[currentRow].Cells[0].Value = Math.Round(time, 2);
                valueTable.Rows[currentRow].Cells[1].Value = Math.Round(concA, 2);
                valueTable.Rows[currentRow].Cells[2].Value = Math.Round(concB, 2);
                valueTable.Rows[currentRow].Cells[3].Value = Math.Round(Convert.ToDouble(numericUpDownSubA.Value) - concB - concA, 2);
                currentRow++;
            }
        }

        Random pon = new Random();
        Random acc = new Random();

        private double getRandom()
        {
            double accuracy;
            int posOrNeg;
            posOrNeg = pon.Next(1, 2);

            if (Convert.ToInt32(numericUpDownMin.Value) == Convert.ToInt32(numericUpDownMax.Value))
            {
                if (posOrNeg == 1)
                {
                    accuracy = Convert.ToDouble(numericUpDownMax.Value);
                    return accuracy;
                }

                else if (posOrNeg == 2)
                {
                    accuracy = (-1)*Convert.ToDouble(numericUpDownMax.Value);
                    return accuracy;
                }
            }

            accuracy = acc.Next(Convert.ToInt32(numericUpDownMin.Value), Convert.ToInt32(numericUpDownMax.Value));
            return accuracy;
        }

        private void buttonAnalytical_Click(object sender, EventArgs e)
        {
            graphField.Series[0].Points.Clear();
            graphField.Series[1].Points.Clear();
            graphField.Series[2].Points.Clear();
            graphField.Series[3].Points.Clear();
            graphField.Series[4].Points.Clear();
            graphField.Series[5].Points.Clear();
            buildAnalyticalGraph();
            buildTableAnalytical();
        }
    }
}
