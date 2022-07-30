using System;
using System.Collections;
using System.Dynamic;

namespace ArrayListDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // assignment
            ArrayList arrayList = new ArrayList();

            // GetHashCode()
            Console.Out.WriteLine($"arrayList.GetHashCode()={arrayList.GetHashCode()}");

            // ToString()
            Console.Out.WriteLine($"arrayList.ToString()={arrayList.ToString()}");

            // GetType()
            Console.Out.WriteLine($"arrayList.GetType(){arrayList.GetType()}");

            // Capacity
            Console.Out.WriteLine($"arrayList.Capacity={arrayList.Capacity}");

            // Count
            Console.Out.WriteLine($"arrayList.Count={arrayList.Count}");

            // IsFixedSize
            Console.Out.WriteLine($"arrayList.IsFixedSize()={arrayList.IsFixedSize}");

            // IsReadOnly
            Console.Out.WriteLine($"arrayList.IsReadOnly={arrayList.IsReadOnly}");

            // arrayList.IsSynchronized
            Console.Out.WriteLine($"arrayList.IsSynchronized={arrayList.IsSynchronized}");

            // Add(Object)
            arrayList.Add(4);
            arrayList.Add(8);
            arrayList.Add(3);
            arrayList.Add(0);
            arrayList.Add(9);
            arrayList.Add(7);
            arrayList.Add(2);
            arrayList.Add(5);
            arrayList.Add(1);

            // GetRange(Int32,  Int32)
            Console.Out.WriteLine("GetRange(Int32,  Int32)");
            IEnumerator enumerator = arrayList.GetRange(3, 3).GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.Out.Write($"{enumerator.Current} ");
            }

            Console.Out.WriteLine();

            // IndexOf(Object)
            Console.Out.WriteLine($"arrayList.IndexOf(7)={arrayList.IndexOf(7)}");

            // LastIndexOf(Object)
            Console.Out.WriteLine($"arrayList.LastIndexOf(7)={arrayList.LastIndexOf(7)}");

            // RemoveAt(Int32)
            Console.Out.WriteLine("RemoveAt(Int32)");
            arrayList.RemoveAt(arrayList.IndexOf(7));

            // Insert(Int32,  Object)
            Console.Out.WriteLine("Insert(Int32,  Object)");
            arrayList.Insert(0, 7);

            // GetEnumerator()
            Console.Out.WriteLine("GetEnumerator()");
            enumerator = arrayList.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.Out.Write($"{enumerator.Current} ");
            }

            Console.Out.WriteLine();

            // Sort()
            Console.Out.WriteLine("Sort()");
            arrayList.Sort();

            // BinarySearch(Object)
            Console.Out.WriteLine($"arrayList.BinarySearch(9)={arrayList.BinarySearch(9)}");

            // Remove(Object)
            Console.Out.WriteLine("Remove(Object)");
            arrayList.Remove(5);

            // Contains(Object)
            Console.Out.WriteLine($"arrayList.Contains(5)={arrayList.Contains(5)}");

            // ToArray()
            Console.Out.WriteLine("ToArray()");
            Object[] objects = arrayList.ToArray();
            foreach (int item in objects)
            {
                Console.Out.Write($"{item} ");
            }

            Console.Out.WriteLine();

            // Reverse()
            Console.Out.WriteLine("Reverse()");
            arrayList.Reverse();

            // CopyTo(Array)
            Console.Out.WriteLine("CopyTo(Array)");
            int[] ints = new int[arrayList.Count];
            arrayList.CopyTo(ints);
            foreach (int item in ints)
            {
                Console.Out.Write($"{item} ");
            }

            Console.Out.WriteLine();

            // Item[Int32]
            Console.Out.WriteLine($"arrayList[0]={arrayList[0]}");

            // Clone()
            ArrayList cloneArrayList = (ArrayList) arrayList.Clone();

            // Equals(Object)
            Console.Out.WriteLine($"arrayList.Equals(cloneArrayList)={arrayList.Equals(cloneArrayList)}");

            // Clear()
            Console.Out.WriteLine("Clear()");
            arrayList.Clear();

            // InsertRange(Int32,  ICollection)
            Console.Out.WriteLine("InsertRange(Int32,  ICollection)");
            arrayList.InsertRange(0, cloneArrayList);
            foreach (int item in arrayList)
            {
                Console.Out.Write($"{item} ");
            }

            Console.Out.WriteLine();

            // AddRange(ICollection)
            Console.Out.WriteLine("AddRange(ICollection)");
            arrayList.AddRange(cloneArrayList);
            foreach (int item in arrayList)
            {
                Console.Out.Write($"{item} ");
            }

            Console.Out.WriteLine();

            // RemoveRange(Int32,  Int32)
            Console.Out.WriteLine("RemoveRange(Int32,  Int32)");
            arrayList.RemoveRange(5, 8);
            foreach (int item in arrayList)
            {
                Console.Out.Write($"{item} ");
            }

            Console.Out.WriteLine();

            // FixedSize(ArrayList)
            // FixedSize(IList)
            Console.Out.WriteLine("FixedSize(ArrayList)");
            ArrayList arrayListFixed = ArrayList.FixedSize(arrayList);
            foreach (int item in arrayListFixed)
            {
                Console.Out.Write($"{item} ");
            }

            Console.Out.WriteLine();

            // Adapter(IList)

            // ReadOnly(ArrayList)
            // ReadOnly(IList)
            Console.Out.WriteLine("ReadOnly(ArrayList)");
            ArrayList arrayListReadOnly = ArrayList.ReadOnly(arrayList);
            foreach (int item in arrayListReadOnly)
            {
                Console.Out.Write($"{item} ");
            }

            Console.Out.WriteLine();

            // Repeat(Object,  Int32)
            // SetRange(Int32,  ICollection)

            // Synchronized(ArrayList)
            // Synchronized(IList)
            Console.Out.WriteLine("Synchronized(ArrayList)");
            ArrayList arrayListSynchronized = ArrayList.Synchronized(arrayList);
            foreach (int item in arrayListSynchronized)
            {
                Console.Out.Write($"{item} ");
            }

            Console.Out.WriteLine();
        }
    }
}