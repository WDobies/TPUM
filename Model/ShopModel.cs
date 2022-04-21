﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ShopModel
    {
        public List<Product> products { get; } = new List<Product>();

        public ShopModel()
        {
            products.Add(new Product("xd", 10, "XYZ"));
            products.Add(new Product("aa", 20, "222"));
            products.Add(new Product("bb", 30, "333"));
            products.Add(new Product("cc", 40, "444"));
        }

        public Product this[int index]
        {
            get
            {
                return products[index];
            }
        }
    }
}