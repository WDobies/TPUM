using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("ServerDataTEST")]

namespace ServerData
{
    internal class Laptop : IProduct
    {
        public Laptop(string name, float price, int count, ProductType type, int drive, int ram)
        {
            Name = name;
            Type = type;
            Price = price;
            Count = count;
            ID = Guid.NewGuid();
            Drive = drive;
            Ram = ram;
            Description = GenerateDescription();
        }

        public string GenerateDescription()
        {
            return "Drive: " + Drive + "GB\nRAM: " + Ram + "GB";
        }

        public string Name { get; }
        public float Price { get; }
        public string Description { get; }
        public int Count { get; set; }
        public ProductType Type { get; }
        public Guid ID { get; }
        private int Drive {get;}
        private int Ram { get; }
    }
}
