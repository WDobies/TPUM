using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Product
    {
        

        public Product(string name, float price, string description = "")
        {
            Name = name;
            Price = price;
            Description = description;
        }

        public string Name { get; }
        public float Price { get; }
        public string Description { get; }
    }
}
