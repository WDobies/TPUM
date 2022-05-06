using Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Logicktests
{
    [TestClass]
    public class LogicTests
    {
        private IShop shop;
        private ILogicManager logic;
        [TestMethod]
        public void CreateShop()
        {
            logic = ILogicManager.Create();
            shop = logic.Shop;
            Assert.IsNotNull(shop);
        }

        [TestMethod]
        public void GetLaptops()
        {
            logic = ILogicManager.Create();
            shop = logic.Shop;

            foreach (var item in shop.GetProductsOfType(0))
            {
                string str = item.Name.Substring(0, 6);
                Assert.AreEqual(str, "Laptop");
            }

        }
        [TestMethod]
        public void GetSmartphone()
        {
            logic = ILogicManager.Create();
            shop = logic.Shop;

            foreach (var item in shop.GetProductsOfType(1))
            {
                string str = item.Name.Substring(0, 10);
                Assert.AreEqual(str, "Smartphone");
            }

        }
        [TestMethod]
        public void GetAccessories()
        {
            logic = ILogicManager.Create();
            shop = logic.Shop;

            foreach (var item in shop.GetProductsOfType(2))
            {
                string str = item.Name.Substring(0, 11);
                Assert.AreEqual(str, "Accessories");
            }

        }
    }
}
