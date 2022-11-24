using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace laba_3_paint
{
    public partial class Form1 : Form
    {
        bool SaveImage()
        {
            SaveForm saveForm = new SaveForm(FileName, pictureBox1.Image);
            saveForm.ShowDialog();
            return saveForm.Saved;
        }
        Color DefaultColor
        {
            get { return Color.White; }
        }
        int _x;
        int _y;
        bool _mouseClicked = false;
        string FileName = "newFile.jpeg";
        Image BackUpImage;
        

        Color SelectedColor
        {
            get { return colorDialog1.Color; }
        }
        int SelectedSize
        {
            get { return begunok.Value; }
        }
        Brush _selectedBrush;
        
        
         


        public Form1()
        {
            InitializeComponent();
            CreateBlank(2000, 1000);
        }
        void CreateBlank(int width, int height)
        {
            var oldImage = pictureBox1.Image;
            var bmp = new Bitmap(width, height, System.Drawing.Imaging.PixelFormat.Format24bppRgb); 
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    bmp.SetPixel(i, j, DefaultColor);
                }
            }
            pictureBox1.Image = bmp;
            if (oldImage != null)
            {
                oldImage.Dispose();
            }
            pictureBox1.Refresh();

        }



        private void button1_Click(object sender, EventArgs e)
        {
            _selectedBrush = new QuadBrush(SelectedColor, SelectedSize);
            
        }
        
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (_selectedBrush == null) { return; }
            _selectedBrush.Draw(pictureBox1.Image as Bitmap, _x, _y);
            pictureBox1.Refresh(); 
            _mouseClicked = true;
        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            _mouseClicked = false;
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            _x = e.X > 0 ? e.X : 0;
            _y = e.Y > 0 ? e.Y : 0;
            if (_mouseClicked)
            {
                _selectedBrush.Draw(pictureBox1.Image as Bitmap, _x, _y);
                pictureBox1.Refresh();
            }
            this.Text = $"X = {e.X}, Y = {e.Y}";
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "JPG(*.JPG)|*.jpg)";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (pictureBox1.Image == null)
                {
                    pictureBox1.Image.Save(saveFileDialog1.FileName);
                }
            }

        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            var result = MessageBox.Show("Сохранить изображение перед созданием нового?", "Внимание",
                         MessageBoxButtons.YesNoCancel,
                         MessageBoxIcon.Question);
            switch (result)
            {
                case DialogResult.Yes:
                    if (SaveImage())
                    {
                        NewFileForm newFileForm = new NewFileForm();
                        newFileForm.ShowDialog();
                        if (!newFileForm.Canceled)
                        {
                            CreateBlank(newFileForm.W, newFileForm.H);
                            FileName = newFileForm.FileName;
                        }
                    }
                    break;
                case DialogResult.No:
                    NewFileForm form = new NewFileForm();
                    form.ShowDialog();
                    if (!form.Canceled)
                    {
                        CreateBlank(form.W, form.H);
                        FileName = form.FileName;
                    }
                    break;
                case DialogResult.None:
                case DialogResult.Cancel:
                    break;
                default:
                    break;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
             
                button3.BackColor = colorDialog1.Color;

            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Сохранить изображение перед выходом?", "Внимание",
                          MessageBoxButtons.YesNoCancel,
                          MessageBoxIcon.Question);
            switch (result)
            {
                case DialogResult.Yes:
                    if (SaveImage())
                    {
                        Application.Exit();
                    }
                    break;
                case DialogResult.No:
                    
                    Application.Exit();
                    break;
                default:
                    break;
            }
        }
        void RefreshBrush()
        {
            if (_selectedBrush != null)
            {
                _selectedBrush.Size = begunok.Value; // данная проверка предотвращает затык при задании размера кисти 
            }

        }

        private void begunok_Scroll(object sender, EventArgs e)
        {
            RefreshBrush();
            
        }
        // создаю н-ое кол-во цветных кнопочек для красоты , так же есть палитра, у неё в свойствах изменен фон, она отличается 
        private void button2_Click(object sender, EventArgs e)
        {
            _selectedBrush = new CircleBrush(SelectedColor, SelectedSize);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _selectedBrush = new EraseBrush(SelectedColor, SelectedSize);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            _selectedBrush = new CellBrush(SelectedColor, SelectedSize);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            _selectedBrush = new SprayBrush (SelectedColor, SelectedSize);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            _selectedBrush.BrushColor = Color.Red;
            
            

        }

        private void button8_Click(object sender, EventArgs e)
        {
            _selectedBrush.BrushColor = Color.Green;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            _selectedBrush.BrushColor = Color.Blue;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            _selectedBrush.BrushColor = Color.Yellow;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            _selectedBrush.BrushColor = Color.Black;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e) // стираю при помощи функции createblank по заданным координатам или как это называется вообщем heigh b weigh 
        {

            CreateBlank(2000, 1000); 
            

        }

        // смотрел как работает вставка картинок в форме InfoProgram.cs
        //private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    InfoProgram ip = new InfoProgram();
        //    ip.ShowDialog();
        //}

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            _selectedBrush = new Snowflake(SelectedColor, SelectedSize);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
        }
    }
   
}

