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
        }

        public Product(string name, float price, Guid id, string description = "")
        {
            this.name = name;
            this.price = price;
            this.description = description;
            this.id = id;
        }

        private string name;
        private Guid id;
        private float price;
        private string description;


        public string Name { get => name; }
        public Guid ID { get => id; }
        public float Price 
        {
            get => price;
            set
            {
                price = value;
                onPropertyChanged(nameof(Price));
            }
        }
        public string Description { get => description; }
    }
}
