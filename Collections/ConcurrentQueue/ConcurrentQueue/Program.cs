using System;
using System.Collections;
using System.Collections.Concurrent;

namespace ConcurrentQueueDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // assignment
            ConcurrentQueue<int> concurrentQueue = new ConcurrentQueue<int>();

            // GetHashCode()
            Console.Out.WriteLine($"concurrentQueue.GetHashCode()={concurrentQueue.GetHashCode()}");

            // ToString()
            Console.Out.WriteLine($"concurrentQueue.ToString()={concurrentQueue.ToString()}");

            // GetType()
            Console.Out.WriteLine($"concurrentQueue.GetType()={concurrentQueue.GetType()}");

            // CopyTo(T[],  Int32)
            Console.Out.WriteLine("CopyTo(T[],  Int32)");
            concurrentQueue.Enqueue(1);
            concurrentQueue.Enqueue(2);
            concurrentQueue.Enqueue(3);
            concurrentQueue.Enqueue(4);
            concurrentQueue.Enqueue(5);

            // Count
            Console.Out.WriteLine($"concurrentQueue.Count={concurrentQueue.Count}");

            // IsEmpty
            Console.Out.WriteLine($"concurrentQueue.IsEmpty={concurrentQueue.IsEmpty}");

            // GetEnumerator()
            IEnumerator enumerator = concurrentQueue.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.Out.Write($"{enumerator.Current} ");
            }

            Console.Out.WriteLine();

            // CopyTo(T[],  Int32)
            Console.Out.WriteLine("CopyTo(T[],  Int32)");
            int[] ints = new int[concurrentQueue.Count];
            concurrentQueue.CopyTo(ints, 0);
            foreach (int item in ints)
            {
                Console.Out.Write($"{item} ");
            }

            Console.Out.WriteLine();

            // ToArray()
            Console.Out.WriteLine("ToArray()");
            ints = concurrentQueue.ToArray();
            foreach (int item in ints)
            {
                Console.Out.Write($"{item} ");
            }

            Console.Out.WriteLine();

            // Equals(Object)
            Console.Out.WriteLine($"concurrentQueue.Equals(concurrentQueue)={concurrentQueue.Equals(concurrentQueue)}");
        }
    }
}