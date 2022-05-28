using Microsoft.VisualStudio.TestTools.UnitTesting;
using ServerData;

namespace ServerDataTEST
{
    [TestClass]
    public class ServerDataTEST
    {
        [TestMethod]
        public void CreateSmartphone()
        {
            Smartphone smartphone = new Smartphone("Sss", 200, 5, ProductType.Smartphone, 4000, 8);
            Assert.IsNotNull(smartphone);
            Assert.AreEqual("Sss", smartphone.Name);
        }
        [TestMethod]
        public void CreateLaptop()
        {
            Laptop laptop = new Laptop("Laptop 03", 4000, 6, ProductType.Laptop, 64, 4);
            Assert.IsNotNull(laptop);
            Assert.AreEqual("Laptop 03", laptop.Name);
        }
        [TestMethod]
        public void CreateAccessories()
        {
            Accessories ac = new Accessories("Accessories 03", 60, 1, ProductType.Accessories, "XYZ");
            Assert.IsNotNull(ac);
            Assert.AreEqual("Accessories 03", ac.Name);
        }

        [TestMethod]
        public void CreateServerDataManager()
        {
            IServerDataManager serverData = IServerDataManager.Create();

            Assert.AreEqual(9, serverData.ProductsBase.Products.Count);
              
        }
    }
}
