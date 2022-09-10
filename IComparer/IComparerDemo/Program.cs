using System;
using System.Collections;

namespace IComparerDemo
{
    internal class Program
    {
        public static void PrintIndexAndValues(IEnumerable list)
        {
            var i = 0;
            foreach (var item in list)
                Console.WriteLine($"   [{i++}]:  {item}");

            Console.WriteLine();
        }

        public static void Main(string[] args)
        {
            // Initialize a string array.
            string[] words =
            {
                "The", "quick", "brown", "fox", "jumps", "over",
                "the", "lazy", "dog"
            };

            // Display the array values.
            Console.WriteLine("The array initially contains the following values:");
            PrintIndexAndValues(words);

            // Sort the array values using the default comparer.
            Array.Sort(words);
            Console.WriteLine("After sorting with the default comparer:");
            PrintIndexAndValues(words);

            // Sort the array values using the reverse case-insensitive comparer.
            Array.Sort(words, new ReverserClass());
            Console.WriteLine("After sorting with the reverse case-insensitive comparer:");
            PrintIndexAndValues(words);
        }
    }
}