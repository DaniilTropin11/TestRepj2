using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_3_paint
{
    class FlowerBrush : Brush
    {
        public FlowerBrush(Color brushColor, int size) : base(brushColor, size) { }
        public override void Draw(Bitmap image, int x, int y)
        {
            int a = 2 * Size;
            double R = 0;
            int y0 = y;
            int x0 = x;
            double t = 0.15;

            for (double n = 0; n < 2 * Math.PI; n += t)
            {

                R = a * Math.Sin(8 * n);
                y0 = (int)(y + Math.Sin(n) * R);
                x0 = (int)(x + Math.Cos(n) * R);

                _draw(image, x0, y0, BrushColor);




            }

        }

    }
}