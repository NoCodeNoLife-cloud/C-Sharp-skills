using System;

namespace Func
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Func<int, int, int, double> func = MyFunction;
            Console.Out.WriteLine($"{func(1, 4, 6)}");
        }

        public static double MyFunction(int i, int j, int k)
        {
            return (double) (i + j) / (double) (k);
        }
    }
}