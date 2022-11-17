using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_3_paint
{
     class SprayBrush : Brush
    {
        public SprayBrush(Color brushColor, int size) : base(brushColor, size) { }

        public bool DrawEveryTick = true;
        Random random = new Random();

        public override void Draw(Bitmap image, int x, int y)
        {
            for (int y0 = y - Size; y0 < y + Size; ++y0)
            {
                for (int x0 = x - Size; x0 < x + Size; ++x0)
                {
                    if (random.Next(10) == 1)
                        image.SetPixel(x0, y0, BrushColor);
                }
            }
        }
    }
}
