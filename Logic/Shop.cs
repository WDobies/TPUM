using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public abstract class IShop
    {
        public abstract List<Product> GetAllProducts();
    }

    public class Shop: IShop
    {
        private IProductsBase productsBase;

        Shop(IProductsBase productsBase)
        {
            this.productsBase = productsBase;
        }

        public override List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();
            foreach (Data.IProduct item in productsBase.Products)
            {
                products.Add(new Product(item.Name, item.Price, item.Description));
            }
            return products;
        }
    }
}
