using System;
using System.Linq;

namespace aggregate_method
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string[] curries = {"pathia", "jalfrezi", "korma"};
            Console.Out.WriteLine(curries.Aggregate((a, b) => a + " " + b));
            Console.Out.WriteLine(curries.Aggregate<string, string, string>("Some curries:", (a, b) => a + " " + b, a => a));
            Console.Out.WriteLine(curries.Aggregate<string, string, int>("Some curries:", (a, b) => a + " " + b, a => a.Length));
        }
    }
}