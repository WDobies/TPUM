using Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LogicTEST
{
    [TestClass]
    public class LogicTEST
    {
        [TestMethod]
        public void CreateProduct()
        {
            Product product = new Product("Name", 200, 3, System.Guid.NewGuid(), " descr ....");
            Assert.IsNotNull(product);
            Assert.AreEqual("Name", product.Name);
        }
        [TestMethod]
        public void CreateLogickManager()
        {
            ILogicManager logicManager = ILogicManager.Create();
            Assert.IsNotNull(logicManager.Shop);          
        }
        [TestMethod]
        public void ShopTest()
        {
            ILogicManager logicManager = ILogicManager.Create();           
            Assert.AreEqual(logicManager.Shop.GetAllProducts().Count,0);
        }
    }
}
