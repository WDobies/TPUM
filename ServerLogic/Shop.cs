using ServerData;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ServerLogic
{
    public abstract class IShop
    {
        public abstract string GetAllProducts();
        public abstract string GetProductsOfType(int type);
        public abstract bool Buy(Guid id);
        public abstract event EventHandler<CountChangedEventArgs> CountChanged;
        public abstract event EventHandler<IncorrectOrderEventArgs> IncorrectOrder;

    }
    public class Shop: IShop, IObserver<ServerData.IProduct>
    {
        private IServerDataManager dataManager;
        private IProductsBase productsBase;

        private IDisposable unsubscriber;

        public Shop()
        {
            this.dataManager = IServerDataManager.Create();
            this.productsBase = dataManager.ProductsBase;
            productsBase.Subscribe(this);
        }

        public override string GetAllProducts()
        {
            List<IProduct> products = new List<IProduct>();
            foreach (ServerData.IProduct item in productsBase.Products)
            {
                products.Add(new Product(item.Name, item.Price, item.Count, item.ID, item.Description));
            }

            return ParseProductsToXML(products);
        }

        public override string GetProductsOfType(int type)
        {
            List<IProduct> products = new List<IProduct>();
            foreach (ServerData.IProduct item in productsBase.Products)
            {
                if((int) item.Type == type) 
                {
                    products.Add(new Product(item.Name, item.Price, item.Count, item.ID, item.Description));
                }
            }

            return ParseProductsToXML(products);
        }


        public override event EventHandler<CountChangedEventArgs> CountChanged;
        public override event EventHandler<IncorrectOrderEventArgs> IncorrectOrder;

        public override bool Buy(Guid id)
        {
            ServerData.IProduct product = productsBase.Products.FirstOrDefault(x => x.ID == id);

            if (productsBase.TryDecrease(product))
                return true;

            EventHandler<IncorrectOrderEventArgs> handler = IncorrectOrder;
            handler?.Invoke(this, new IncorrectOrderEventArgs(id));
            return false;
        }

        private string ParseProductsToXML(List<IProduct> products)
        {
            string xml = "";
            Serializer serializer = new Serializer();
            foreach (IProduct item in products)
            {
                ProductXML p = new ProductXML(item.Name, item.Price, item.Count, item.ID, item.Description);
                serializer.products.Add(p);
            }
            xml += serializer.ParseToXML();
            return xml;
        }

        public void OnCompleted()
        {
            this.Unsunscribe();
        }

        public void OnError(Exception error)
        {
        }

        public void OnNext(ServerData.IProduct value)
        {
            EventHandler<CountChangedEventArgs> handler = CountChanged;
            handler?.Invoke(this, new CountChangedEventArgs(value.ID, value.Count));
        }

        private void Unsunscribe()
        {
            unsubscriber.Dispose();
        }
    }
}
