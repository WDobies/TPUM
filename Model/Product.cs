using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public abstract class IProduct : ObservedObject
    {
        public abstract int Count
        {
            get;
            internal set;
        }
        public abstract string Name { get; }
        public abstract Guid ID { get; }
        public abstract float Price { get; }
        public abstract string Description { get; }
    }

    internal class Product : IProduct
    {
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

        public override int Count 
        {
            get => count;
            internal set
            {
                count = value;
                onPropertyChanged(nameof(Count));
            }
        }
        public override string Name { get => name; }
        public override Guid ID { get => id; }
        public override float Price { get => price; }
        public override string Description { get => description; }
    }
}
