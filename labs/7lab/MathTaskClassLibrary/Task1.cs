using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathTaskClassLibrary
{
    public class Task1
    {
        public string task1(int n)
        {
            if (n <= 1 || n >= 26)
                throw new ArgumentException();
            char[] arr = Enumerable.Range(0, n).Select((x, i) => (char)('A' + i)).ToArray();
            return new string(arr);
        }
    }
}
