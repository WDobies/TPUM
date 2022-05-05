using System;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace ViewModel
{
    public class ShopViewModel
    {
        Model.ShopModel model;

        int selectedListIndex = 0;

        public ObservableCollection<Product> Products { get; } = new ObservableCollection<Product>();

        public ShopViewModel()
        {
            model = new Model.ShopModel();
            model.ChangeProductList(selectedListIndex);
            copyModelAllProducts();
        }

        private void copyModelAllProducts()
        {
            Products.Clear();
            foreach (Model.Product product in model.products)
                Products.Add(new ViewModel.Product(product));

            foreach (Product product in Products)
                product.BuyEvent += OnBuy;
        }

        private void OnBuy(object sender, EventArgs e)
        {
            model.Buy(((Product)sender).ID);
        }

        #region Commands

        private ICommand setLaptopList;

        public ICommand SetLaptopList
        {
            get
            {
                if (setLaptopList == null) setLaptopList =
                         new RelayCommand(
                             o =>
                             {
                                 selectedListIndex = 0;
                                 model.ChangeProductList(selectedListIndex);
                                 copyModelAllProducts();
                             },
                             o =>
                             {
                                 if (selectedListIndex == 0)
                                     return false;
                                 return true;
                             });
                return setLaptopList;
            }
        }

        private ICommand setSmartphoneList;

        public ICommand SetSmartphoneList
        {
            get
            {
                if (setSmartphoneList == null) setSmartphoneList =
                         new RelayCommand(
                             o =>
                             {
                                 selectedListIndex = 1;
                                 model.ChangeProductList(selectedListIndex);
                                 copyModelAllProducts();
                             },
                             o =>
                             {
                                 if (selectedListIndex == 1)
                                     return false;
                                 return true;
                             });
                return setSmartphoneList;
            }
        }

        private ICommand setAccessoeiesList;

        public ICommand SetAccessoeiesList
        {
            get
            {
                if (setAccessoeiesList == null) setAccessoeiesList =
                         new RelayCommand(
                             o =>
                             {
                                 selectedListIndex = 2;
                                 model.ChangeProductList(selectedListIndex);
                                 copyModelAllProducts();
                             },
                             o => 
                             {
                                 if(selectedListIndex == 2)
                                    return false;
                                 return true;
                             });
                return setAccessoeiesList;
            }
        }

        #endregion


    }
}
