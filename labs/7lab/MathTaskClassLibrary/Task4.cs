using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MathTaskClassLibrary
{
    public class Task4
    {
        public bool task4(string input)
        {
            if (input == null)
                throw new ArgumentException();
            Regex r3 = new Regex(@"^\w+([_\-\.]\w+)*@(\w+\.)+[a-zA-Z]{2}$");
            if (r3.IsMatch(input))
                return true;
            else return false;
        }
    }
}
