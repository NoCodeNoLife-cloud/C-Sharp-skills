using System;
using System.Collections.Generic;

namespace SortedSetDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // assignment
            SortedSet<int> sortedSet = new SortedSet<int>();

            // GetHashCode()
            Console.Out.WriteLine($"sortedSet.GetHashCode()={sortedSet.GetHashCode()}");

            // GetType()
            Console.Out.WriteLine($"sortedSet.GetType()={sortedSet.GetType()}");

            // ToString()
            Console.Out.WriteLine($"sortedSet.ToString()={sortedSet.ToString()}");

            // Add(T)
            Console.Out.WriteLine("Add(T)");
            sortedSet.Add(4);
            sortedSet.Add(7);
            sortedSet.Add(9);
            sortedSet.Add(5);
            sortedSet.Add(3);

            // GetEnumerator()
            Console.Out.WriteLine("GetEnumerator()");
            SortedSet<int>.Enumerator enumerator = sortedSet.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.Out.Write($"{enumerator.Current} ");
            }

            Console.Out.WriteLine();

            // Reverse()
            Console.Out.WriteLine("Reverse()");
            IEnumerator<int> iEnumerator = sortedSet.Reverse().GetEnumerator();
            while (iEnumerator.MoveNext())
            {
                Console.Out.Write($"{iEnumerator.Current} ");
            }

            Console.Out.WriteLine();

            // GetViewBetween(T,  T)
            Console.Out.WriteLine("GetViewBetween(T,  T)");
            enumerator = sortedSet.GetViewBetween(6, 10).GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.Out.Write($"{enumerator.Current} ");
            }

            Console.Out.WriteLine();

            // Equals(Object)
            Console.Out.WriteLine($"sortedSet.Equals(sortedSet)={sortedSet.Equals(sortedSet)}");

            // Contains(T)
            Console.Out.WriteLine($"sortedSet.Contains(5)={sortedSet.Contains(5)}");

            List<int> list = new List<int>();
            list.Add(3);
            list.Add(5);
            list.Add(7);

            // SetEquals(IEnumerable<T>)
            Console.Out.WriteLine($"sortedSet.SetEquals(list)={sortedSet.SetEquals(list)}");

            // IsProperSubsetOf(IEnumerable<T>)
            Console.Out.WriteLine($"sortedSet.IsProperSubsetOf(list)={sortedSet.IsProperSubsetOf(list)}");

            // IsProperSupersetOf(IEnumerable<T>)
            Console.Out.WriteLine($"sortedSet.IsProperSubsetOf(list)={sortedSet.IsProperSubsetOf(list)}");

            // IsSubsetOf(IEnumerable<T>)
            Console.Out.WriteLine($"sortedSet.IsSubsetOf(list)={sortedSet.IsSubsetOf(list)}");

            // IsSupersetOf(IEnumerable<T>)
            Console.Out.WriteLine($"sortedSet.IsSupersetOf(list)={sortedSet.IsSupersetOf(list)}");

            // ExceptWith(IEnumerable<T>)
            sortedSet.ExceptWith(list);

            // CopyTo(T[])
            Console.Out.WriteLine("CopyTo(T[])");
            int[] ints = new int[sortedSet.Count];
            sortedSet.CopyTo(ints);
            foreach (int item in ints)
            {
                Console.Out.Write($"{item} ");
            }

            Console.Out.WriteLine();

            // Count
            Console.Out.WriteLine($"sortedSet.Count={sortedSet.Count}");

            // Max
            Console.Out.WriteLine($"sortedSet.Max={sortedSet.Max}");

            // Remove(T)
            Console.Out.WriteLine("Remove(T)");
            sortedSet.Remove(sortedSet.Max);

            // Min
            Console.Out.WriteLine($"sortedSet.Min={sortedSet.Min}");

            // RemoveWhere(Predicate<T>)
            Console.Out.WriteLine("RemoveWhere(Predicate<T>)");
            sortedSet.RemoveWhere(RemoveWherePredicate);

            // Clear()
            sortedSet.Clear();
        }

        static bool RemoveWherePredicate(int i)
        {
            return (i % 2 == 0) ? true : false;
        }
    }
}