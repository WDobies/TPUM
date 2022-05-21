using System;
using System.Threading.Tasks;

namespace ServerPresentation
{
    class Program
    {
        static WebSocketConnection server = null;
        static async Task Main(string[] args)
        {
            Uri uri = new Uri("ws://localhost:9696");
            Task server = Task.Run(async () => await WebSocketServer.Server(uri.Port,
                _ws =>
                {
                    Program.server = _ws; Program.server.onMessage = (data) =>
                    {
                        Console.WriteLine("\n recived:");
                        Console.WriteLine(data.ToString());
                        
                    };
                }));


            Console.ReadKey();
        }
    }
}
