using Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TESTCLIENT
{
    class Program
    {
        static WebSocketConnection _wclient = null;

        static async Task Main(string[] args)
        {
            await connect();

            send("test");

            Console.ReadKey();
        }

        static public async Task connect()
        {
            Uri uri = new Uri("ws://localhost:9696");
            _wclient = await WebSocketClient.Connect(uri, message => Console.WriteLine("Connected"));

            _wclient.onMessage = (data) =>
            {
                Console.WriteLine("Recived data from server");
            };
        }
        static async void send(string message)
        {
            await _wclient.SendAsync(message);
        }
    }
}
