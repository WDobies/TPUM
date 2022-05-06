using System;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace ViewModel
{
    public class ShopViewModel
    {
        public Model.ShopModel model { get; }

        public int SelectedListIndex = 0;

        public ObservableCollection<Product> Products { get; } = new ObservableCollection<Product>();

        public ShopViewModel()
        {
            model = new Model.ShopModel();
            model.ChangeProductList(SelectedListIndex);
            CopyModelAllProducts();

            SetLaptopList = new SetListCommand(this, 0);
            SetSmartphoneList = new SetListCommand(this, 1);
            SetAccessoeiesList = new SetListCommand(this, 2);
        }

        public void CopyModelAllProducts()
        {
            Products.Clear();
            foreach (Model.Product product in model.products)
                Products.Add(new ViewModel.Product(product));

            foreach (Product product in Products)
                product.BuyEvent += OnBuy;
        }

        public EventHandler<EventArgs> BuyMessage;

        private void OnBuy(object sender, EventArgs e)
        {
            if(model.Buy(((Product)sender).ID) == false)
            {
                EventHandler<EventArgs> handler = BuyMessage;
                handler?.Invoke(this, new EventArgs());
            }
        }

        #region Commands

        public ICommand SetLaptopList { get; }

        public ICommand SetSmartphoneList { get; }

        public ICommand SetAccessoeiesList { get; }

        #endregion


    }
}
