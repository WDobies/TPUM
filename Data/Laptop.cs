namespace Data
{
    class Laptop : IProduct
    {
        public Laptop(string name, float price, ProductType type, string description = "")
        {
            Name = name;
            Type = type;
            Price = price;
            Description = description;
        }

        public string Name { get; }
        public float Price { get; }
        public string Description { get; }
        public ProductType Type { get; }

    }
}
