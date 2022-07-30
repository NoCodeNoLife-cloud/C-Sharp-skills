using System;
using System.Collections;

namespace StackDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // assignment
            Stack stack = new Stack();

            // ToString()
            Console.Out.WriteLine($"stack.ToString()={stack.ToString()}");

            // Push(Object)
            Console.Out.WriteLine("Push(Object)");
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Push(6);
            stack.Push(7);


            // Peek()
            Console.Out.WriteLine($"stack.Peek()={stack.Peek()}");
            Console.Out.WriteLine($"stack.Peek()={stack.Peek()}");
            Console.Out.WriteLine($"stack.Peek()={stack.Peek()}");

            // Pop()
            Console.Out.WriteLine("Pop()");
            stack.Pop();

            // Count
            Console.Out.WriteLine($"stack.Count={stack.Count}");

            // GetHashCode()
            Console.Out.WriteLine($"stack.GetHashCode()={stack.GetHashCode()}");

            // GetType()
            Console.Out.WriteLine($"stack.GetType()={stack.GetType()}");

            // GetEnumerator()
            Console.Out.WriteLine("GetEnumerator()");
            IEnumerator enumerator = stack.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.Out.Write($"{enumerator.Current} ");
            }

            Console.Out.WriteLine();

            // Contains(Object)
            Console.Out.WriteLine($"stack.Contains(1)={stack.Contains(1)}");

            // CopyTo(Array,  Int32)
            Array array = new int[stack.Count];
            stack.CopyTo(array, 0);
            foreach (var item in stack)
            {
                Console.Out.Write($"{item} ");
            }

            Console.Out.WriteLine();

            // Clone()
            Stack stackClone = (Stack) stack.Clone();
            foreach (var item in stackClone)
            {
                Console.Out.Write($"{item} ");
            }

            Console.Out.WriteLine();

            // Equals(Object)
            Console.Out.WriteLine($"array.Equals(stackClone)={array.Equals(stackClone)}");

            // Synchronized(Stack)
            Console.Out.WriteLine("Synchronized(Stack)");
            Stack stackSynchronized = Stack.Synchronized(stack);
            foreach (var item in stackSynchronized)
            {
                Console.Out.Write($"{item} ");
            }

            Console.Out.WriteLine();

            // ToArray()
            array = stack.ToArray();
            foreach (var item in array)
            {
                Console.Out.Write($"{item} ");
            }

            Console.Out.WriteLine();

            // IsSynchronized
            Console.Out.WriteLine($"stack.IsSynchronized={stack.IsSynchronized}");

            // Clear()
            Console.Out.WriteLine("Clear()");
            stack.Clear();
        }
    }
}