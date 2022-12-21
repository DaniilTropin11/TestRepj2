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
    public class Task5Test
    {
        [TestMethod]
        public void Task5tMethod1()
        {
            Task5 t = new Task5();
            int actual = t.task5("55555");
            int expected = 25;
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Task5tMethod2()
        {
            bool catched = false;
            Task5 t = new Task5();
            try
            {
                int value = Convert.ToInt32(t.task5("gg"));

            }
            catch (ArgumentException e)
            {
                catched = true;
            }
            Assert.IsTrue(catched, "не обработаны недопустимые данные");
        }
    }
}
