using System;

namespace function_overloading
{
    internal class Program
    {
        private static void checkType(int i)
        {
            Console.Out.WriteLine("this is int");
        }

        private static void checkType(double d)
        {
            Console.Out.WriteLine("this is double");
        }

        private static void checkType(string s)
        {
            Console.Out.WriteLine("this is string");
        }

        public static void Main(string[] args)
        {
            checkType(5);
            checkType(5.0);
            checkType("hello");
        }
    }
}