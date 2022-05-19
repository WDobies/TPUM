using System;

namespace ServerData
{
    internal class Accessories: IProduct
    {
        public Accessories(string name, float price, int count, ProductType type, string brand)
        {
            Name = name;
            Type = type;
            Price = price;
            Count = count;
            ID = Guid.NewGuid();
            Brand = brand;
            Description = GenerateDescription();
        }

        public string Name { get; }
        public float Price { get; }
        public string Description { get; }
        public int Count { get; set; }
        public ProductType Type { get; }
        public Guid ID { get; }
        public string Brand { get; }

        public string GenerateDescription()
        {
            return "Brand: " + Brand;
        }
    }
}
