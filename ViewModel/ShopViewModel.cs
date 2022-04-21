using System;
using System.Collections.ObjectModel;

namespace ViewModel
{
    public class ShopViewModel
    {
        Model.ShopModel model = new Model.ShopModel();

        public ObservableCollection<Product> Products { get; } = new ObservableCollection<Product>();

        public ShopViewModel()
        {
            copyModelAllProducts();
        }

        private void copyModelAllProducts()
        {
            Products.Clear();
            foreach (Model.Product product in model.products)
                Products.Add(new ViewModel.Product(product));
        }
    }
}
