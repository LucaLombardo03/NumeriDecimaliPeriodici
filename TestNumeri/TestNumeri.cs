using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumeriPeriodici;

namespace TestNumeri
{
    [TestClass]
    public class TestNumeri
    {
        [TestMethod]
        public void TestExample1()
        {
            bool a = numeri.Example1();
            Assert.AreEqual(true, a);
        }
        [TestMethod]
        public void TestExample2()
        {
            bool a = numeri.Example2();
            Assert.AreEqual(true, a);
        }
    }
}
