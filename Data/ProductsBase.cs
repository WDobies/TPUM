using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data
{
    public abstract class IProductsBase
    {
        public abstract List<IProduct> Products { get; }
    }

    class ProductsBase: IProductsBase
    {
        override public List<IProduct> Products { get; }

        ProductsBase()
        {
            Products.Add(new Laptop("Laptop 01", 2000, ProductType.Laptop, "Samsung"));
            Products.Add(new Laptop("Laptop 02", 1500, ProductType.Laptop, "Asus"));
            Products.Add(new Laptop("Laptop 03", 4000, ProductType.Laptop));
            Products.Add(new Laptop("Laptop 04", 4000, ProductType.Laptop, "ABCD"));

            Products.Add(new Smartphone("Smartphone 01", 4000, ProductType.Smartphone, "Samsung"));
            Products.Add(new Smartphone("Smartphone 02", 300, ProductType.Smartphone, "Iphone"));
            Products.Add(new Smartphone("Smartphone 03", 2000, ProductType.Smartphone, "LG"));
            Products.Add(new Smartphone("Smartphone 04", 1500, ProductType.Smartphone, "ABCD"));

            Products.Add(new Accessories("Accessories 01", 10, ProductType.Accessories, "noname"));
            Products.Add(new Accessories("Accessories 02", 35, ProductType.Accessories, "RT"));
            Products.Add(new Accessories("Accessories 03", 60, ProductType.Accessories, "XYZ"));
            Products.Add(new Accessories("Accessories 04", 90, ProductType.Accessories, "ABCD"));
        }
    }
}
