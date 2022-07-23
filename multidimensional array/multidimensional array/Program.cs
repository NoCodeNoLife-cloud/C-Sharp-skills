using System;

namespace multidimensional_array
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // version one
            // assign multidimensional array
            double[,] hillHeight = {{1, 2, 3, 4}, {2, 3, 4, 5}, {3, 4, 5, 6}};

            // foreach
            foreach (double item in hillHeight)
            {
                Console.Out.Write($"{item} ");
            }

            Console.Out.Write(Console.Out.NewLine);
            // GetLength
            for (int i = 0; i < hillHeight.GetLength(0); i++)
            {
                for (int j = 0; j < hillHeight.GetLength(1); j++)
                {
                    Console.Out.Write($"{hillHeight.GetValue(i, j)} ");
                }
            }

            Console.Out.Write(Console.Out.NewLine);

            // version two
            // assign
            int[][] multiVector = new int[2][];
            multiVector[0] = new int[3] {1, 2, 3};
            multiVector[1] = new int[4] {4, 5, 6, 7};

            // traverse
            for (int i = 0; i < multiVector.Length; i++)
            {
                for (int j = 0; j < multiVector[i].Length; j++)
                {
                    Console.Out.Write($"{multiVector[i][j]} ");
                }
            }

            Console.Out.Write(Console.Out.NewLine);

            // foreach traverse
            foreach (int[] items in multiVector)
            {
                foreach (int item in items)
                {
                    Console.Out.Write($"{item} ");
                }
            }

            Console.Out.Write(Console.Out.NewLine);

            // version three
            // assign
            int[][] vectors = {new int[] {1, 2, 3}, new int[] {1}, new int[] {1, 2, 3, 4}};

            // traverse
            for (int i = 0; i < vectors.Length; i++)
            {
                for (int j = 0; j < vectors[i].Length; j++)
                {
                    Console.Out.Write($"{vectors[i][j]} ");
                }
            }

            Console.Out.Write(Console.Out.NewLine);

            // foreach traverse
            foreach (int[] items in vectors)
            {
                foreach (int item in items)
                {
                    Console.Out.Write($"{item} ");
                }
            }

            Console.Out.Write(Console.Out.NewLine);
        }
    }
}