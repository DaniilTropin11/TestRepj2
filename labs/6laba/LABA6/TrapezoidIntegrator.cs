using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LABA6
{
    public class TrapezoidIntegrator : BaseIntegrator //Метод трапеций
    {
        public TrapezoidIntegrator()
        {

        }

        public override double Integrate(Equation equation, double x1, double x2, int N = 100)
        {
            if (equation == null)
            {
                throw new ArgumentNullException();
            }
            if (x1 >= x2)
            {
                throw new ArgumentException("Правая граница интегирования должны быть больше левой!");
            }
            double h = (x2 - x1) / N;   // (Ширина области)/(разбиение) = ширина 1 интервала разбиения
            double sum = 0;


            double sumf = ((equation.GetValue(x1 * h) + equation.GetValue(x2 * h)) ) / 2;


            for (int i = 1; i < N; i++)
            {

                var res = equation.GetValue(x1 + i * h) ;
                sum += (Double.IsNaN(res) ? 0 : res);
            }
            return  h*(sum + sumf);

        }
        public override string ToString()
        {
            return "Интегратор методом трапеций";
        }
    }
}
