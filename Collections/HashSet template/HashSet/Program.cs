using System;
using System.Collections.Generic;

namespace HashSetDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // assignment
            HashSet<int> hashSet = new HashSet<int>();

            // Equals(Object)
            Console.Out.WriteLine($"hashSet.Equals(hashSet)={hashSet.Equals(hashSet)}");

            // GetHashCode()
            Console.Out.WriteLine($"hashSet.GetHashCode()={hashSet.GetHashCode()}");

            // GetType()
            Console.Out.WriteLine($"hashSet.GetType()={hashSet.GetType()}");

            // ToString()
            Console.Out.WriteLine($"hashSet.ToString()={hashSet.ToString()}");
            // Add(T)
            Console.Out.WriteLine("Add(T)");
            hashSet.Add(1);
            hashSet.Add(2);
            hashSet.Add(4);
            hashSet.Add(5);
            hashSet.Add(8);

            // GetEnumerator()
            Console.Out.WriteLine($"GetEnumerator()");
            HashSet<int>.Enumerator enumerator = hashSet.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.Out.Write($"{enumerator.Current} ");
            }

            Console.Out.WriteLine();

            // Remove(T)
            Console.Out.WriteLine("Remove(T)");
            hashSet.Remove(8);

            // CopyTo(T[])
            Console.Out.WriteLine("CopyTo(T[])");
            int[] ints = new int[hashSet.Count];
            hashSet.CopyTo(ints);
            foreach (int item in ints)
            {
                Console.Out.Write($"{item} ");
            }

            Console.Out.WriteLine();

            // Contains(T)
            Console.Out.WriteLine($"hashSet.Contains(1)={hashSet.Contains(1)}");

            LinkedList<int> list = new LinkedList<int>();
            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(4);

            // IsProperSubsetOf(IEnumerable<T>)
            Console.Out.WriteLine($"hashSet.IsProperSubsetOf(list)={hashSet.IsProperSubsetOf(list)}");

            // IsProperSupersetOf(IEnumerable<T>)
            Console.Out.WriteLine($"hashSet.IsProperSupersetOf(list)={hashSet.IsProperSupersetOf(list)}");

            // IsSubsetOf(IEnumerable<T>)
            Console.Out.WriteLine($"hashSet.IsSubsetOf(list)={hashSet.IsSubsetOf(list)}");

            // IsSupersetOf(IEnumerable<T>)
            Console.Out.WriteLine($"hashSet.IsSupersetOf(list)={hashSet.IsSupersetOf(list)}");


            // Count
            Console.Out.WriteLine($"hashSet.Count={hashSet.Count}");

            // RemoveWhere(Predicate<T>)
            hashSet.RemoveWhere(RemoveWherePredicate);

            // Clear()
            Console.Out.WriteLine($"Clear()");
            hashSet.Clear();
        }

        static bool RemoveWherePredicate(int i)
        {
            return (i % 2 == 0) ? true : false;
        }
    }
}