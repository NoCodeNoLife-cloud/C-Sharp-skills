using System;

namespace vector
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // assignment and initialize the array
            // method one
            int[] intArray = {1, 2, 3, 4, 5, 6, 7, 8, 9};
            // method two
            int[] intArray1 = new int[5];

            // Through the array
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.Out.Write($"{intArray.GetValue(i)} ");
            }

            Console.Out.Write(Console.Out.NewLine);

            // ToString
            Console.Out.WriteLine($"{intArray}");

            // foreach
            foreach (int item in intArray)
            {
                Console.Out.Write($"{item} ");
            }
        }
    }
}