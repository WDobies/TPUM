using Data;
using System;
using System.Collections.Generic;

namespace Logic
{
    public abstract class IShop
    {
        public abstract List<Product> GetAllProducts();
        public abstract List<Product> GetProductsOfType(int type);
        public abstract List<Product> GetAllLaptops();
        public abstract List<Product> GetAllSmartphones();
        public abstract List<Product> GetAllAccessories();
        public abstract void Buy(Guid id);
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
            productsBase.CountChanged += OnCountChanged;
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

        private void OnCountChanged(object sender, Data.CountChangedEventArgs e)
        {
            EventHandler<CountChangedEventArgs> handler = CountChanged;
            handler?.Invoke(this, new CountChangedEventArgs(e.ID, e.Value));
        }

        public override void Buy(Guid id)
        {
            productsBase.Buy(id);
        }
    }
}
