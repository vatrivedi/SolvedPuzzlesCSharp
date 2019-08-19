using System;
using System.Collections.Generic;
using System.Text;

namespace SolvedPuzzlesInCSharp
{
    public struct KeyVal<K, V>
    {
        public K Key { get; set; }
        public V Value { get; set; }

    }

    /// <summary>
    /// Implement Hashtable using Linked list
    /// Contains Add, Remove and Find method
    /// Reference: https://stackoverflow.com/questions/625947/what-is-an-example-of-a-hashtable-implementation-in-c 
    /// </summary>
    /// <typeparam name="K"></typeparam>
    /// <typeparam name="V"></typeparam>
    public class HashTableImpl<K, V>
    {
        private readonly int size;
        private readonly LinkedList<KeyVal<K, V>>[] items;

        public HashTableImpl(int size)
        {
            this.size = size;
            items = new LinkedList<KeyVal<K, V>>[size];
        }

        /// <summary>
        /// Get the position of the item by dividing Hashcode by ItemSize
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public int GetPosition(K key)
        {
            var position = key.GetHashCode() % size;
            return Math.Abs(position);
        }

        /// <summary>
        /// Based on the position, get the corresponding Key Value pair
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public LinkedList<KeyVal<K, V>> GetLinkedList(int position)
        {
            var linkedlist = items[position];
            // if the item doesn't exist at the position then, create a new one!
            if (linkedlist == null)
            {
                linkedlist = new LinkedList<KeyVal<K, V>>();
                items[position] = linkedlist;
            }

            return linkedlist;
        }

        /// <summary>
        /// Add Method - based on the position, add the key/value pair 
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void Add(K key, V value)
        {
            var position = GetPosition(key);
            var linkedlist = GetLinkedList(position);

            KeyVal<K, V> keyVal = new KeyVal<K, V>() { Key = key, Value = value };
            linkedlist.AddLast(keyVal);
        }

        public void Remove(K key)
        {
            bool isExists = false;

            var position = GetPosition(key);
            var linkedlist = GetLinkedList(position);
            var itemFound = default(KeyVal<K, V>);

            foreach (KeyVal<K, V> tmp in linkedlist)
            {
                if (tmp.Key.Equals(key))
                {
                    isExists = true;
                    itemFound = tmp;
                }
            }

            if (isExists)
            {
                linkedlist.Remove(itemFound);
            }
        }

        public V Find(K key)
        {
            var position = GetPosition(key);
            var linkedlist = GetLinkedList(position);

            foreach (KeyVal<K, V> tmp in linkedlist)
            {
                if (tmp.Key.Equals(key))
                {
                    Console.WriteLine($"Value {tmp.Value} found for key: {tmp.Key}");
                    return tmp.Value;
                }
            }

            return default(V);
        }

    }


}
