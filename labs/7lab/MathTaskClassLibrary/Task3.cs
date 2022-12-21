using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathTaskClassLibrary
{
    public class Task3
    {
        public bool IsLeapYear(int year)
        {
            if (year < 0 || year == 0)
                throw new ArgumentException();
            else
            {
                if (DateTime.IsLeapYear(year))
                    return true;
                else return false;
            }
        }
    }
}
