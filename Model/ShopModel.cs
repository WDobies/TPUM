using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic;

namespace Model
{
    public abstract class IShopModel
    {
        public abstract List<IProduct> Products { get; }
        public abstract void ChangeProductList(int productType);
        public abstract bool Buy(Guid id);
        public abstract event EventHandler<NewListEventArgs> NewList;
    }

    internal class ShopModel : IShopModel 
    {
        private ILogicManager logicManager;
        private IShop shop;

        public override List<IProduct> Products { get; }

        public ShopModel()
        {
            logicManager = ILogicManager.Create();
            shop = logicManager.Shop;
            shop.CountChanged += OnCountChanged;
            shop.NewList += OnNewList;

            Products = new List<IProduct>();
        }

        public override void ChangeProductList(int productType)
        {
            shop.GetProductsOfType(productType);
        }

        public override bool Buy(Guid id)
        {
            return shop.Buy(id);
        }

        private void OnCountChanged(object sender, Logic.CountChangedEventArgs e)
        {
            IProduct product = Products.FirstOrDefault(x => x.ID == e.ID);
            if(product != null)
                product.Count = e.Value;
        }

        public override event EventHandler<NewListEventArgs> NewList;

        private void OnNewList(object sender, Logic.NewListEventArgs e)
        {
            Products.Clear();

            foreach (Logic.IProduct item in e.Products)
            {
                Products.Add(new Product(item.Name, item.Price, item.ID, item.Count, item.Description));
            }

            EventHandler<NewListEventArgs> handler = NewList;
            handler?.Invoke(this, new NewListEventArgs());
        }
    }
}
