using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_3_paint
{
    class CircleBrush : Brush
    {
        public CircleBrush(Color brushColor, int size) : base(brushColor, size) { }
        public override void Draw(Bitmap image, int x, int y)
        {
            for (int y0 = y - Size; y0 < y + Size; ++y0)
            {
                for (int x0 = x - Size; x0 < x + Size; ++x0)
                {
                    if ((x0 - x) * (x0 - x) + (y0 - y) * (y0 - y) <= Size * Size)
                    {
                        image.SetPixel(x0, y0, BrushColor);
                    }

                }
            }
        }
    }
}
