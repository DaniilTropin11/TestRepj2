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
    public class Task1Test
    {
        [TestMethod]
        public void Task1Method()
        {
            Task1 t = new Task1();
            string expected = "ABCDE";
            string actual = t.task1(5);
            Assert.AreEqual(expected, actual);
        }
    }
}
