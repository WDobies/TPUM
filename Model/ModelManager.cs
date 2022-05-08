using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public abstract class IModelManager
    {
        abstract public IShopModel ShopModel { get; }
        public static IModelManager Create(IShopModel shopModel = default)
        {
            return new ModelManager(shopModel);
        }
    }

    internal class ModelManager : IModelManager
    {
        public override IShopModel ShopModel { get; }
        public ModelManager(IShopModel shopModel)
        {
            ShopModel = shopModel ?? new ShopModel();
        }
    }
}
