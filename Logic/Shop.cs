using Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Logic
{
    public abstract class IShop
    {
        public abstract List<Product> GetAllProducts();
        public abstract List<Product> GetProductsOfType(int type);
        public abstract List<Product> GetAllLaptops();
        public abstract List<Product> GetAllSmartphones();
        public abstract List<Product> GetAllAccessories();
        public abstract bool Buy(Guid id);
        public abstract event EventHandler<CountChangedEventArgs> CountChanged;

    }
    public class Shop: IShop
    {
        private IDataManager dataManager;
        private IProductsBase productsBase;


        public Shop()
        {
            this.dataManager = IDataManager.Create();
            this.productsBase = dataManager.ProductsBase;
        }

        public override List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();
            foreach (Data.IProduct item in productsBase.Products)
            {
                products.Add(new Product(item.Name, item.Price, item.Count, item.ID, item.Description));
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
                    products.Add(new Product(item.Name, item.Price, item.Count, item.ID, item.Description));
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
                    products.Add(new Product(item.Name, item.Price, item.Count, item.ID, item.Description));
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
                    products.Add(new Product(item.Name, item.Price, item.Count, item.ID, item.Description));
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
                    products.Add(new Product(item.Name, item.Price, item.Count, item.ID, item.Description));
                }
            }
            return products;
        }

        public override event EventHandler<CountChangedEventArgs> CountChanged;

        public override bool Buy(Guid id)
        {
            IProduct product = productsBase.Products.FirstOrDefault(x => x.ID == id);

            if (product.Count <= 0)
                return false;
                
            EventHandler<CountChangedEventArgs> handler = CountChanged;
            handler?.Invoke(this, new CountChangedEventArgs(id, product.Count));
            return true;
        }
    }
}
