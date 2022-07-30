using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ListDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // assignment
            List<int> list = new List<int>();
            // Add
            list.Add(5);
            list.Add(6);
            // Count
            Console.Out.WriteLine($"list.Count={list.Count}");
            // Item[Int32]
            Console.Out.WriteLine($"list[0]={list[0]}");
            // Contains(T)
            Console.Out.WriteLine($"list.Contains(5)={list.Contains(5)}");
            Console.Out.WriteLine($"list.Contains(7)={list.Contains(7)}");
            // CopyTo(T[])
            int[] ints = new int[list.Count];
            list.CopyTo(ints); // CopyTo(T[],  Int32) the same as list.CopyTo(ints,0)
            foreach (int item in ints)
            {
                Console.Out.Write($"{item} ");
            }

            Console.Out.WriteLine();
            // Equals(Object)
            Console.Out.WriteLine($"list.Equals(list)={list.Equals(list)}");
            // Clear()
            Console.Out.WriteLine("Clear()");
            list.Clear();
            // AddRange(IEnumerable<T>)
            Console.Out.WriteLine("AddRange(IEnumerable<T>)");
            int[] ints1 = {9, 8, 7, 6, 5, 4, 3, 2, 1};
            list.AddRange(ints1);
            // foreach traverse
            foreach (int item in list)
            {
                Console.Out.Write($"{item} ");
            }

            Console.Out.WriteLine();
            // FindAll(Predicate<T>)
            List<int> resultList = list.FindAll(GreaterThanFive);
            List<int>.Enumerator enumerator = resultList.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.Out.Write($"{enumerator.Current} ");
            }

            Console.Out.WriteLine();

            // Find(Predicate<T>)
            Console.Out.WriteLine($"list.Find(GreaterThanFive)={list.Find(GreaterThanFive)}");
            Console.Out.WriteLine();
            // FindIndex(Int32,  Int32, Predicate<T>)
            Console.Out.WriteLine(
                $"list.FindIndex(0, list.Count, GreaterThanFive)={list.FindIndex(0, list.Count, GreaterThanFive)}");

            // FindLast(Predicate<T>)
            Console.Out.WriteLine($"list.FindLast(GreaterThanFive)={list.FindLast(GreaterThanFive)}");
            // FindLastIndex(Predicate<T>)
            Console.Out.WriteLine($"list.FindLastIndex(GreaterThanFive)={list.FindLastIndex(GreaterThanFive)}");

            // ForEach(Action<T>)
            list.ForEach(ForEachAction);
            Console.Out.WriteLine();

            // Insert(Int32,  T)
            list.Insert(5, 100);

            // GetEnumerator()
            enumerator = list.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.Out.Write($"{enumerator.Current} ");
            }

            Console.Out.WriteLine();
            // GetHashCode()
            Console.Out.WriteLine($"enumerator.GetHashCode()={enumerator.GetHashCode()}");

            // GetType()
            Console.Out.WriteLine($"{list.GetType()}");

            // IndexOf(T)
            Console.Out.WriteLine($"list.IndexOf(6)={list.IndexOf(6)}");

            // LastIndexOf(T)
            Console.Out.WriteLine($"list.LastIndexOf(2)={list.LastIndexOf(2)}");

            // Remove(T)
            Console.Out.WriteLine("list.Remove(100)");
            list.Remove(100);

            // Remove(T)
            Console.Out.WriteLine("list.RemoveAt(0)");
            list.RemoveAt(0);

            // GetEnumerator()
            enumerator = list.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.Out.Write($"{enumerator.Current} ");
            }

            Console.Out.WriteLine();

            // Reverse()
            Console.Out.WriteLine("Reverse()");
            list.Reverse();

            // GetEnumerator()
            enumerator = list.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.Out.Write($"{enumerator.Current} ");
            }

            Console.Out.WriteLine();

            // Reverse(Int32,  Int32)
            Console.Out.WriteLine("Reverse(Int32,  Int32)");
            list.Reverse(2, 5);

            enumerator = list.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.Out.Write($"{enumerator.Current} ");
            }

            Console.Out.WriteLine();

            // Sort()
            Console.Out.WriteLine("Sort()");
            list.Sort();

            // GetEnumerator()
            enumerator = list.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.Out.Write($"{enumerator.Current} ");
            }

            Console.Out.WriteLine();

            // ToArray()
            Console.Out.WriteLine("ToArray()");
            int[] array = list.ToArray();
            for (int i = 0; i < array.Length; ++i)
            {
                Console.Out.Write($"{array[i]} ");
            }

            Console.Out.WriteLine();

            // ToString()
            Console.Out.WriteLine($"list.ToString()={list.ToString()}");

            // Capacity
            Console.Out.WriteLine($"list.Capacity={list.Capacity}");

            // TrimExcess()
            Console.Out.WriteLine("TrimExcess()");

            // Capacity
            Console.Out.WriteLine($"list.Capacity={list.Capacity}");

            // TrueForAll(Predicate<T>)
            Console.Out.WriteLine($"{list.TrueForAll(TrueForAllPredicate)}");
        }

        static private bool GreaterThanFive(int i)
        {
            return (i > 5) ? true : false;
        }

        static private void ForEachAction(int i)
        {
            Console.Out.Write($"{i} ");
        }

        static private bool TrueForAllPredicate(int i)
        {
            return (i < 10) ? true : false;
        }
    }
}