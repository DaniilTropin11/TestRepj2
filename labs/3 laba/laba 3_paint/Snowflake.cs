using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_3_paint
{
    class Snowflake : Brush
    {
        public Snowflake(Color brushColor, int size) : base(brushColor, size) { }
        public override void Draw(Bitmap image, int x, int y)
        {
            for (int x0 = x - (int)(Size * 0.7); x0 < x + Size * 0.7; ++x0) // закгругляю косые 
            {
                image.SetPixel(x0, y - x + x0, BrushColor);       // сторона \ 
                image.SetPixel(x0, y + x - x0, BrushColor);       // сторона  /
                
            }
            for (int x0 = x - Size; x0 < x + Size; ++x0)
            {
                image.SetPixel(x0, y, BrushColor);               //  сторона -
                image.SetPixel(x, y - x + x0, BrushColor);        // сторона |
            }

        }


    }
}

    