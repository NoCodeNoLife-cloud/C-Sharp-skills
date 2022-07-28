using System;
using System.Collections.Generic;

namespace LinkedListDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // assignment
            LinkedList<int> linkedList = new LinkedList<int>();

            // ToString()
            Console.Out.WriteLine($"linkedList.ToString()={linkedList.ToString()}");

            // GetHashCode()
            Console.Out.WriteLine($"linkedList.GetHashCode()={linkedList.GetHashCode()}");

            // GetType()
            Console.Out.WriteLine($"linkedList.GetType()={linkedList.GetType()}");

            // AddFirst(T)
            Console.Out.WriteLine("AddFirst(T)");
            linkedList.AddFirst(1);
            linkedList.AddFirst(7);

            // AddLast(T)
            Console.Out.WriteLine("AddLast(T)");
            linkedList.AddLast(4);
            linkedList.AddLast(2);

            LinkedListNode<int> listNode = linkedList.First;
            do
            {
                if (listNode.Value == 7)
                {
                    // AddBefore(LinkedListNode<T>,  T)
                    Console.Out.WriteLine("AddBefore(LinkedListNode<T>,  T)");
                    linkedList.AddBefore(listNode, 6);
                }

                if (listNode.Value == 4)
                {
                    // AddAfter(LinkedListNode<T>,  T)
                    Console.Out.WriteLine("AddAfter(LinkedListNode<T>,  T)");
                    linkedList.AddAfter(listNode, 10);
                }
            } while ((listNode = listNode.Next) != null);

            // GetEnumerator()
            Console.Out.WriteLine("GetEnumerator()");
            LinkedList<int>.Enumerator enumerator = linkedList.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.Out.Write($"{enumerator.Current} ");
            }

            Console.Out.WriteLine();

            // RemoveFirst()
            Console.Out.WriteLine("RemoveFirst()");
            linkedList.RemoveFirst();

            // Contains(T)
            Console.Out.WriteLine($"linkedList.Contains(1)={linkedList.Contains(1)}");

            // Find(T)
            Console.Out.WriteLine($"linkedList.Find(4)={linkedList.Find(4)}");

            // Remove(T)
            Console.Out.WriteLine("Remove(T)");
            linkedList.Remove(1);

            // CopyTo(T[],  Int32)
            int[] ints = new int[linkedList.Count + 1];
            linkedList.CopyTo(ints, 1);
            for (int i = 0; i < ints.Length; ++i)
            {
                Console.Out.Write($"{ints.GetValue(i)} ");
            }

            Console.Out.WriteLine();

            // Equals(Object)
            Console.Out.WriteLine($"linkedList.Equals(linkedList)={linkedList.Equals(linkedList)}");

            // Clear()
            Console.Out.WriteLine("Clear()");
            linkedList.Clear();
        }
    }
}