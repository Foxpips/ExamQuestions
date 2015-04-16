using System;
using System.Collections.Generic;
using System.Linq;

namespace ExamQuestions
{
    public class FixedSizeGenericHashTable<TK, TV>
    {
        private readonly LinkedList<KeyValue<TK, TV>>[] _items;

        public FixedSizeGenericHashTable(int size)
        {
            _items = new LinkedList<KeyValue<TK, TV>>[size];
        }

        protected int GetArrayPosition(TK key)
        {
            var position = key.GetHashCode()%_items.Length;
            return Math.Abs(position);
        }

        protected LinkedList<KeyValue<TK, TV>> GetLinkedList(int position)
        {
            return _items[position] ?? (_items[position] = new LinkedList<KeyValue<TK, TV>>());
        }

        public void Add(TK key, TV value)
        {
            LinkedList<KeyValue<TK, TV>> linkedList = GetLinkedList(GetArrayPosition(key));
            var item = new KeyValue<TK, TV> {Key = key, Value = value};
            linkedList.AddLast(item);
        }

        public void Remove(TK key)
        {
            var linkedList = GetLinkedList(GetArrayPosition(key));
            var keyValues = linkedList.Where(item => item.Key.Equals(key)).ToList();
            foreach (var item in keyValues)
            {
                linkedList.Remove(item);
            }
        }

        public TV Find(TK key)
        {
            var position = GetArrayPosition(key);
            var linkedList = GetLinkedList(position);
            foreach (var item in linkedList.Where(item => item.Key.Equals(key)))
            {
                return item.Value;
            }

            return default(TV);
        }
    }
}