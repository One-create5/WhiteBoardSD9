using Microsoft.VisualStudio.TestTools.UnitTesting;
using Alphabetize;

namespace AlphabetizeTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod_cat()
        {
            Assert.AreEqual("act", SortString.StringSort("cat"));
          
        }

        [TestMethod]
        public void TestMethod_catInTheHat()
        {
            Assert.AreEqual("aaCeHhInTtt", SortString.StringSort("CatInTheHat"));

        }


        [TestMethod]
        public void TestMethod_dog()
        {
            
            Assert.AreEqual("Dgo", SortString.StringSort("Dog"));
          
        }


        [TestMethod]
        public void TestMethod_ANDREW()
        {
            
            Assert.AreEqual("ADENRW", SortString.StringSort("ANDREW"));
        
        }


        [TestMethod]
        public void TestMethod_MSSA()
        {
            
            Assert.AreEqual("AMSS", SortString.StringSort("MSSA"));
        }
    }
}
