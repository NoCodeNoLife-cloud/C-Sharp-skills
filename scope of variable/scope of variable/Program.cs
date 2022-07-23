using System;

namespace scope_of_variable
{
    internal class Program
    {
        // static global value
        private static int _sum;

        private static int Function(params int[] vec)
        {
            foreach (int item in vec)
            {
                _sum += item;
            }

            return _sum;
        }

        public static void Main(string[] args)
        {
            Console.Out.WriteLine($"{Function(1, 2, 3, 4, 5, 6, 7, 8)}");

            // local varible
            string str = "";
            for (int i = 0; i < 10; i++)
            {
                str += i.ToString();
            }

            Console.Out.WriteLine($"{str}");
        }
    }
}