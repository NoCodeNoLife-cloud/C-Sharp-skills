using System;
using System.Collections;

namespace QueueDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // assignment
            Queue queue = new Queue();

            // GetHashCode()
            Console.Out.WriteLine($"queue.GetHashCode()={queue.GetHashCode()}");

            // GetType()
            Console.Out.WriteLine($"queue.GetType()={queue.GetType()}");

            // Count
            Console.Out.WriteLine($"queue.Count={queue.Count}");

            // IsSynchronized
            Console.Out.WriteLine($"queue.IsSynchronized={queue.IsSynchronized}");

            // SyncRoot
            Console.Out.WriteLine($"queue.SyncRoot={queue.SyncRoot}");

            // ToString()
            Console.Out.WriteLine($"queue.ToString()={queue.ToString()}");

            // Enqueue(Object)
            Console.Out.WriteLine("Enqueue(Object)");
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            queue.Enqueue(6);
            queue.Enqueue(7);

            // GetEnumerator()
            IEnumerator enumerator = queue.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.Out.Write($"{enumerator.Current} ");
            }

            Console.Out.WriteLine();

            // Peek()
            Console.Out.WriteLine($"queue.Peek()={queue.Peek()}");
            Console.Out.WriteLine($"queue.Peek()={queue.Peek()}");

            // Dequeue()
            Console.Out.WriteLine($"queue.Dequeue()={queue.Dequeue()}");
            Console.Out.WriteLine($"queue.Dequeue()={queue.Dequeue()}");

            // Clone()
            Console.Out.WriteLine("Clone()");
            Queue queueClone = (Queue) queue.Clone();

            // Equals(Object)
            Console.Out.WriteLine($"queue.Equals(queueClone)={queue.Equals(queueClone)}");

            // Contains(Object)
            Console.Out.WriteLine($"queue.Contains(5)={queue.Contains(5)}");

            // Synchronized(Queue)
            Console.Out.WriteLine("Synchronized(Queue)");
            Queue queueSynchronized = Queue.Synchronized(queue);
            foreach (int item in queueSynchronized)
            {
                Console.Out.Write($"{item} ");
            }

            Console.Out.WriteLine();

            // ToArray()
            Array array = queue.ToArray();
            foreach (int item in array)
            {
                Console.Out.Write($"{item} ");
            }

            Console.Out.WriteLine();


            // Clear()
            Console.Out.WriteLine("Clear()");
            queue.Clear();

            // CopyTo(Array,  Int32)
            Console.Out.WriteLine("CopyTo(Array,  Int32)");
            array = new bool[queue.Count];
            queue.CopyTo(array, 0);
            foreach (int item in array)
            {
                Console.Out.Write($"{item} ");
            }

            Console.Out.WriteLine();

            // TrimToSize()
            Console.Out.WriteLine("TrimToSize()");
            queue.TrimToSize();
        }
    }
}