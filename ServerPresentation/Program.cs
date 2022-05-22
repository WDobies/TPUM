using ServerLogic;
using System;
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
            string ProductstoXML = logicManager.Shop.ParseAllProductsToXML();

            //test serialize deserialize
            Serializer serializer = new Serializer();
            serializer.DeserializeXML(ProductstoXML);
            Console.WriteLine(serializer.products[3].Name);
            
            //
            

            Uri uri = new Uri("ws://localhost:9696");
            Task server = Task.Run(async () => await WebSocketServer.Server(uri.Port,
                _ws =>
                {
                    Program.server = _ws; Program.server.onMessage = (data) =>
                    {
                        //Console.WriteLine("\nrecived:" + parseTEST);
                        Console.WriteLine(data.ToString());
                        
                    };
                }));


            Console.ReadKey();
        }
    }
}
