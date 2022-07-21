using System;

namespace enumTest
{
    internal class Program
    {
        enum Color
        {
            R = 0,
            G = 1,
            B = 2
        }

        public static void Main(string[] args)
        {
            Color color = Color.R;
            if (color == Color.R)
            {
                Console.Out.WriteLine("R");
            }
            else if (color == Color.G)
            {
                Console.Out.WriteLine("G");
            }
            else if (color == Color.B)
            {
                Console.Out.WriteLine("B");
            }
            else
            {
                Console.Out.WriteLine("another color");
            }
        }
    }
}