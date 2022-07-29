using System;
using System.Collections;

namespace HashtableDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // assignment
            Hashtable hashtable = new Hashtable();

            // GetHash(Object)
            Console.Out.WriteLine($"hashtable.GetHashCode()={hashtable.GetHashCode()}");

            // GetType()
            Console.Out.WriteLine($"hashtable.GetType()={hashtable.GetType()}");

            // ToString()
            Console.Out.WriteLine($"hashtable.ToString()={hashtable.ToString()}");

            // IsFixedSize
            Console.Out.WriteLine($"hashtable.IsFixedSize={hashtable.IsFixedSize}");

            // IsReadOnly
            Console.Out.WriteLine($"hashtable.IsReadOnly={hashtable.IsReadOnly}");

            // IsSynchronized
            Console.Out.WriteLine($"hashtable.IsSynchronized={hashtable.IsSynchronized}");

            // Add(Object, Object)
            hashtable.Add(5, 4);
            hashtable.Add("hello", "world");

            // Count
            Console.Out.WriteLine($"hashtable.Count={hashtable.Count}");

            // GetEnumerator()
            Console.Out.WriteLine("GetEnumerator()");
            IDictionaryEnumerator dictionaryEnumerator = hashtable.GetEnumerator();
            while (dictionaryEnumerator.MoveNext())
            {
                Console.Out.Write($"{dictionaryEnumerator.Current} ");
            }

            Console.Out.WriteLine();

            // Remove(Object)
            Console.WriteLine("Remove(Object)");
            hashtable.Remove("hello");

            // Contains(Object)
            Console.Out.WriteLine($"hashtable.Contains(\"hello\")={hashtable.Contains("hello")}");

            // ContainsKey(Object)
            Console.Out.WriteLine($"hashtable.ContainsKey(\"8\")={hashtable.ContainsKey("8")}");

            // ContainsValue(Object)
            Console.Out.WriteLine($"hashtable.ContainsValue(\"4\")={hashtable.ContainsValue("4")}");
            // Item[Object]
            Console.Out.WriteLine($"hashtable[5]={hashtable[5]}");

            // Keys
            Console.Out.WriteLine("Keys");
            IEnumerator enumerator = hashtable.Keys.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.Out.Write($"{enumerator.Current} ");
            }

            Console.Out.WriteLine();

            // Values
            Console.Out.WriteLine("Values");
            enumerator = hashtable.Values.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.Out.Write($"{enumerator.Current} ");
            }

            Console.Out.WriteLine();

            // Clone()
            Hashtable cHashtable = (Hashtable) hashtable.Clone();

            // Equals(Object)
            Console.Out.WriteLine($"hashtable.Equals(cHashtable)={hashtable.Equals(cHashtable)}");

            // Clear()
            hashtable.Clear();
        }
    }
}