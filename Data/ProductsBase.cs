using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data
{
    public abstract class IProductsBase
    {
        public abstract List<IProduct> Products { get; }

        public abstract void Buy(Guid id);

        public abstract event EventHandler<CountChangedEventArgs> CountChanged;
    }

    internal class ProductsBase: IProductsBase
    {
        override public List<IProduct> Products { get; }

        public ProductsBase()
        {
            Products = new List<IProduct>();

            Products.Add(new Laptop("Laptop 01", 2000, 55, ProductType.Laptop, 256, 2));
            Products.Add(new Laptop("Laptop 02", 1500, 2, ProductType.Laptop, 128, 32));
            Products.Add(new Laptop("Laptop 03", 4000, 6, ProductType.Laptop, 64, 4));
            Products.Add(new Laptop("Laptop 04", 4000, 1,ProductType.Laptop, 1000, 12));
            Products.Add(new Laptop("Laptop 05", 2000, 55, ProductType.Laptop, 256, 2));
            Products.Add(new Laptop("Laptop 06", 1500, 2, ProductType.Laptop, 128, 32));
            Products.Add(new Laptop("Laptop 07", 4000, 6, ProductType.Laptop, 64, 4));
            Products.Add(new Laptop("Laptop 08", 4000, 1, ProductType.Laptop, 1000, 12));

            Products.Add(new Smartphone("Smartphone 01", 4000, 7,ProductType.Smartphone, 3000, 12));
            Products.Add(new Smartphone("Smartphone 02", 300, 5,ProductType.Smartphone, 1000, 11));
            Products.Add(new Smartphone("Smartphone 03", 2000, 6,ProductType.Smartphone, 2000, 8));
            Products.Add(new Smartphone("Smartphone 04", 1500, 2,ProductType.Smartphone, 4000, 8));
            Products.Add(new Smartphone("Smartphone 05", 3000, 7, ProductType.Smartphone, 3000, 12));
            Products.Add(new Smartphone("Smartphone 06", 300, 5, ProductType.Smartphone, 1000, 11));
            Products.Add(new Smartphone("Smartphone 07", 2000, 6, ProductType.Smartphone, 4000, 2));
            Products.Add(new Smartphone("Smartphone 08", 2500, 2, ProductType.Smartphone, 4000, 8));

            Products.Add(new Accessories("Accessories 01", 10, 3, ProductType.Accessories, "noname"));
            Products.Add(new Accessories("Accessories 02", 35, 6, ProductType.Accessories, "RT"));
            Products.Add(new Accessories("Accessories 03", 60, 1, ProductType.Accessories, "XYZ"));
            Products.Add(new Accessories("Accessories 04", 90, 4, ProductType.Accessories, "ABCD"));
            Products.Add(new Accessories("Accessories 05", 10, 3, ProductType.Accessories, "123"));
            Products.Add(new Accessories("Accessories 06", 35, 6, ProductType.Accessories, "LG"));
            Products.Add(new Accessories("Accessories 07", 60, 1, ProductType.Accessories, "LG"));
            Products.Add(new Accessories("Accessories 08", 90, 4, ProductType.Accessories, "ABCD"));
        }

        public override event EventHandler<CountChangedEventArgs> CountChanged;

        public override void Buy(Guid id)
        {
            IProduct product = Products.FirstOrDefault(x => x.ID == id);
            product.Count--;
            EventHandler<CountChangedEventArgs> handler = CountChanged;
            handler?.Invoke(this, new CountChangedEventArgs(id, product.Count));
        }
    }
}
