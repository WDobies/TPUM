using System;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace ViewModel
{
    public class ShopViewModel
    {
        public Model.ShopModel model { get; }

        public int SelectedListIndex = 0;

        private IDialogService _dialogService;

        public IDialogService dialogService { get => _dialogService; set { _dialogService = value; }}

        public ObservableCollection<Product> Products { get; } = new ObservableCollection<Product>();

        public ShopViewModel()
        {
            model = new Model.ShopModel();
            model.ChangeProductList(SelectedListIndex);
            CopyModelAllProducts();

            SetLaptopList = new SetListCommand(this, 0);
            SetSmartphoneList = new SetListCommand(this, 1);
            SetAccessoeiesList = new SetListCommand(this, 2);
            AlertCommand = new AlertCommand(this);
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
                AlertCommand.Execute(this);
        }

        #region Commands

        public ICommand AlertCommand { get; }

        public ICommand SetLaptopList { get; }

        public ICommand SetSmartphoneList { get; }

        public ICommand SetAccessoeiesList { get; }

        #endregion


    }
}
