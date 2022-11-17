using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mainpaint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            setsize();
        }
        private bool mouse = false;
        private arrivepoins _arrivepoins = new arrivepoins(2);
        Bitmap map = new Bitmap(100, 100);
        Graphics graphics;
        Pen pen = new Pen(Color.Black, 3f);
        Point firstp = new Point();
       

       
        
        private void setsize() { Rectangle rectangle = Screen.PrimaryScreen.Bounds;

            map = new Bitmap(rectangle.Width, rectangle.Height);
            graphics = Graphics.FromImage(map);
            pen.StartCap= System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap= System.Drawing.Drawing2D.LineCap.Round;
        }

        private class arrivepoins
        {
            int index = 0;
            private Point[] points;
            public arrivepoins(int size) { if (size <= 0) { size = 1; } points = new Point[size]; }
            public void setPoint(int x, int y) { if (index >= points.Length) { index = 0; } points[index] = new Point(x, y); index++; }
            public void ResetPoints() { index = 0; }
            public int getcountpoints() { return index; }
            public Point[] getpoints() { return points; }
           


        }
        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "PNG (*.PNG) | *.png";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (pictureBox1.Image == null) { pictureBox1.Image.Save(saveFileDialog1.FileName); }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            pen.Color = ((Button)sender).BackColor;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pen.Color = ((Button)sender).BackColor;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            mouse = true;
            firstp = e.Location;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            mouse = false;
            _arrivepoins.ResetPoints();
            Graphics gr = pictureBox1.CreateGraphics();
            gr.DrawEllipse(new Pen(Brushes.Red), firstp.X, firstp.Y, e.X - firstp.X, e.Y - firstp.Y);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!mouse) 
            { 
                return; 
            }
            _arrivepoins.setPoint(e.X, e.Y);

            if (_arrivepoins.getcountpoints() >= 2) 
            
            {  graphics.DrawLines(pen, _arrivepoins.getpoints());
                pictureBox1.Image = map;
               _arrivepoins.setPoint(e.X , e.Y);
            }

        }

        private void red_Click(object sender, EventArgs e)
        {
            pen.Color = ((Button)sender).BackColor;
        }

        private void perply_Click(object sender, EventArgs e)
        {
            pen.Color = ((Button)sender).BackColor;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK) { pen.Color = colorDialog1.Color;
                ((Button)sender).BackColor = colorDialog1.Color;
        }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            graphics.Clear(pictureBox1.BackColor);
            pictureBox1.Image = map;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            pen.Width = trackBar1.Value;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Square;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Square;
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }

   
}
