using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic;

namespace Model
{
    public class ShopModel
    {
        private ILogicManager logicManager;
        private IShop shop;

        public List<Product> products { get; } = new List<Product>();

        public ShopModel()
        {
            logicManager = ILogicManager.Create();
            shop = logicManager.Shop;
            shop.CountChanged += OnCountChanged;


            products.Add(new Product("xd", 10, "XYZ"));
            products.Add(new Product("aa", 20, "222"));
            products.Add(new Product("bb", 30, "333"));
            products.Add(new Product("cc", 40, "444"));
        }

        public void ChangeProductList(int productType)
        {
            products.Clear();
            
            List<Logic.Product> newPreoducts =  shop.GetProductsOfType(productType);
            foreach (Logic.Product item in newPreoducts)
            {
                products.Add(new Product(item.Name, item.Price, item.ID, item.Count, item.Description));
            }
        }

        public bool Buy(Guid id)
        {
            return shop.Buy(id);
        }

        private void OnCountChanged(object sender, Logic.CountChangedEventArgs e)
        {
            Product product = products.FirstOrDefault(x => x.ID == e.ID);
            product.Count = e.Value;
        }

        public Product this[int index]
        {
            get
            {
                return products[index];
            }
        }
    }
}
