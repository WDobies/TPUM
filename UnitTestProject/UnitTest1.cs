using Microsoft.VisualStudio.TestTools.UnitTesting;
using TPUM;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(6, Program.GetSix());
        }
    }
}
