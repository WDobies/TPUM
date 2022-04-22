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
        public abstract List<Product> GetProductsOfType(int type);
        public abstract List<Product> GetAllLaptops();
        public abstract List<Product> GetAllSmartphones();
        public abstract List<Product> GetAllAccessories();
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

        public override List<Product> GetProductsOfType(int type)
        {
            List<Product> products = new List<Product>();
            foreach (Data.IProduct item in productsBase.Products)
            {
                if((int) item.Type == type) 
                {
                    products.Add(new Product(item.Name, item.Price, item.Description));
                }
            }
            return products;
        }
        public override List<Product> GetAllLaptops()
        {
            List<Product> products = new List<Product>();
            foreach (Data.IProduct item in productsBase.Products)
            {
                if(item.Type == ProductType.Laptop) 
                {
                    products.Add(new Product(item.Name, item.Price, item.Description));
                }
            }
            return products;
        }

        public override List<Product> GetAllSmartphones()
        {
            List<Product> products = new List<Product>();
            foreach (Data.IProduct item in productsBase.Products)
            {
                if (item.Type == ProductType.Smartphone)
                {
                    products.Add(new Product(item.Name, item.Price, item.Description));
                }
            }
            return products;
        }

        public override List<Product> GetAllAccessories()
        {
            List<Product> products = new List<Product>();
            foreach (Data.IProduct item in productsBase.Products)
            {
                if (item.Type == ProductType.Accessories)
                {
                    products.Add(new Product(item.Name, item.Price, item.Description));
                }
            }
            return products;
        }
    }
}
