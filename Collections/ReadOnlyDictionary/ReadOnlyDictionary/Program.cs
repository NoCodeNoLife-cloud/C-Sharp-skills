using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;

namespace ReadOnlyDictionaryDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            dictionary.Add(1, 2);
            dictionary.Add(3, 4);
            dictionary.Add(5, 6);
            dictionary.Add(7, 8);
            dictionary.Add(9, 10);

            // assignment
            ReadOnlyDictionary<int, int> readOnlyDictionary = new ReadOnlyDictionary<int, int>(dictionary);

            // Count
            Console.Out.WriteLine($"readOnlyDictionary.Count={readOnlyDictionary.Count}");

            // Item[TKey]
            Console.Out.WriteLine($"readOnlyDictionary[1]={readOnlyDictionary[1]}");

            // Keys
            ReadOnlyDictionary<int, int>.KeyCollection keyCollection = readOnlyDictionary.Keys;
            foreach (var item in keyCollection)
            {
                Console.Out.Write($"{item} ");
            }

            Console.Out.WriteLine();

            // Values
            ReadOnlyDictionary<int, int>.ValueCollection valueCollection = readOnlyDictionary.Values;
            foreach (var item in valueCollection)
            {
                Console.Out.Write($"{item} ");
            }

            Console.Out.WriteLine();

            // ContainsKey(TKey)
            Console.Out.WriteLine($"readOnlyDictionary.ContainsKey(5)={readOnlyDictionary.ContainsKey(5)}");

            // GetEnumerator()
            Console.Out.WriteLine("GetEnumerator()");
            IEnumerator enumerator = readOnlyDictionary.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.Out.Write($"{enumerator.Current} ");
            }

            Console.Out.WriteLine();

            // GetHashCode()
            Console.Out.WriteLine($"readOnlyDictionary.GetHashCode()={readOnlyDictionary.GetHashCode()}");

            // GetType()
            Console.Out.WriteLine($"readOnlyDictionary.GetType()={readOnlyDictionary.GetType()}");

            // ToString()
            Console.Out.WriteLine($"readOnlyDictionary.ToString()={readOnlyDictionary.ToString()}");

            // Equals(Object)
            Console.Out.WriteLine($"readOnlyDictionary.Equals(Directory)={readOnlyDictionary.Equals(dictionary)}");
        }
    }
}