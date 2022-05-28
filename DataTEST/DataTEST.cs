using Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace DataTEST
{
    [TestClass]
    public class DataTEST
    {
        [TestMethod]
        public void CreateProduct()
        {
            Product product = new Product("Name", 200, 3, System.Guid.NewGuid(), " descr ....");
            Assert.IsNotNull(product);
            Assert.AreEqual("Name", product.Name);

        }

        [TestMethod]
        public void CreateDataManager()
        {
            IDataManager dataManager = IDataManager.Create();
            List<IProduct> list = dataManager.ProductsBase.Products;

            list.Add(new Product("TESTProduct", 100, 3, System.Guid.NewGuid(), " descr ...."));
            Assert.IsNotNull(list);
        }
    }
}
