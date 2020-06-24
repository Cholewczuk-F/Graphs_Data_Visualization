using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lista_4zad3
{
    public partial class Form1 : Form
    {
        private double A;
        private double B;
        public Form1()
        {



            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (A != 0 || B != 0)
            {
                var v1 = functiontwo(-5);
                var v2 = functiontwo(5);
                var v3 = functiontwo(0);

                if (v1 < v2) chartArea.ChartAreas[0].AxisY.ScaleView.Zoom(v1, v2);
                else chartArea.ChartAreas[0].AxisY.ScaleView.Zoom(v2, v1);


                chartArea.ChartAreas[0].AxisX.Title = "X";
                chartArea.ChartAreas[0].AxisY.Title = "Y";
                chartArea.ChartAreas[0].AxisX.ScaleView.Zoom(-6, 6);
                chartArea.ChartAreas[0].CursorX.IsUserEnabled = true;
                chartArea.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
                chartArea.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
                //chartArea.Legends[0].Name = "y=a*x+b";

                chartArea.Series[0].LabelToolTip = "y=a*x+b";
                chartArea.Series[0].Name = "y=a*x+b";


                for (int i = -5; i < 6; i++)
                {
                    chartArea.Series[0].Points.AddXY(i, functionone(i));

                    chartArea.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                    chartArea.Series[0].Points[i + 5].Label = chartArea.Series[0].Points[i + 5].XValue.ToString() + ";" + functionone(i).ToString();

                }


            }
            else
            {
                MessageBox.Show("A i B nie maja prawidlowych wartosci");
            }
        }

        private double functiontwo(double x)
        {
            return A * x + B;
        }
        private double functionone(double x)
        {
            return A * (x * x);
        }
        private void SeccondFButton_Click(object sender, EventArgs e)
        {
            if (A != 0 || B != 0)
            {
                var v1 = functiontwo(-5);
                var v2 = functiontwo(5);
                var v3 = functiontwo(0);

                if (v1 < v2) chartArea.ChartAreas[0].AxisY.ScaleView.Zoom(v1, v2);
                else chartArea.ChartAreas[0].AxisY.ScaleView.Zoom(v2, v1);


                chartArea.ChartAreas[0].AxisX.Title = "X";
                chartArea.ChartAreas[0].AxisY.Title = "Y";
                chartArea.ChartAreas[0].AxisX.ScaleView.Zoom(-6, 6);
                chartArea.ChartAreas[0].CursorX.IsUserEnabled = true;
                chartArea.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
                chartArea.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
                //chartArea.Legends[0].Name = "y=a*x+b";

                chartArea.Series[0].LabelToolTip = "y=a*x+b";
                chartArea.Series[0].Name = "y=a*x+b";


                for (int i = -5; i < 6; i++)
                {
                    chartArea.Series[0].Points.AddXY(i, functiontwo(i));

                    chartArea.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                    chartArea.Series[0].Points[i + 5].Label = chartArea.Series[0].Points[i + 5].XValue.ToString() + ";" + functiontwo(i).ToString();

                }
                

            }
            else
            {
                MessageBox.Show("A i B nie maja prawidlowych wartosci");
            }
        }

        private void BTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AddA_Click(object sender, EventArgs e)
        {
            double result;
            if (Double.TryParse(ATextBox.Text, out result))
            {
                A = result;
                ATextBox.Text = A.ToString();
                MessageBox.Show("Poprawnie dodano zmienną");
                ALabel.Text = "A:" + A.ToString();
            }
            else
            {
                A = 0;
                ATextBox.Text = "";
                MessageBox.Show("Nieprawidłowe dane");
                ALabel.Text = "A:";
            }
        }

        private void AddB_Click(object sender, EventArgs e)
        {
            double result;
            if (Double.TryParse(ATextBox.Text, out result))
            {
                B = result;
                BTextBox.Text = B.ToString();
                MessageBox.Show("Poprawnie dodano zmienna");
                BLabel.Text = "B:" + B.ToString();
            }
            else
            {
                B = 0;
                ATextBox.Text = "";
                MessageBox.Show("Nieprawidłowe dane");
                BLabel.Text = "B:";
            }
        }
    }
}
