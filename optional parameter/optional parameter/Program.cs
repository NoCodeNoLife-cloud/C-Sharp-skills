using System;

namespace optional_parameter
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            function(parameter1: 3, parameter2: 52.5);
            function(10, 10.12, "hello");
            function(parameter1: 84, parameter2: 47.12, parameter3: "world", parameter4: 252);
        }

        private static void function(int parameter1, double parameter2, string parameter3 = "string", int parameter4 = 5)
        {
            Console.Out.WriteLine($"{parameter1} {parameter2} {parameter3} {parameter4}");
        }
    }
}