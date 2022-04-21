using System;

namespace Data
{
    public interface IProduct
    {
        string Name { get; set; }
        float Price { get; set; }        
        string Brand { get; set; }

        //TODO GUID?
        //TODO only get???
    }
}