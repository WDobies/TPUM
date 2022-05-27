using System;

namespace Data
{

    public interface IProduct
    {
        string Name { get; }
        float Price { get; }        
        string Description { get; }
        int Count { get; set;}
        Guid ID { get; }
    }
}