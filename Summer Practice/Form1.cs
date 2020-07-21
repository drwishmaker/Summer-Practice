using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Summer_Practice
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        double concA, concB, previousConcA, previousConcB;
        bool firstPoint;

        private void buildAnalyticalGraph()
        {
            try
            {
                for (double time = 0; time <= Convert.ToDouble(numericUpDownTime.Value); time += Convert.ToDouble(numericUpDownTime.Value) / 20)
                {
                    concA = Convert.ToDouble(numericUpDownSubA.Value) * Math.Exp((-1) * Convert.ToDouble(numericUpDownSpeedK1.Value) * time);
                    graphField.Series[0].Points.AddXY(time, concA);
                    concB = (Convert.ToDouble(numericUpDownSubA.Value) - concA) * Math.Exp((-1) * Convert.ToDouble(numericUpDownSpeedK2.Value) * time);
                    graphField.Series[1].Points.AddXY(time, concB);
                    graphField.Series[2].Points.AddXY(time, Convert.ToDouble(numericUpDownSubA.Value) - concA - concB);
                }
            }
            catch
            {
                MessageBox.Show("Error", "Please check the entered data");
            }
        }

        private void buildEilerGraph()
        {
            try
            {
                firstPoint = true;
                for (double time = 0; time <= Convert.ToDouble(numericUpDownTime.Value); time += Convert.ToDouble(numericUpDownTime.Value) / 20)
                {
                    if (firstPoint)
                    {
                        concA = Convert.ToDouble(numericUpDownSubA.Value);
                        previousConcA = concA;
                        graphField.Series[0].Points.AddXY(time, concA);
                        graphField.Series[3].Points.AddXY(time, concA + getAccuracy(concA));
                    }

                    else
                    {
                        concA = previousConcA - Convert.ToDouble(numericUpDownStep.Value) * Convert.ToDouble(numericUpDownSpeedK1.Value) * previousConcA;
                        previousConcA = concA;
                        graphField.Series[0].Points.AddXY(time, concA);
                        graphField.Series[3].Points.AddXY(time, concA + getAccuracy(concA));

                    }

                    if (firstPoint)
                    {
                        concB = 0;
                        previousConcB = concB;
                        graphField.Series[1].Points.AddXY(time, concB);
                        graphField.Series[4].Points.AddXY(time, concB + getAccuracy(concA));
                    }

                    else
                    {
                        concB = previousConcB + Convert.ToDouble(numericUpDownStep.Value) * (Convert.ToDouble(numericUpDownSpeedK1.Value) * concA - previousConcB * Convert.ToDouble(numericUpDownSpeedK2.Value));
                        previousConcB = concB;
                        graphField.Series[1].Points.AddXY(time, concB);
                        graphField.Series[4].Points.AddXY(time, concB + getAccuracy(concA));
                    }

                    firstPoint = false;
                    graphField.Series[2].Points.AddXY(time, Convert.ToDouble(numericUpDownSubA.Value) - concA - concB);
                    graphField.Series[5].Points.AddXY(time, Convert.ToDouble(numericUpDownSubA.Value) - concA - concB + getAccuracy(concA));
                }
            }
            catch
            {
                MessageBox.Show("Error", "Please check the entered data");
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

        private void buildTableEiler()
        {
            int currentRow = 0;
            valueTable.RowCount = Convert.ToInt32(numericUpDownTime.Value * 20);
            valueTable.ColumnCount = 4;
            firstPoint = true;
            for (double time = 0; time < Convert.ToDouble(numericUpDownTime.Value); time += Convert.ToDouble(numericUpDownTime.Value) / 20)
            {
                if (firstPoint)
                {
                    concA = Convert.ToDouble(numericUpDownSubA.Value);
                    previousConcA = concA;
                }

                else
                {
                    concA = previousConcA - Convert.ToDouble(numericUpDownStep.Value) * Convert.ToDouble(numericUpDownSpeedK1.Value) * previousConcA;
                    previousConcA = concA;

                }

                if (firstPoint)
                {
                    concB = 0;
                    previousConcB = concB;
                }

                else
                {
                    concB = previousConcB + Convert.ToDouble(numericUpDownStep.Value) * (Convert.ToDouble(numericUpDownSpeedK1.Value) * concA - previousConcB * Convert.ToDouble(numericUpDownSpeedK2.Value));
                    previousConcB = concB;
                }

                firstPoint = false;
                valueTable.Rows[currentRow].Cells[0].Value = Math.Round(time, 2);
                valueTable.Rows[currentRow].Cells[1].Value = Math.Round(concA, 2);
                valueTable.Rows[currentRow].Cells[2].Value = Math.Round(concB, 2);
                valueTable.Rows[currentRow].Cells[3].Value = Math.Round(Convert.ToDouble(numericUpDownSubA.Value) - concB - concA, 2);
                currentRow++;
            }
        }

        

        private double getAccuracy(double concA)
        {
            Random acc = new Random();
            double accuracy = 0;
            accuracy = (concA/100)*acc.Next(Convert.ToInt32(numericUpDownMax.Value) - Convert.ToInt32(numericUpDownMin.Value), Convert.ToInt32(numericUpDownMax.Value));
            return accuracy;
        }

        private void buttonEiler_Click(object sender, EventArgs e)
        {
            graphField.Series[0].Points.Clear();
            graphField.Series[1].Points.Clear();
            graphField.Series[2].Points.Clear();
            graphField.Series[3].Points.Clear();
            graphField.Series[4].Points.Clear();
            graphField.Series[5].Points.Clear();
            buildEilerGraph();
            buildTableEiler();
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
