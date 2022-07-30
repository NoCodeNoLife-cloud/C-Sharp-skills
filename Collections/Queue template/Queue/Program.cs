using System;
using System.Collections.Generic;

namespace QueueDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // assignment
            Queue<int> queue = new Queue<int>();

            // GetHashCode()
            Console.Out.WriteLine($"{queue.GetHashCode()}");

            // GetType()
            Console.Out.WriteLine($"{queue.GetType()}");

            // ToString()
            Console.Out.WriteLine($"{queue.ToString()}");

            // Enqueue(T)
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            // Count
            Console.Out.WriteLine($"queue.Count={queue.Count}");

            // ToArray()
            Console.Out.WriteLine($"ToArray()");
            int[] ints = queue.ToArray();
            foreach (int item in ints)
            {
                Console.Out.Write($"{item} ");
            }

            Console.Out.WriteLine();

            // Peek()
            Console.Out.WriteLine($"queue.Peek()={queue.Peek()}");

            // GetEnumerator()
            Console.Out.WriteLine("GetEnumerator()");
            Queue<int>.Enumerator enumerator = queue.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.Out.Write($"{enumerator.Current} ");
            }

            Console.Out.WriteLine();

            // Dequeue()
            Console.Out.WriteLine($"queue.Dequeue()={queue.Dequeue()}");
            Console.Out.WriteLine($"queue.Dequeue()={queue.Dequeue()}");

            // TrimExcess()
            Console.Out.WriteLine("TrimExcess()");
            queue.TrimExcess();

            // Clear()
            Console.Out.WriteLine("Clear()");
        }
    }
}