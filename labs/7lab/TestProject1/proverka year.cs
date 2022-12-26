using _5laba;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    [TestClass]
    public class proverka_year// по проектам 
    {

        public static IEnumerable<object[]> AdditionData
        {
            get
            {
                return new[]
                {
            new object[] { 0, Activator.CreateInstance(typeof( ArgumentException) },
            new object[] {  8, YearType.LeapYear },
            new object[] { 4, YearType.LeapYear },
            new object[] { 3, YearType.NotLeapYear },
                };
            }
        }


        [TestMethod]
        [DynamicData(nameof(AdditionData))]
        public void TestMethod1(int year, YearType expected)
        {
            if (year < 1)
            {
                Assert.ThrowsException<Exception>(() =>
                {


                });
            }
            else
            {

                YearType actual = Proverka.CheckYear(year);
                Assert.AreEqual(expected, actual, "!=", new object[] { year });
            }

        }

    }
}
