using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathTaskClassLibrary
{
    public class Task5
    {
        public int task5(string numberStr)
        {
            bool IsDigit = numberStr.Length == numberStr.Where(c => char.IsDigit(c)).Count();
            if (!IsDigit)
                throw new ArgumentException();
            int number = int.Parse(numberStr);
            int sum = 0;
            while (number > 0)
            {

                sum = sum + number % 10;
                number = number / 10;

            }
            return sum;
        }
    }
}
