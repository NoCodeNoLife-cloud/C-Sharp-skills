using System;

namespace Tuple
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Tuple<int, int> tuple = new Tuple<int, int>(4, 5);
            tuple = Swap(tuple);
            Console.Out.WriteLine(tuple);
        }

        public static Tuple<int, int> Swap(Tuple<int, int> tuple)
        {
            return new Tuple<int, int>(tuple.Item2, tuple.Item1);
        }
    }
}