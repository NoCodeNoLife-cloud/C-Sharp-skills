using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace SortedListDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // assignment
            SortedList sortedList = new SortedList();

            // Capacity
            Console.Out.WriteLine($"sortedList.Capacity={sortedList.Capacity}");

            // Count
            Console.Out.WriteLine($"sortedList.Count={sortedList.Count}");

            // IsFixedSize
            Console.Out.WriteLine($"sortedList.IsFixedSize{sortedList.IsFixedSize}");

            // IsReadOnly
            Console.Out.WriteLine($"sortedList.IsReadOnly={sortedList.IsReadOnly}");

            // IsSynchronized
            Console.Out.WriteLine($"sortedList.IsSynchronized={sortedList.IsSynchronized}");

            // GetHashCode
            Console.Out.WriteLine($"sortedList.GetHashCode()={sortedList.GetHashCode()}");

            // ToString()
            Console.Out.WriteLine($"sortedList.ToString()={sortedList.ToString()}");

            // Add(Object, Object)
            Console.Out.WriteLine("Add(Object, Object)");
            sortedList.Add(7, 9);
            sortedList.Add(1, 5);
            sortedList.Add(2, 2);
            sortedList.Add(8, 7);
            sortedList.Add(3, 4);
            sortedList.Add(4, 9);

            // SetByIndex(Int32,  Object)
            Console.Out.WriteLine("SetByIndex(Int32,  Object)");
            sortedList.SetByIndex(0, 1000);

            // IndexOfKey(Object)
            Console.Out.WriteLine($"sortedList.IndexOfKey(2)={sortedList.IndexOfKey(2)}");

            // IndexOfValue(Object)
            Console.Out.WriteLine($"sortedList.IndexOfValue(5)={sortedList.IndexOfValue(5)}");

            // GetKey(Int32)
            Console.Out.WriteLine($"sortedList.GetKey(1)={sortedList.GetKey(1)}");

            // GetKeyList()
            IList list = sortedList.GetKeyList();
            foreach (int item in list)
            {
                Console.Out.Write($"{item} ");
            }

            Console.Out.WriteLine();

            // GetValueList()
            IEnumerator enumerator = sortedList.GetValueList().GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.Out.Write($"{enumerator.Current} ");
            }

            Console.Out.WriteLine();

            // GetType()
            Console.Out.WriteLine($"sortedList.GetType()={sortedList.GetType()}");

            // Item[Object]
            Console.Out.WriteLine($"sortedList[0]={sortedList[0]}");

            // Remove(Object)
            Console.Out.WriteLine("Remove(Object)");
            sortedList.Remove(7);

            // RemoveAt(Int32)
            Console.Out.WriteLine("RemoveAt(Int32)");
            sortedList.RemoveAt(1);

            // GetEnumerator()
            Console.Out.WriteLine("GetEnumerator()");
            enumerator = sortedList.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.Out.WriteLine($"{enumerator.Current}");
            }

            // GetByIndex(Int32)
            Console.Out.WriteLine($"sortedList.GetByIndex(1)={sortedList.GetByIndex(0)}");

            // CopyTo(Array,  Int32)
            Console.Out.WriteLine("CopyTo(Array,  Int32)");
            DictionaryEntry[] array = new DictionaryEntry[sortedList.Count];
            sortedList.CopyTo(array, 0);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Out.WriteLine($"{array[i].Key} {array[i].Value}");
            }

            // Contains(Object)
            Console.Out.WriteLine($"sortedList.Contains(\"hello\")={sortedList.Contains(1)}");

            // ContainsKey(Object)
            Console.Out.WriteLine($"sortedList.ContainsKey(\"hello\"){sortedList.ContainsKey(1)}");

            // ContainsValue(Object)
            Console.Out.WriteLine($"sortedList.ContainsValue(\"world\")={sortedList.ContainsValue(6)}");

            // Keys
            Console.Out.WriteLine("Keys");
            ICollection collection = sortedList.Keys;
            foreach (var item in collection)
            {
                Console.Out.Write($"{item} ");
            }

            Console.Out.WriteLine();

            // Values
            Console.Out.WriteLine("Values");
            collection = sortedList.Values;
            foreach (var item in collection)
            {
                Console.Out.Write($"{item} ");
            }

            Console.Out.WriteLine();

            // Clone()
            Console.Out.WriteLine("Clone()");
            SortedList sortedListClone = (SortedList) sortedList.Clone();
            foreach (DictionaryEntry item in sortedList)
            {
                Console.Out.WriteLine($"{item.Key} {item.Value}");
            }

            // Synchronized(SortedList)
            Console.Out.WriteLine("Synchronized(SortedList)");
            SortedList sortedListSynchronized = SortedList.Synchronized(sortedList);
            for (int i = 0; i < sortedListSynchronized.Count; i++)
            {
                Console.Out.WriteLine($"{sortedListSynchronized.GetKey(i)} {sortedListSynchronized.GetByIndex(i)}");
            }

            // Equals(Object)
            Console.Out.WriteLine($"sortedList.Equals(sortedListClone)={sortedList.Equals(sortedListClone)}");

            // Clear()
            Console.Out.WriteLine("Clear()");
            sortedList.Clear();
        }
    }
}