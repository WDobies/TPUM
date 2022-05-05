using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
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
}
