using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba_3_paint
{
    public partial class NewFileForm : Form
    {
        public NewFileForm()
        {
            InitializeComponent();
        }

        public int W
        {
            get
            {
                try
                {
                    int result = Convert.ToInt32(WidthBox.Text);
                    return result;
                }
                catch (OverflowException)
                {
                    return 0; // Не в области
                }
                catch (FormatException)
                {
                    return -1; // Не число
                }
            }
        }
        public int H
        {
            get
            {
                try
                {
                    int result = Convert.ToInt32(HeightBox.Text);
                    return result;
                }
                catch (OverflowException)
                {
                    return 0; // Не в области
                }
                catch (FormatException)
                {
                    return -1; // Не число
                }
            }
        }
        public string FileName
        {
            get
            {
                return NameBox.Text;
            }
        }
        bool _canceled = true;
        public bool Canceled { get { return _canceled; } }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (W == 0 || H == 0)
            {
                MessageBox.Show("Ширина выходит за возможные границы числа", "Некорректные данные", MessageBoxButtons.OK);
                return;
            }
            if (W == -1 || H == -1)
            {
                MessageBox.Show("Не удалось преобразовать размер полотна в числовые значения", "Некорректные данные", MessageBoxButtons.OK);
                return;
            }
            _canceled = false;
            Close();
        }

        private void CancelButton_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
