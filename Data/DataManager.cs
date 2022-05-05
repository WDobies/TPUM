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
    }
    internal class DataManager: IDataManager
    {
        public DataManager(IProductsBase productsBase)
        {
            ProductsBase = productsBase ?? new ProductsBase();
        }
        public override IProductsBase ProductsBase { get; }
    }
}
