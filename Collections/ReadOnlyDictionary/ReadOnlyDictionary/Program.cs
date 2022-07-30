using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        }
    }
}