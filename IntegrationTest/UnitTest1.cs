using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleTest;

namespace IntegrationTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void WordSort()
        {        
            Assert.AreEqual("Boom Zoom", Sorter.CalculateTotal("Zoom Boom"));
        }

        [TestMethod]
        public void CaseSort()
        {        
            Assert.AreEqual("Boom boom", Sorter.CalculateTotal("boom Boom"));
        }

         [TestMethod]
        public void RemoveInvalidChars()
        {        
            Assert.AreEqual("b b", Sorter.CalculateTotal("b, b"));
        }

        [TestMethod]
        public void SimpleTest1()
        {        
            Assert.AreEqual("baby Go go", Sorter.CalculateTotal("Go baby, go"));
        }

        [TestMethod]
        public void SimpleTest2()
        {
            Assert.AreEqual("ABC aBc abc CBA CBA cba", Sorter.CalculateTotal("CBA, abc aBc ABC cba CBA."));
        }
    }
}