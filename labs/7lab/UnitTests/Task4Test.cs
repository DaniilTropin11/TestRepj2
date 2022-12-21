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
    public class Task4Test
    {
        [TestMethod]
        public void Task4Method()
        {
            Task4 t = new Task4();
            bool actual = t.task4("test@test.ru");
            bool expected = true;
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Task4Method1()
        {

            Task4 t = new Task4();
            bool actual = t.task4("testtest.ru");
            bool expected = false;
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void Task4Method2()
        {

            Task4 t = new Task4();
            Assert.ThrowsException<ArgumentException>(() => t.task4(null));
        }
    }
}
