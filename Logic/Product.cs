using System;

namespace Logic
{
    public abstract class IProduct
    {
        abstract public string Name { get; }
        abstract public float Price { get; }
        abstract public string Description { get; }
        abstract public int Count { get; }
        abstract public Guid ID { get; }
    }
    internal class Product: IProduct
    {
        public Product(string name, float price, int count, Guid id, string description = "")
        {
            Name = name;
            Price = price;
            Description = description;
            Count = count;
            ID = id;
        }

        override public string Name { get; }
        override public float Price { get; }
        override public string Description { get; }
        override public int Count { get; }
        override public Guid ID { get; }
    }
}
