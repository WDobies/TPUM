﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
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
        public NewListEventArgs()
        { }
    }
}
