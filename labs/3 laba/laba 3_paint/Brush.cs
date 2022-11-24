using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_3_paint
{
    abstract class Brush
    {
        public Color BrushColor { get; set; }
        public int Size { get; set; }
        public Brush(Color brushColor, int size)
        {
            BrushColor = brushColor;
            Size = size;
        }
       public abstract void Draw(Bitmap image, int x , int y);

        protected void _draw(Bitmap image, int x, int y, Color c)
        {
            if (x < image.Width && x >= 0 && y < image.Height && y >= 0)
            {
                image.SetPixel(x, y, c);
            }
        }
    }
}
