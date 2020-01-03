using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalcLibrary;

namespace TempLibraryTest
{
    [TestClass]
    public class TempTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            double rad = Calc.RadQ(4);
            Assert.AreEqual(rad, 2);
        }
        [TestMethod]
        public void TestMethod2()
        {
            double rad = Calc.RadQ(-1);
            Assert.AreEqual(rad, double.NaN);
        }
    }
}