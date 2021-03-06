using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public abstract class IProductsBase
    {
        public abstract List<IProduct> Products { get; }
        public abstract void GetProductsOfType(int type);
        public abstract void Buy(Guid id);


        public abstract event EventHandler<NewListEventArgs> NewList;
        public abstract event EventHandler<IncorrectOrderEventArgs> IncorrectOrder;
        public abstract event EventHandler<CountChangedEventArgs> CountChanged;
    }

    internal class ProductsBase: IProductsBase
    {
        WebSocketConnection client = null;
        
        override public List<IProduct> Products { get; }

        public ProductsBase()
        {
            InitializeConnection();

            Products = new List<IProduct>();

            //Products.Add(new Laptop("Laptop 01", 2000, 55, ProductType.Laptop, 256, 2));
            //Products.Add(new Laptop("Laptop 02", 1500, 2, ProductType.Laptop, 128, 32));
            //Products.Add(new Laptop("Laptop 03", 4000, 6, ProductType.Laptop, 64, 4));

        }

        public async Task Connect()
        {
            Uri uri = new Uri("ws://localhost:9696");
            client = await WebSocketClient.Connect(uri, message => Console.WriteLine("Connected"));

            client.onMessage = async (data) =>
            {
                Debug.WriteLine(data.ToString());
                //XML_ToNewList(data);
                ParseMessage(data.ToString());
            };
        }

        private async Task ParseMessage(string message)
        {
            if(message != null) // Tymczasowe sprawdzanie czy to jest XML
            {
                if(message.Contains("CountChanged"))
                {
                    string countChangedStr = message.Substring("CountChanged".Length);
                    string[] parts = countChangedStr.Split("/");
                    EventHandler<CountChangedEventArgs> handler = CountChanged;
                    handler?.Invoke(this, new CountChangedEventArgs(Guid.Parse(parts[1]), int.Parse(parts[0])));
                    return;
                }
                if (message.Contains("IncorrectOrder"))
                {
                    string countChangedStr = message.Substring("IncorrectOrder".Length);
                    EventHandler<IncorrectOrderEventArgs> handler = IncorrectOrder;
                    handler?.Invoke(this, new IncorrectOrderEventArgs(Guid.Parse(countChangedStr)));
                    return;
                }
                if (message.Contains("xml"))
                {
                    XML_ToNewList(message);
                    return;
                }
            }
        }

        public async void InitializeConnection()
        {
            await Connect();
            await Send("HELLO");
        }

        public async Task Send(string message)
        {
            await client.SendAsync(message);
        }

        public async override void GetProductsOfType(int type)
        {
            await Send("GetProductsOfType" + type.ToString());
        }

        public override event EventHandler<NewListEventArgs> NewList;
        public override event EventHandler<CountChangedEventArgs> CountChanged;
        public override event EventHandler<IncorrectOrderEventArgs> IncorrectOrder;

        public void XML_ToNewList(string message)
        {
            // TODO: XML from message to List<IProduct> products
            Serializer serializer = new Serializer();
            serializer.DeserializeXML(message);
            Console.WriteLine(serializer.products[0].Name);

            // TEMP
            List<IProduct> products = new List<IProduct>();
            foreach (var item in serializer.products)
            {
                products.Add(new Product(item.Name, item.Price, item.Count, item.ID, item.Description));
            }

            EventHandler<NewListEventArgs> handler = NewList;
            handler?.Invoke(this, new NewListEventArgs(products));
        }

        public override void Buy(Guid id)
        {
            Send("Buy"+id.ToString());
        }
    }
}
