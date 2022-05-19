using ServerData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServerLogic
{
    public abstract class IServerLogicManager
    {
        abstract public IShop Shop {get;}
        public static IServerLogicManager Create(IShop shop = default)
        {
            return new ServerLogicManager(shop);
        }
    }
    internal class ServerLogicManager: IServerLogicManager
    {
        public override IShop Shop { get; }
        public ServerLogicManager(IShop shop)
        {
            Shop = shop ?? new Shop();
        }
    }
}
