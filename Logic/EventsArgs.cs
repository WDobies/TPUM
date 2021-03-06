using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logic
{
    public class CountChangedEventArgs : EventArgs
    {
        public CountChangedEventArgs(Guid id, int value)
        {
            ID = id;
            Value = value;
        }

        public Guid ID { get; }
        public int Value { get; }
    }

    public class NewListEventArgs : EventArgs
    {
        public NewListEventArgs(List<IProduct> list)
        {
            Products = list;
        }

        public List<IProduct> Products { get; }
    }
    public class IncorrectOrderEventArgs : EventArgs
    {
        public IncorrectOrderEventArgs(Guid id)
        {
            ID = id;
        }

        public Guid ID { get; }
    }
}
