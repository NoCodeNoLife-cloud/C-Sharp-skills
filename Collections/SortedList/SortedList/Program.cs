using System;
using System.Collections;
using System.Collections.Generic;

namespace SortedListDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // assignment
            SortedList<int, int> sortedList = new SortedList<int, int>();

            // Capacity
            Console.Out.WriteLine($"sortedList.Capacity={sortedList.Capacity}");

            // Equals(Object)
            Console.Out.WriteLine($"sortedList.Equals(new SortedList())={sortedList.Equals(new SortedList())}");

            // Count
            Console.Out.WriteLine($"sortedList.Count={sortedList.Count}");

            // GetHashCode()
            Console.Out.WriteLine($"sortedList.GetHashCode()={sortedList.GetHashCode()}");

            // GetType()
            Console.Out.WriteLine($"sortedList.GetType()={sortedList.GetType()}");

            // ToString()
            Console.Out.WriteLine($"sortedList.ToString()={sortedList.ToString()}");

            // Item[TKey]
            sortedList[1] = 10;
            Console.Out.WriteLine($"sortedList[1]={sortedList[1]}");

            // Add(TKey, TValue)
            Console.Out.WriteLine("Add(TKey, TValue)");
            sortedList.Add(2, 20);
            sortedList.Add(3, 30);
            sortedList.Add(4, 40);

            // IndexOfKey(TKey)
            Console.Out.WriteLine($"sortedList.IndexOfKey(1)={sortedList.IndexOfKey(1)}");

            // IndexOfValue(TValue)
            Console.Out.WriteLine($"sortedList.IndexOfValue(2)={sortedList.IndexOfValue(2)}");

            // Remove(TKey)
            Console.Out.WriteLine("Remove(TKey)");
            sortedList.Remove(2);

            // RemoveAt(Int32)
            Console.Out.WriteLine("RemoveAt(Int32)");
            sortedList.RemoveAt(0);

            // TrimExcess()
            Console.Out.WriteLine("TrimExcess()");
            sortedList.TrimExcess();

            // ContainsKey(TKey)
            Console.Out.WriteLine($"sortedList.ContainsKey(2)={sortedList.ContainsKey(2)}");

            // ContainsValue(TValue)
            Console.Out.WriteLine($"sortedList.ContainsValue(500)={sortedList.ContainsValue(500)}");

            // Keys
            Console.Out.WriteLine("Keys");
            IList<int> list = sortedList.Keys;
            foreach (int item in list)
            {
                Console.Out.Write($"{item} ");
            }

            Console.Out.WriteLine();

            // Values
            Console.Out.WriteLine("Values");
            list = sortedList.Values;
            foreach (int item in list)
            {
                Console.Out.Write($"{item} ");
            }

            Console.Out.WriteLine();

            // GetEnumerator()
            Console.Out.WriteLine("GetEnumerator()");
            IEnumerator<KeyValuePair<int, int>> enumerator = sortedList.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.Out.WriteLine($"{enumerator.Current.Key} {enumerator.Current.Value}");
            }

            // Clear()
            sortedList.Clear();
        }
    }
}