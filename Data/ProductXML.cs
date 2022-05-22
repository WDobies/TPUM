using System;


namespace Data
{
    public class ProductXML
    {
        public ProductXML() 
        {
        }
        public ProductXML(string name, float price, int count, Guid id, string description = "")
        {
            Name = name;
            Price = price;
            Description = description;
            Count = count;
            ID = id;
        }

        public string Name { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }
        public int Count { get; set; }
        public Guid ID { get; set; }

    }
}
