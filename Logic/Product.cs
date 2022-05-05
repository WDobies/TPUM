using System;

namespace Logic
{
    public class Product
    {
        public Product(string name, float price, int count, Guid id, string description = "")
        {
            Name = name;
            Price = price;
            Description = description;
            Count = count;
            ID = id;
        }

        public string Name { get; }
        public float Price { get; }
        public string Description { get; }
        public int Count { get; }
        public Guid ID { get; }
    }
}
