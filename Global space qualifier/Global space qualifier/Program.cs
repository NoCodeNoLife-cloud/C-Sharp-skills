using System;
// use alias
using Global_space_qualifier_aliace = Global_space_qualifier;

namespace Global_space_qualifier
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // alias
            Global_space_qualifier_aliace::Example.PrintHello();
        }
    }

    static public class Example
    {
        static public void PrintHello()
        {
            Console.Out.WriteLine("Hello");
        }
    }
}