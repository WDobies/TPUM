using Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Logic
{
    public abstract class IShop
    {
        public abstract List<IProduct> GetAllProducts();
        public abstract void GetProductsOfType(int type);
        public abstract bool Buy(Guid id);
        public abstract event EventHandler<CountChangedEventArgs> CountChanged;
        public abstract event EventHandler<NewListEventArgs> NewList;
    }
    public class Shop: IShop
    {
        private IDataManager dataManager;
        private IProductsBase productsBase;


        public Shop()
        {
            this.dataManager = IDataManager.Create();
            this.productsBase = dataManager.ProductsBase;

            dataManager.ProductsBase.NewList += OnNewList;
            dataManager.ProductsBase.CountChanged += OnCountChanged;
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

        public override void GetProductsOfType(int type)
        {
            // TEMP
            //dataManager.XML_ToNewList("TEMP");
            // TODO: SendAsync("GetProductsOfType+type")
            dataManager.ProductsBase.GetProductsOfType(type);
        }

        public override event EventHandler<CountChangedEventArgs> CountChanged;

        private void OnCountChanged(object sender, Data.CountChangedEventArgs e)
        {
            EventHandler<CountChangedEventArgs> handler = CountChanged;
            handler?.Invoke(this, new CountChangedEventArgs(e.ID, e.Value));
        }

        public override bool Buy(Guid id)
        {
            dataManager.ProductsBase.Buy(id);

            //Data.IProduct product = productsBase.Products.FirstOrDefault(x => x.ID == id);
            //
            //if (product.Count <= 0)
            //    return false;
            //
            //product.Count--;
            //EventHandler<CountChangedEventArgs> handler = CountChanged;
            //handler?.Invoke(this, new CountChangedEventArgs(id, product.Count));
            return true;
        }

        public override event EventHandler<NewListEventArgs> NewList;

        private void OnNewList(object sender, Data.NewListEventArgs e)
        {
            List<IProduct> products = new List<IProduct>();
            foreach (Data.IProduct item in e.Products)
            {
                products.Add(new Product(item.Name, item.Price, item.Count, item.ID, item.Description));
            }

            EventHandler<NewListEventArgs> handler = NewList;
            handler?.Invoke(this, new NewListEventArgs(products));
        }
    }
}
