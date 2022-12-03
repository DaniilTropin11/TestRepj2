using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_3_paint
{
    class linia : Brush
    {
        public linia(Color brushColor, int size) : base(brushColor, size) { }
        public override void Draw(Bitmap image, int x, int y)
        {
            for (int x0 = x - Size; x0 < x + Size ; ++x0)
            {
                for (int y0 = y - Size; y0 < y + Size; ++y0)
                {
                    

                    _draw(image, x0, y - x + x0, BrushColor);
                    //_draw(image, x0, x - y + x0, BrushColor);
                }
            }
        }
    }
}