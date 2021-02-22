using Microsoft.VisualStudio.TestTools.UnitTesting;
using Squares;

namespace SquaresTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_AreaOfASquare_0()
        {
            Assert.AreEqual(0, Squares.Program.AreaOfASquare(0));
        }

        [TestMethod]
        public void Test_AreaOfASquare_1()
        {
            Assert.AreEqual(1, Squares.Program.AreaOfASquare(1));
        }

        [TestMethod]
        public void Test_AreaOfASquare_neg1()
        {
            Assert.AreEqual(1, Squares.Program.AreaOfASquare(-1));
        }

        [TestMethod]
        public void Test_AreaOfASquare_neg5()
        {
            Assert.AreEqual(25, Squares.Program.AreaOfASquare(-5));
        }
    }
}
