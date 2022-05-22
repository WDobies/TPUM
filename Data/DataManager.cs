using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data
{
    public abstract class IDataManager
    {
        public abstract IProductsBase ProductsBase { get; }
        public static IDataManager Create(IProductsBase productsBase = default)
        {
            return new DataManager(productsBase);
        }
        public abstract event EventHandler<NewListEventArgs> NewList;

        // TEMP In IDataManager
        public abstract void XML_ToNewList(string message);
    }
    internal class DataManager: IDataManager
    {
        public DataManager(IProductsBase productsBase)
        {
            ProductsBase = productsBase ?? new ProductsBase();
        }
        public override IProductsBase ProductsBase { get; }

        public override void XML_ToNewList(string message)
        {
            // TODO: XML from message to List<IProduct> products

            // TEMP
            List<IProduct> products = new List<IProduct>();
            products.Add(new Laptop("Legion", 4800, 10, ProductType.Laptop, 512, 16));
            products.Add(new Laptop("Legion", 5000, 10, ProductType.Laptop, 1000, 16));
            // END TEMP

            EventHandler<NewListEventArgs> handler = NewList;
            handler?.Invoke(this, new NewListEventArgs(products));
        }

        public override event EventHandler<NewListEventArgs> NewList;
    }
}
