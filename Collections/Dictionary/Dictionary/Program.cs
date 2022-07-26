using System;
using System.Collections.Generic;

namespace DictionaryDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // assignment
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            // ToString
            Console.Out.WriteLine($"dictionary={dictionary}");
            // GetType
            Console.Out.WriteLine($"dictionary.GetType()={dictionary.GetType()}");
            // Add
            dictionary.Add("hello", "world");
            // ContainsKey
            Console.Out.WriteLine(
                $"dictionary.ContainsKey(\"hello\")={((dictionary.ContainsKey("hello")) ? "yes" : "no")}");
            // ContainsValue
            Console.Out.WriteLine(
                $"dictionary.ContainsValue(\"World\")={((dictionary.ContainsValue("World")) ? "yes" : "no")}");
            // GetHashCode
            Console.Out.WriteLine($"dictionary.GetHashCode()={dictionary.GetHashCode()}");
            // GetEnumerator
            Dictionary<string, string>.Enumerator enumerator = dictionary.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.Out.WriteLine(
                    $"enumerator.Current.Key={enumerator.Current.Key} enumerator.Current.Value={enumerator.Current.Value}");
            }

            // Item[TKey]
            Console.Out.WriteLine($"dictionary[\"hello\"]={dictionary["hello"]}");
            // Count
            Console.Out.WriteLine($"dictionary.Count={dictionary.Count}");
            // Keys
            Dictionary<string, string>.KeyCollection keys = dictionary.Keys;
            Dictionary<string, string>.KeyCollection.Enumerator keyEnumerator = keys.GetEnumerator();
            Console.Out.WriteLine("Keys:");
            while (keyEnumerator.MoveNext())
            {
                Console.Out.WriteLine($"{keyEnumerator.Current}");
            }

            // Values
            Dictionary<string, string>.ValueCollection values = dictionary.Values;
            Dictionary<string, string>.ValueCollection.Enumerator valueEnumerator = values.GetEnumerator();
            Console.Out.WriteLine("Values:");
            while (valueEnumerator.MoveNext())
            {
                Console.Out.WriteLine($"{valueEnumerator.Current}");
            }
        }
    }
}