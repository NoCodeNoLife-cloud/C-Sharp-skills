using System;

namespace multicast_delegate
{
    internal class Program
    {
        public delegate int AddDelegate(int a);

        public static void Main(string[] args)
        {
            AddDelegate addDelegate = (int i) => { return i + 10; };
            addDelegate += (int i) => { return i - 10; };
            foreach (AddDelegate item in addDelegate.GetInvocationList())
            {
                Console.Out.WriteLine($"{item(1)}");
            }
        }
    }
}