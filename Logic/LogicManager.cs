using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logic
{
    public abstract class ILogicManager
    {
        abstract public IShop Shop {get;}
        public static ILogicManager Create(IShop shop = default)
        {
            return new LogicManager(shop);
        }
    }
    internal class LogicManager: ILogicManager
    {
        public override IShop Shop { get; }
        public LogicManager(IShop shop)
        {
            Shop = shop ?? new Shop();
        }
    }
}
