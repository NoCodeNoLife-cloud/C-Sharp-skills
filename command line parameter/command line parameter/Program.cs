using System;

namespace command_line_parameter
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            foreach (string item in args)
            {
                Console.Out.Write($"{item} ");
            }
        }
    }
}