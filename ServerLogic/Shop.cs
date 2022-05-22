using ServerData;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ServerLogic
{
    public abstract class IShop
    {
        public abstract List<IProduct> GetAllProducts();
        public abstract List<IProduct> GetProductsOfType(int type);
        public abstract string ParseAllProductsToXML();
        public abstract bool Buy(Guid id);
        public abstract event EventHandler<CountChangedEventArgs> CountChanged;

    }
    public class Shop: IShop
    {
        private IServerDataManager dataManager;
        private IProductsBase productsBase;


        public Shop()
        {
            this.dataManager = IServerDataManager.Create();
            this.productsBase = dataManager.ProductsBase;
        }

        public override List<IProduct> GetAllProducts()
        {
            List<IProduct> products = new List<IProduct>();
            foreach (ServerData.IProduct item in productsBase.Products)
            {
                products.Add(new Product(item.Name, item.Price, item.Count, item.ID, item.Description));
            }
            return products;
        }

        public override List<IProduct> GetProductsOfType(int type)
        {
            List<IProduct> products = new List<IProduct>();
            foreach (ServerData.IProduct item in productsBase.Products)
            {
                if((int) item.Type == type) 
                {
                    products.Add(new Product(item.Name, item.Price, item.Count, item.ID, item.Description));
                }
            }
            return products;
        }


        public override event EventHandler<CountChangedEventArgs> CountChanged;

        public override bool Buy(Guid id)
        {
            ServerData.IProduct product = productsBase.Products.FirstOrDefault(x => x.ID == id);

            if (product.Count <= 0)
                return false;

            product.Count--;
            EventHandler<CountChangedEventArgs> handler = CountChanged;
            handler?.Invoke(this, new CountChangedEventArgs(id, product.Count));
            return true;
        }

        public override string ParseAllProductsToXML()
        {
            string xml = "";
            Serializer serializer = new Serializer();
            foreach (IProduct item in GetAllProducts())
            {
                ProductXML p = new ProductXML(item.Name, item.Price, item.Count, item.ID, item.Description);
                serializer.products.Add(p);
            }
            xml += serializer.ParseToXML();
            return xml;
        }
    }
}
