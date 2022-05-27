using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    internal class Product : IProduct
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
        public int Count { get; set; }
        public Guid ID { get; }
    }
}
