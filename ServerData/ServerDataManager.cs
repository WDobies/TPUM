using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServerData
{
    public abstract class IServerDataManager
    {
        public abstract IProductsBase ProductsBase { get; }
        public static IServerDataManager Create(IProductsBase productsBase = default)
        {
            return new ServerDataManager(productsBase);
        }
    }
    internal class ServerDataManager: IServerDataManager
    {
        public ServerDataManager(IProductsBase productsBase)
        {
            ProductsBase = productsBase ?? new ProductsBase();
        }
        public override IProductsBase ProductsBase { get; }
    }
}
