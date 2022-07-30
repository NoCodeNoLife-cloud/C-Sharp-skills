using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace ConcurrentDictionary_template
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // assignment
            ConcurrentDictionary<int, string> concurrentDictionary = new ConcurrentDictionary<int, string>();

            // ToString()
            Console.Out.WriteLine($"concurrentDictionary.ToString()={concurrentDictionary.ToString()}");

            // GetType()
            Console.Out.WriteLine($"concurrentDictionary.GetType()={concurrentDictionary.GetType()}");

            // GetHashCode()
            Console.Out.WriteLine($"concurrentDictionary.GetHashCode()={concurrentDictionary.GetHashCode()}");

            // AddOrUpdate(TKey, Func<TKey,TValue>,  Func<TKey,TValue,TValue>)
            Console.Out.WriteLine("AddOrUpdate(TKey, Func<TKey,TValue>,  Func<TKey,TValue,TValue>)");
            concurrentDictionary.AddOrUpdate(5, (i) => "hello", (i, s) => "hello");

            // AddOrUpdate(TKey,  TValue, Func<TKey,TValue,TValue>)
            Console.Out.WriteLine("AddOrUpdate(TKey,  TValue, Func<TKey,TValue,TValue>)");
            concurrentDictionary.AddOrUpdate(7, "world", (i, s) => "world");

            // GetOrAdd(TKey,  Func<TKey,TValue>)
            Console.Out.WriteLine($"concurrentDictionary.GetOrAdd(10, (i => \"soft\"))={concurrentDictionary.GetOrAdd(10, (i => "soft"))}");

            // GetOrAdd(TKey,  TValue)
            Console.Out.WriteLine($"concurrentDictionary.GetOrAdd(15,\"node\")={concurrentDictionary.GetOrAdd(15, "node")}");

            // GetEnumerator()
            Console.Out.WriteLine("GetEnumerator()");
            IEnumerator<KeyValuePair<int, string>> enumertor = concurrentDictionary.GetEnumerator();
            while (enumertor.MoveNext())
            {
                Console.Out.WriteLine($"{enumertor.Current.Key} {enumertor.Current.Value}");
            }

            // ToArray()
            Console.Out.WriteLine("ToArray()");
            Array array = concurrentDictionary.ToArray();
            foreach (var item in array)
            {
                Console.Out.WriteLine($"{item}");
            }

            // ContainsKey(TKey)
            Console.Out.WriteLine($"concurrentDictionary.ContainsKey(7)={concurrentDictionary.ContainsKey(7)}");

            // Equals(Object)

            // Clear()
            Console.Out.WriteLine("Clear()");
            concurrentDictionary.Clear();
        }
    }
}