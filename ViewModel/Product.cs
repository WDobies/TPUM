using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ViewModel
{
    public class Product : ObservedObject
    {
        private Model.IProduct model;

        public Product(Model.IProduct product)
        {
            model = product;
            model.PropertyChanged += Model_PropertyChanged;
        }

        void Model_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            onPropertyChanged(e.PropertyName);
        }

        #region Properties

        public string Description
        {
            get => model.Description;
        }

        public int Count { get => model.Count; }

        public string Name
        {
            get
            {
                return model.Name;
            }
        }

        public Guid ID
        {
            get
            {
                return model.ID;
            }
        }

        public float Price
        {
            get
            {
                return model.Price;
            }
        }

        #endregion

        public event EventHandler<EventArgs> BuyEvent;

        #region Commands


        private ICommand buy;

        public ICommand Buy
        {
            get
            {
                if (buy == null) buy =
                         new RelayCommand(
                             o =>
                             {
                                 EventHandler<EventArgs> handler = BuyEvent;
                                 handler?.Invoke(this, new EventArgs());
                             },
                             o =>
                             {
                                 return (Count > 0);
                             });
                return buy;
            }
        }
        #endregion

    }
}
