using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data
{
    class ProductsBase
    {
        public List<IProduct> Products { get; }

        ProductsBase()
        {
            Products.Add(new Laptop("Laptop 01", 2000, "Samsung"));
            Products.Add(new Laptop("Laptop 02", 1500, "Asus"));
            Products.Add(new Laptop("Laptop 03", 4000, "HP"));
            Products.Add(new Laptop("Laptop 04", 4000, "ABCD"));

            Products.Add(new Smartphone("Smartphone 01", 4000, "Samsung"));
            Products.Add(new Smartphone("Smartphone 02", 300, "Iphone"));
            Products.Add(new Smartphone("Smartphone 03", 2000, "LG"));
            Products.Add(new Smartphone("Smartphone 04", 1500, "ABCD"));

            Products.Add(new Accessories("Accessories 01", 10, "noname"));
            Products.Add(new Accessories("Accessories 02", 35, "RT"));
            Products.Add(new Accessories("Accessories 03", 60, "XYZ"));
            Products.Add(new Accessories("Accessories 04", 90, "ABCD"));
        }
    }
}
