namespace Data
{
    class Laptop : IProduct
    {
        public Laptop(string name, float price, string brand)
        {
            Name = name;
            Price = price;
            Brand = brand;
        }

        public string Name { get; set; }
        public float Price { get; set; }
        public string Brand { get; set; }
    }
}
