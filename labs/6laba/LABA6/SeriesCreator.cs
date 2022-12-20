using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace LABA6
{
    internal class SeriesCreator //Создаёт множество точек, которые формируют график
    {
        static public Series Get(Equation equation, double x1, double x2, int quality = 100)
        {
            double CurPoint;
            Series Value = new Series();
            Value.ChartType = SeriesChartType.Line;
            double h = (x2 - x1) / quality;
            for (int i = 0; i < quality; i++)
            {
                CurPoint = x1 + i * h;
                Value.Points.AddXY(CurPoint, equation.GetValue(CurPoint));
            }
            return Value;
        }
    }
}
