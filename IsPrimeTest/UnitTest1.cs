using Microsoft.VisualStudio.TestTools.UnitTesting;
using IsPrime;

namespace IsPrimeTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIsPrime_4()
        {
            Assert.AreEqual(false, IsPrime.PrimeNums.IsPrime(4));

        }
        [TestMethod]
        public void TestIsPrime_17()
        {
            Assert.AreEqual(true, IsPrime.PrimeNums.IsPrime(17));

        }
        [TestMethod]
        public void TestIsPrime_99()
        {
            Assert.AreEqual(false, IsPrime.PrimeNums.IsPrime(99));

        }


        [TestMethod]
        public void TestPrimeSum_5()
        {
            Assert.AreEqual(10, IsPrime.PrimeNums.PrimeSum(5));

        }
        [TestMethod]
        public void TestPrimeSum_2()
        {
            Assert.AreEqual(2, IsPrime.PrimeNums.PrimeSum(2));

        }

        [TestMethod]
        public void TestPrimeSum_1()
        {
            Assert.AreEqual(0, IsPrime.PrimeNums.PrimeSum(1));

        }
        [TestMethod]
        public void TestPrimeSum_4()
        {
            Assert.AreEqual(5, IsPrime.PrimeNums.PrimeSum(4));

        }

    }
}
