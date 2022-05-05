using System;

namespace Data
{
    public enum ProductType
    {
        Laptop,
        Smartphone,
        Accessories
    }

    public interface IProduct
    {
        string Name { get; }
        float Price { get; }        
        string Description { get; }
        int Count { get; }
        ProductType Type { get; }
        Guid ID { get; }
    }
}