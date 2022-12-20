using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA6
{
    abstract public class BaseIntegrator
    {
        abstract public double Integrate(Equation eq, double x1, double x2, int N);
        abstract override public string ToString();
    }
}
