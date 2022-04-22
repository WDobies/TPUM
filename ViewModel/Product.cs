using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class Product
    {
        private Model.Product model;

        public Product(Model.Product product)
        {
            model = product;
        }

        #region Properties

        public string Description
        {
            get => model.Description;
        }

        public string Name
        {
            get
            {
                return model.Name;
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
    }
}
