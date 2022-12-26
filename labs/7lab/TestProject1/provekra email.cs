using _5laba;
using System.Security.Cryptography.X509Certificates;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1// по проектам 
    {

        public static IEnumerable<object[]> AdditionData
        {
            get
            {
                return new[]
                {
            new object[] { "-------@msil.ti", false },
            new object[] {  "sssssss@mail.ru", true },
            new object[] { "sss#ssss@mail.ru", false },
            new object[] { "ss__fff@mail.ru", true }, 
                };
            }
        }


        [TestMethod]
        [DynamicData(nameof(AdditionData))]
        public void TestMethod1(string email, bool expected)
        {
            bool actual = Proverka.CheckEmail(email);
            Assert.AreEqual(expected, actual, "!=", new object[] {email});
           
        }
       
    }
}