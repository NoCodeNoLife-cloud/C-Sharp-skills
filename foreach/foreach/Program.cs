using System;

namespace foreachDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] intVector = {1, 2, 3, 4, 5, 6, 7, 8, 9};
            foreach (int item in intVector)
            {
                Console.Out.Write($"{item} ");
            }
        }
    }
}