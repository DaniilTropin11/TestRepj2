using MathTaskClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    [TestClass]
    public class Task2Test
    {
        [TestMethod]
        public void Task2Method()
        {
            Task2 t = new Task2();
            double[] actual = t.task2(3.4, 5.5, 2.2);
            double[] expect = { -0.45, -3.47 };
            Assert.AreEqual(actual[0], expect[0], 2);
        }
    }
}
