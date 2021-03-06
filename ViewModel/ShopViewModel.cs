using System;
using System.Collections.ObjectModel;
using System.Windows.Data;
using System.Windows.Input;

namespace ViewModel
{
    public class ShopViewModel
    {
        public Model.IShopModel model { get; }

        public int SelectedListIndex = 0;

        private IDialogService _dialogService;

        public IDialogService dialogService { get => _dialogService; set { _dialogService = value; }}

        public ObservableCollection<Product> Products { get; }

        public ShopViewModel()
        {
            Products = new ObservableCollection<Product>();
            object lockObj = new object();
            BindingOperations.EnableCollectionSynchronization(Products, lockObj);

            Model.IModelManager modelManager = Model.IModelManager.Create();
            model= modelManager.ShopModel;

            //model.ChangeProductList(SelectedListIndex);
            //CopyModelAllProducts();

            model.NewList += OnNewList;
            model.IncorrectOrder += OnIncorrectOrder;

            SetLaptopList = new SetListCommand(this, 0);
            SetSmartphoneList = new SetListCommand(this, 1);
            SetAccessoeiesList = new SetListCommand(this, 2);
            AlertCommand = new AlertCommand(this);
        }

        private void OnNewList(object sender, Model.NewListEventArgs e)
        {
            CopyModelAllProducts();
        }

        public void CopyModelAllProducts()
        {
            
            Products.Clear();
            foreach (Model.IProduct product in model.Products)
                Products.Add(new ViewModel.Product(product));
            
            foreach (Product product in Products)
                product.BuyEvent += OnBuy;
        }

        public EventHandler<EventArgs> BuyMessage;

        private void OnBuy(object sender, EventArgs e)
        {
            model.Buy(((Product)sender).ID);
        }

        private void OnIncorrectOrder(object sender, Model.IncorrectOrderEventArgs e)
        {
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
