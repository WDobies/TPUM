namespace Data
{
    class Accessories: IProduct
    {
        public Accessories(string name, float price, ProductType type, string description = "")
        {
            Name = name;
            Price = price;
            Description = description;
        }

        public string Name { get; }
        public float Price { get; }
        public string Description { get; }
        public ProductType Type { get; }
    }
}
