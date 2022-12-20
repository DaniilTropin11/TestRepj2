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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LABA6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        void DrawFunction(double x1, double x2, Equation equation, int N = 100)
        {
            chart1.Series.Add(SeriesCreator.Get(equation, x1, x2, N));
        }

        delegate Equation SinDelegate(double a); //Делегаты - это указатели на методы и с помощью делегатов мы можем вызвать данные методы.
        SinDelegate sin = delegate (double a) { return new SinEquation(a); };

        delegate Equation QuadDelegate(double a, double b, double c);
        QuadDelegate quad = delegate (double a, double b, double c) { return new QuadEquation(a, b, c); };

        void Clear()
        {
            chart1.Series.Clear();
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        delegate SinEquation MyDelegate(double a);
        SinEquation GetSinEq(double a) => new SinEquation(a);






        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DrawButton_Click(object sender, EventArgs e)
        {
            if (!checkBox1.Checked && !checkBox2.Checked && !checkBox2.Checked)
            {
                MessageBox.Show("Вы не выбрали тип уравнения!");
                return;
            }

            double a, b, c, x0, x1;
            int N;
            int.TryParse(textBox4.Text, out N);
            if (!Double.TryParse(textBox5.Text, out x0))
            {
                MessageBox.Show("Некорректное значение левой границы!");
                return;
            }
            if (!Double.TryParse(textBox6.Text, out x1))
            {
                MessageBox.Show("Некорректное значение правой границы!");
                return;
            }



            if (!Double.TryParse(textBox1.Text, out a))
            {
                MessageBox.Show("Некорректное значение параметра a!");
                return;
            }
            if (!Double.TryParse(textBox2.Text, out b) && checkBox1.Checked)
            {
                MessageBox.Show("Некорректное значение параметра b!");
                return;
            }
            if (!Double.TryParse(textBox1.Text, out c) && checkBox1.Checked)
            {
                MessageBox.Show("Некорректное значение параметра c!");
                return;
            }

            if (checkBox1.Checked) //Если квадратное уравнение
            {

                DrawFunction(
                    x1: Convert.ToInt32(textBox5.Text),
                    x2: Convert.ToInt32(textBox6.Text),
                    equation: new QuadEquation(
                    a: Convert.ToInt32(textBox1.Text),
                    b: Convert.ToInt32(textBox2.Text),
                    c: Convert.ToInt32(textBox3.Text)),
                    N: Convert.ToInt32(textBox4.Text));

            }
            if (checkBox2.Checked)//Если синусоида
            {
                DrawFunction(
                    x1: Convert.ToInt32(textBox5.Text),
                    x2: Convert.ToInt32(textBox6.Text),
                    equation: new SinEquation(
                    a: Convert.ToInt32(textBox1.Text)),
                    N: Convert.ToInt32(textBox4.Text));

            }
            //Если что-то
            
        }




        private void ClearButton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void RectButton_Click(object sender, EventArgs e)
        {
            int N;

            if (!Int32.TryParse(textBox4.Text, out N))
            {
                MessageBox.Show("Некорректное значение количества разбиений");
                return;

            }
            /////////////////////////////////////
            RectangleIntegrator Intgr = new RectangleIntegrator();
            if (checkBox2.Checked)
            {
                MessageBox.Show($"{Intgr.ToString()}: {Intgr.Integrate(new SinEquation(Convert.ToDouble(textBox1.Text)), Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text), Convert.ToInt32(textBox4.Text))}");
            }
            
            else
            {
                MessageBox.Show($"{Intgr.ToString()}: {Intgr.Integrate(new QuadEquation(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text)), Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text), Convert.ToInt32(textBox4.Text))}");
            }
            /////////////////////////////////////////
        }

        private void TrapezButton_Click(object sender, EventArgs e)
        {

            int N;

            if (!Int32.TryParse(textBox4.Text, out N))
            {
                MessageBox.Show("Некорректное значение количества разбиений");
                return;

            }

            TrapezoidIntegrator Intgr = new TrapezoidIntegrator();
            if (checkBox2.Checked)
            {
                MessageBox.Show($"{Intgr.ToString()}: {Intgr.Integrate(new SinEquation(a: Convert.ToInt32(textBox1.Text)), x1: Convert.ToInt32(textBox5.Text), x2: Convert.ToInt32(textBox6.Text), N: Convert.ToInt32(textBox4.Text))}");
            }
            
            else
            {
                MessageBox.Show($"{Intgr.ToString()}: {Intgr.Integrate(new QuadEquation(a: Convert.ToInt32(textBox1.Text), b: Convert.ToInt32(textBox2.Text), c: Convert.ToInt32(textBox3.Text)), x1: Convert.ToInt32(textBox5.Text), x2: Convert.ToInt32(textBox6.Text), N: Convert.ToInt32(textBox4.Text))}");
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}  


