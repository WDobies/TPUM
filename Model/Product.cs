using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Product : ObservedObject
    {
        public Product(string name, float price, string description = "")
        {
            this.name = name;
            this.price = price;
            this.description = description;
            this.id = Guid.NewGuid();
            this.count = 0;
        }

        public Product(string name, float price, Guid id, string description = "")
        {
            this.name = name;
            this.price = price;
            this.description = description;
            this.id = id;
            this.count = 0;
        }

        public Product(string name, float price, Guid id, int count, string description = "")
        {
            this.name = name;
            this.price = price;
            this.description = description;
            this.id = id;
            this.count = count;
        }

        private string name;
        private Guid id;
        private float price;
        private string description;
        private int count;

        public int Count 
        {
            get => count;
            set
            {
                count = value;
                onPropertyChanged(nameof(Count));
            }
        }
        public string Name { get => name; }
        public Guid ID { get => id; }
        public float Price { get => price; }
        public string Description { get => description; }
    }
}
