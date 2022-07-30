using System;
using System.Collections.Generic;

namespace StackDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // assignment
            Stack<int> stack = new Stack<int>();

            // ToString()
            Console.Out.WriteLine($"stack.ToString()={stack.ToString()}");

            // GetHashCode()
            Console.Out.WriteLine($"stack.GetHashCode()={stack.GetHashCode()}");

            // Push(T)
            Console.Out.WriteLine("Push(T)");
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);

            // ToArray()
            Console.Out.WriteLine("ToArray()");
            int[] ints = stack.ToArray();
            foreach (int item in ints)
            {
                Console.Out.Write($"{item} ");
            }

            Console.Out.WriteLine();

            // CopyTo(T[],  Int32)
            Console.Out.WriteLine("CopyTo(T[],  Int32)");
            int[] intss = new int[stack.Count + 3];
            stack.CopyTo(intss, 3);
            for (int i = 0; i < intss.Length; ++i)
            {
                Console.Out.Write($"{intss.GetValue(i)} ");
            }

            Console.Out.WriteLine();

            // Count
            Console.Out.WriteLine($"stack.Count={stack.Count}");

            // Pop()
            Console.Out.WriteLine("Pop()");
            stack.Pop();

            // GetEnumerator()
            Console.Out.WriteLine("GetEnumerator()");
            Stack<int>.Enumerator enumerator = stack.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.Out.Write($"{enumerator.Current} ");
            }

            Console.Out.WriteLine();

            // Peek()
            Console.Out.WriteLine($"stack.Peek()={stack.Peek()}");

            // TrimExcess()
            stack.TrimExcess();

            // Equals(Object)
            Stack<int> temp = new Stack<int>();
            temp.Push(1);
            Console.Out.WriteLine($"stack.Equals(temp)={stack.Equals(temp)}");

            // Contains(T)
            Console.Out.WriteLine($"stack.Contains(3)={stack.Contains(3)}");

            // GetType()
            Console.Out.WriteLine($"stack.GetType()={stack.GetType()}");
        }
    }
}