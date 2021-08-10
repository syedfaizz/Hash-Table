using System;
using System.Collections.Generic;
using System.Text;

namespace HashTableProblems
{
    public struct KeyValue<K, V>
    {
        public K Key { get; set; }
        public V Value { get; set; }
    }
}