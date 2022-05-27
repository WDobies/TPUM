using ServerLogic;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ServerPresentation
{
    class Program
    {
        static WebSocketConnection server = null;
        static async Task Main(string[] args)
        {
            //test serialize 
            IServerLogicManager logicManager = IServerLogicManager.Create();

            // TEST serialize deserialize
            //string ProductstoXML = logicManager.Shop.ParseAllProductsToXML();
            //Serializer serializer = new Serializer();
            //serializer.DeserializeXML(ProductstoXML);
            //Console.WriteLine(serializer.products[3].Name);
            //
            

            Uri uri = new Uri("ws://localhost:9696");
            Task server = Task.Run(async () => await WebSocketServer.Server(uri.Port,
                _ws =>
                {
                    Program.server = _ws; Program.server.onMessage = async (data) =>
                    {
                        //Console.WriteLine("\nrecived:" + parseTEST);
                        Console.WriteLine(data.ToString());

                        if (data == "GetProductsOfType0")
                        {
                            await Program.server.SendAsync(logicManager.Shop.GetProductsOfType(0));
                            Console.WriteLine($"[Server]: {logicManager.Shop.GetProductsOfType(0)}");
                        }
                        if (data == "GetProductsOfType1")
                        {
                            await Program.server.SendAsync(logicManager.Shop.GetProductsOfType(1));
                            Console.WriteLine($"[Server]: {logicManager.Shop.GetProductsOfType(1)}");
                        }
                        if (data == "GetProductsOfType2")
                        {
                            await Program.server.SendAsync(logicManager.Shop.GetProductsOfType(2));
                            Console.WriteLine($"[Server]: {logicManager.Shop.GetProductsOfType(2)}");
                        }
                    };
                }));


            Console.ReadKey();
        }
    }
}
