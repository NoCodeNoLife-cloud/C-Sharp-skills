using System;
using System.Collections;
using System.Collections.Concurrent;

namespace ConcurrentStackDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // assignment
            ConcurrentStack<int> concurrentStack = new ConcurrentStack<int>();

            // GetHashCode()
            Console.Out.WriteLine($"concurrentStack.GetHashCode()={concurrentStack.GetHashCode()}");

            // GetType()
            Console.Out.WriteLine($"concurrentStack.GetType()={concurrentStack.GetType()}");

            // ToString()
            Console.Out.WriteLine($"concurrentStack.ToString()={concurrentStack.ToString()}");

            // Push(T)
            Console.Out.WriteLine("Push(T)");
            concurrentStack.Push(1);
            concurrentStack.Push(2);
            concurrentStack.Push(3);
            concurrentStack.Push(4);
            concurrentStack.Push(5);
            concurrentStack.Push(6);
            concurrentStack.Push(7);

            // GetEnumerator()
            Console.Out.WriteLine("GetEnumerator()");
            IEnumerator enumerator = concurrentStack.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.Out.Write($"{enumerator.Current} ");
            }

            Console.Out.WriteLine();

            // Count
            Console.Out.WriteLine($"concurrentStack.Count={concurrentStack.Count}");

            // CopyTo(T[],  Int32)
            Console.Out.WriteLine("CopyTo(T[],  Int32)");
            int[] ints = new int[concurrentStack.Count];
            concurrentStack.CopyTo(ints, 0);
            foreach (var item in ints)
            {
                Console.Out.Write($"{item} ");
            }

            Console.Out.WriteLine();

            // PushRange(T[])
            Console.Out.WriteLine("PushRange(T[])");
            concurrentStack.PushRange(ints);

            // ToArray()
            Console.Out.WriteLine("ToArray()");
            ints = concurrentStack.ToArray();
            foreach (var item in ints)
            {
                Console.Out.Write($"{item} ");
            }

            Console.Out.WriteLine();

            // Equals(Object)
            Console.Out.WriteLine($"concurrentStack.Equals(concurrentStack)={concurrentStack.Equals(concurrentStack)}");

            // Clear()
            Console.Out.WriteLine("Clear()");
            concurrentStack.Clear();

            // IsEmpty
            Console.Out.WriteLine($"concurrentStack.IsEmpty={concurrentStack.IsEmpty}");
        }
    }
}