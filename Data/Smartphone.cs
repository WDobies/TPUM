using System;
namespace Data
{
    class Smartphone: IProduct
    {
        public Smartphone(string name, float price, int count, ProductType type, string description = "")
        {
            Name = name;
            Type = type;
            Price = price;
            Description = description;
            Count = count;
            ID = Guid.NewGuid();
        }

        public string Name { get; }
        public float Price { get; }
        public string Description { get; }
        public int Count { get; }
        public ProductType Type { get; }
        public Guid ID { get; }
    }
}
