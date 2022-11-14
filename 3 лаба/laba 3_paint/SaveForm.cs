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
    public partial class SaveForm : Form
    {
        public SaveForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        public string FileName
        {
            get
            {
                return textBox1.Text;
            }
        }

        bool _canceled = true;
        public bool Canceled { get { return _canceled; } }

        private void OK_button1_Click(object sender, EventArgs e)
        {
            _canceled = false;
            Close();
        }

        private void Cancel_button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
