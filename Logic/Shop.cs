using Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Logic
{
    public abstract class IShop
    {
        public abstract List<IProduct> GetAllProducts();
        public abstract List<IProduct> GetProductsOfType(int type);
        public abstract List<IProduct> GetAllLaptops();
        public abstract List<IProduct> GetAllSmartphones();
        public abstract List<IProduct> GetAllAccessories();
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

        public override List<IProduct> GetAllProducts()
        {
            List<IProduct> products = new List<IProduct>();
            foreach (Data.IProduct item in productsBase.Products)
            {
                products.Add(new Product(item.Name, item.Price, item.Count, item.ID, item.Description));
            }
            return products;
        }

        public override List<IProduct> GetProductsOfType(int type)
        {
            List<IProduct> products = new List<IProduct>();
            foreach (Data.IProduct item in productsBase.Products)
            {
                if((int) item.Type == type) 
                {
                    products.Add(new Product(item.Name, item.Price, item.Count, item.ID, item.Description));
                }
            }
            return products;
        }
        public override List<IProduct> GetAllLaptops()
        {
            List<IProduct> products = new List<IProduct>();
            foreach (Data.IProduct item in productsBase.Products)
            {
                if(item.Type == ProductType.Laptop) 
                {
                    products.Add(new Product(item.Name, item.Price, item.Count, item.ID, item.Description));
                }
            }
            return products;
        }

        public override List<IProduct> GetAllSmartphones()
        {
            List<IProduct> products = new List<IProduct>();
            foreach (Data.IProduct item in productsBase.Products)
            {
                if (item.Type == ProductType.Smartphone)
                {
                    products.Add(new Product(item.Name, item.Price, item.Count, item.ID, item.Description));
                }
            }
            return products;
        }

        public override List<IProduct> GetAllAccessories()
        {
            List<IProduct> products = new List<IProduct>();
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
            Data.IProduct product = productsBase.Products.FirstOrDefault(x => x.ID == id);

            if (product.Count <= 0)
                return false;

            product.Count--;
            EventHandler<CountChangedEventArgs> handler = CountChanged;
            handler?.Invoke(this, new CountChangedEventArgs(id, product.Count));
            return true;
        }
    }
}
