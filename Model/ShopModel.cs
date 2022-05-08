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

            Products = new List<IProduct>();
        }

        public override void ChangeProductList(int productType)
        {
            Products.Clear();
            
            List<Logic.IProduct> newPreoducts =  shop.GetProductsOfType(productType);
            foreach (Logic.IProduct item in newPreoducts)
            {
                Products.Add(new Product(item.Name, item.Price, item.ID, item.Count, item.Description));
            }
        }

        public override bool Buy(Guid id)
        {
            return shop.Buy(id);
        }

        private void OnCountChanged(object sender, Logic.CountChangedEventArgs e)
        {
            IProduct product = Products.FirstOrDefault(x => x.ID == e.ID);
            product.Count = e.Value;
        }
    }
}
