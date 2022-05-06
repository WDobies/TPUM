using Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace DataTests
{
    [TestClass]
    public class DataTests
    {
        private IDataManager dataManager;
        private IProductsBase productsBase;
        [TestMethod]
        public void CreateProductsBase()
        {
            dataManager = IDataManager.Create();
            productsBase = dataManager.ProductsBase;
            Assert.IsNotNull(productsBase);
            Assert.AreEqual(productsBase.Products.Count, 24);
        }
        [TestMethod]
        public void DelteProducts()
        {
            dataManager = IDataManager.Create();
            productsBase = dataManager.ProductsBase;
            productsBase.Products.Clear();
            Assert.AreEqual(productsBase.Products.Count,0);
        }
    }
}
