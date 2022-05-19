using System;

namespace ServerData
{
    internal class Smartphone: IProduct
    {
        public Smartphone(string name, float price, int count, ProductType type, int battery, int camera)
        {
            Name = name;
            Type = type;
            Price = price;
            Count = count;
            ID = Guid.NewGuid();
            Battery = battery;
            Camera = camera;
            Description = GenerateDescription();
        }

        public string Name { get; }
        public float Price { get; }
        public string Description { get; }
        public int Count { get; set; }
        public int Battery { get; }
        public int Camera { get; }
        public ProductType Type { get; }
        public Guid ID { get; }
        public string GenerateDescription()
        {
            return "Battery: " + Battery + "mAh\nCamera Resolution: " + Camera + "MP";
        }
    }
}
