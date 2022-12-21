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
    public class Task3Test
    {
        [TestMethod]
        public void Task3Method1()
        {
            Task3 t = new Task3();
            bool actual = t.IsLeapYear(1200);
            bool expected = true;
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Task3Method2()
        {
            Task3 t = new Task3();
            bool actual = t.IsLeapYear(1300);
            bool expected = false;
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Task3Method3()
        {
            Task3 t = new Task3();
            Assert.ThrowsException<ArgumentException>(() => t.IsLeapYear(0));
        }
    }
}
