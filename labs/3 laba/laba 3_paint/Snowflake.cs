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
                for (int x0 = - Size; x0 < Size; ++x0)

                {
                image.SetPixel(x0,x0,BrushColor);
                image.SetPixel(x0,Size-x0,BrushColor);
                }    
                

                    //image.SetPixel(x+1, y+1,  BrushColor );
                    //image.SetPixel(x+2, y+2,  BrushColor );
                    //image.SetPixel(x+3, y+3,  BrushColor );
                    //image.SetPixel(x+4, y+4,  BrushColor );
                    //image.SetPixel(x+5, y+5,  BrushColor );
                    //image.SetPixel(x - 1, y - 1, BrushColor);
                    //image.SetPixel(x - 2, y - 2, BrushColor);
                    //image.SetPixel(x - 3, y - 3, BrushColor);
                    //image.SetPixel(x - 4, y - 4, BrushColor);
                    //image.SetPixel(x - 5, y - 5, BrushColor);
                
                }
                
        }
    }

    