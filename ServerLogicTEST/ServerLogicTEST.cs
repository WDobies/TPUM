using Microsoft.VisualStudio.TestTools.UnitTesting;
using ServerLogic;

namespace ServerLogicTEST
{
    [TestClass]
    public class ServerLogicTEST
    {
        [TestMethod]
        public void CreateProduct()
        {
            Product product = new Product("Product", 200, 3, System.Guid.NewGuid(), " descr ....");
            Assert.AreEqual("Product", product.Name);
        }

        [TestMethod]
        public void CreateSLManager()
        {
            IServerLogicManager serverLogicManager = IServerLogicManager.Create();
            Assert.IsNotNull(serverLogicManager);
        }
    }
}
